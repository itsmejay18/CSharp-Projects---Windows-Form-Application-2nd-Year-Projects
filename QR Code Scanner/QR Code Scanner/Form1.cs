using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;

namespace QR_Code_Scanner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice CaptureDevice;

        private void Form1_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            foreach (FilterInfo filterInfo in filterInfoCollection)
                cboDevice.Items.Add(filterInfo.Name);

            if (cboDevice.Items.Count > 0)
            {
                for (int i = 0; i < filterInfoCollection.Count; i++)
                {
                    if (filterInfoCollection[i].Name.ToLower().Contains("front"))
                    {
                        cboDevice.SelectedIndex = i;
                        break;
                    }
                }

                if (cboDevice.SelectedIndex == -1)
                    cboDevice.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("No camera found!");
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (cboDevice.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a camera first.");
                return;
            }

            CaptureDevice = new VideoCaptureDevice(filterInfoCollection[cboDevice.SelectedIndex].MonikerString);
            CaptureDevice.NewFrame += CaptureDevice_NewFrame;
            CaptureDevice.Start();
            timer1.Start();
        }

        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            try
            {
                if (pictureBox.InvokeRequired)
                {
                    pictureBox.Invoke(new MethodInvoker(delegate
                    {
                        if (pictureBox.Image != null)
                        {
                            pictureBox.Image.Dispose();
                        }
                        pictureBox.Image = (Bitmap)eventArgs.Frame.Clone();
                    }));
                }
                else
                {
                    if (pictureBox.Image != null)
                    {
                        pictureBox.Image.Dispose();
                    }
                    pictureBox.Image = (Bitmap)eventArgs.Frame.Clone();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in CaptureDevice_NewFrame: " + ex.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox.Image != null)
            {
                BarcodeReader reader = new BarcodeReader();
                Result result = reader.Decode((Bitmap)pictureBox.Image);

                if (result != null)
                {
                    txtQRCode.Invoke(new MethodInvoker(delegate
                    {
                        txtQRCode.Text = result.Text;
                    }));
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CaptureDevice != null && CaptureDevice.IsRunning)
            {
                CaptureDevice.SignalToStop();
                CaptureDevice.WaitForStop();
            }
        }

        // Unused methods (Kept as per user request)
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {

        }
    }
}
