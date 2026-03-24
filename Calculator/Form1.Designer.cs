namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.numbers_txt = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numbers_lbl = new System.Windows.Forms.TextBox();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_divide = new System.Windows.Forms.Button();
            this.btn_multiple = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_minus = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_plus = new System.Windows.Forms.Button();
            this.btn_equals = new System.Windows.Forms.Button();
            this.btn_0 = new System.Windows.Forms.Button();
            this.btn_positve_negative = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // numbers_txt
            // 
            this.numbers_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numbers_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numbers_txt.Location = new System.Drawing.Point(13, 3);
            this.numbers_txt.Name = "numbers_txt";
            this.numbers_txt.Size = new System.Drawing.Size(316, 31);
            this.numbers_txt.TabIndex = 0;
            this.numbers_txt.Text = "0";
            this.numbers_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.numbers_lbl);
            this.panel1.Controls.Add(this.numbers_txt);
            this.panel1.Location = new System.Drawing.Point(25, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 67);
            this.panel1.TabIndex = 1;
            // 
            // numbers_lbl
            // 
            this.numbers_lbl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numbers_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numbers_lbl.ForeColor = System.Drawing.Color.Gray;
            this.numbers_lbl.Location = new System.Drawing.Point(3, 38);
            this.numbers_lbl.Name = "numbers_lbl";
            this.numbers_lbl.Size = new System.Drawing.Size(316, 22);
            this.numbers_lbl.TabIndex = 1;
            this.numbers_lbl.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_7
            // 
            this.btn_7.BackColor = System.Drawing.Color.White;
            this.btn_7.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_7.Location = new System.Drawing.Point(31, 165);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(77, 50);
            this.btn_7.TabIndex = 3;
            this.btn_7.Text = "7";
            this.btn_7.UseVisualStyleBackColor = false;
            this.btn_7.Click += new System.EventHandler(this.numbers_Clicked);
            // 
            // btn_8
            // 
            this.btn_8.BackColor = System.Drawing.Color.White;
            this.btn_8.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_8.Location = new System.Drawing.Point(114, 165);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(77, 50);
            this.btn_8.TabIndex = 4;
            this.btn_8.Text = "8";
            this.btn_8.UseVisualStyleBackColor = false;
            this.btn_8.Click += new System.EventHandler(this.numbers_Clicked);
            // 
            // btn_9
            // 
            this.btn_9.BackColor = System.Drawing.Color.White;
            this.btn_9.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_9.Location = new System.Drawing.Point(197, 165);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(77, 50);
            this.btn_9.TabIndex = 5;
            this.btn_9.Text = "9";
            this.btn_9.UseVisualStyleBackColor = false;
            this.btn_9.Click += new System.EventHandler(this.numbers_Clicked);
            // 
            // btn_divide
            // 
            this.btn_divide.BackColor = System.Drawing.Color.White;
            this.btn_divide.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_divide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_divide.Location = new System.Drawing.Point(280, 165);
            this.btn_divide.Name = "btn_divide";
            this.btn_divide.Size = new System.Drawing.Size(77, 50);
            this.btn_divide.TabIndex = 6;
            this.btn_divide.Text = "/";
            this.btn_divide.UseVisualStyleBackColor = false;
            this.btn_divide.Click += new System.EventHandler(this.operators_Clicked);
            // 
            // btn_multiple
            // 
            this.btn_multiple.BackColor = System.Drawing.Color.White;
            this.btn_multiple.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_multiple.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_multiple.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_multiple.Location = new System.Drawing.Point(280, 221);
            this.btn_multiple.Name = "btn_multiple";
            this.btn_multiple.Size = new System.Drawing.Size(77, 50);
            this.btn_multiple.TabIndex = 10;
            this.btn_multiple.Text = "x";
            this.btn_multiple.UseVisualStyleBackColor = false;
            this.btn_multiple.Click += new System.EventHandler(this.operators_Clicked);
            // 
            // btn_6
            // 
            this.btn_6.BackColor = System.Drawing.Color.White;
            this.btn_6.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_6.Location = new System.Drawing.Point(197, 221);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(77, 50);
            this.btn_6.TabIndex = 9;
            this.btn_6.Text = "6";
            this.btn_6.UseVisualStyleBackColor = false;
            this.btn_6.Click += new System.EventHandler(this.numbers_Clicked);
            // 
            // btn_5
            // 
            this.btn_5.BackColor = System.Drawing.Color.White;
            this.btn_5.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_5.Location = new System.Drawing.Point(114, 221);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(77, 50);
            this.btn_5.TabIndex = 8;
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = false;
            this.btn_5.Click += new System.EventHandler(this.numbers_Clicked);
            // 
            // btn_4
            // 
            this.btn_4.BackColor = System.Drawing.Color.White;
            this.btn_4.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_4.Location = new System.Drawing.Point(31, 221);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(77, 50);
            this.btn_4.TabIndex = 7;
            this.btn_4.Text = "4";
            this.btn_4.UseVisualStyleBackColor = false;
            this.btn_4.Click += new System.EventHandler(this.numbers_Clicked);
            // 
            // btn_minus
            // 
            this.btn_minus.BackColor = System.Drawing.Color.White;
            this.btn_minus.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_minus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_minus.Location = new System.Drawing.Point(280, 277);
            this.btn_minus.Name = "btn_minus";
            this.btn_minus.Size = new System.Drawing.Size(77, 50);
            this.btn_minus.TabIndex = 14;
            this.btn_minus.Text = "-";
            this.btn_minus.UseVisualStyleBackColor = false;
            this.btn_minus.Click += new System.EventHandler(this.operators_Clicked);
            // 
            // btn_3
            // 
            this.btn_3.BackColor = System.Drawing.Color.White;
            this.btn_3.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_3.Location = new System.Drawing.Point(197, 277);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(77, 50);
            this.btn_3.TabIndex = 13;
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = false;
            this.btn_3.Click += new System.EventHandler(this.numbers_Clicked);
            // 
            // btn_2
            // 
            this.btn_2.BackColor = System.Drawing.Color.White;
            this.btn_2.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_2.Location = new System.Drawing.Point(114, 277);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(77, 50);
            this.btn_2.TabIndex = 12;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = false;
            this.btn_2.Click += new System.EventHandler(this.numbers_Clicked);
            // 
            // btn_1
            // 
            this.btn_1.BackColor = System.Drawing.Color.White;
            this.btn_1.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_1.Location = new System.Drawing.Point(31, 277);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(77, 50);
            this.btn_1.TabIndex = 11;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = false;
            this.btn_1.Click += new System.EventHandler(this.numbers_Clicked);
            // 
            // btn_plus
            // 
            this.btn_plus.BackColor = System.Drawing.Color.White;
            this.btn_plus.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_plus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_plus.Location = new System.Drawing.Point(280, 333);
            this.btn_plus.Name = "btn_plus";
            this.btn_plus.Size = new System.Drawing.Size(77, 50);
            this.btn_plus.TabIndex = 18;
            this.btn_plus.Text = "+";
            this.btn_plus.UseVisualStyleBackColor = false;
            this.btn_plus.Click += new System.EventHandler(this.operators_Clicked);
            // 
            // btn_equals
            // 
            this.btn_equals.BackColor = System.Drawing.Color.White;
            this.btn_equals.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_equals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_equals.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_equals.Location = new System.Drawing.Point(197, 333);
            this.btn_equals.Name = "btn_equals";
            this.btn_equals.Size = new System.Drawing.Size(77, 50);
            this.btn_equals.TabIndex = 17;
            this.btn_equals.Text = "=";
            this.btn_equals.UseVisualStyleBackColor = false;
            this.btn_equals.Click += new System.EventHandler(this.operators_Clicked);
            // 
            // btn_0
            // 
            this.btn_0.BackColor = System.Drawing.Color.White;
            this.btn_0.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_0.Location = new System.Drawing.Point(114, 333);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(77, 50);
            this.btn_0.TabIndex = 16;
            this.btn_0.Text = "0";
            this.btn_0.UseVisualStyleBackColor = false;
            this.btn_0.Click += new System.EventHandler(this.numbers_Clicked);
            // 
            // btn_positve_negative
            // 
            this.btn_positve_negative.BackColor = System.Drawing.Color.White;
            this.btn_positve_negative.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_positve_negative.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_positve_negative.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_positve_negative.Location = new System.Drawing.Point(31, 333);
            this.btn_positve_negative.Name = "btn_positve_negative";
            this.btn_positve_negative.Size = new System.Drawing.Size(77, 50);
            this.btn_positve_negative.TabIndex = 15;
            this.btn_positve_negative.Text = "AC";
            this.btn_positve_negative.UseVisualStyleBackColor = false;
            this.btn_positve_negative.Click += new System.EventHandler(this.operators_Clicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(386, 405);
            this.Controls.Add(this.btn_plus);
            this.Controls.Add(this.btn_equals);
            this.Controls.Add(this.btn_0);
            this.Controls.Add(this.btn_positve_negative);
            this.Controls.Add(this.btn_minus);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.btn_multiple);
            this.Controls.Add(this.btn_6);
            this.Controls.Add(this.btn_5);
            this.Controls.Add(this.btn_4);
            this.Controls.Add(this.btn_divide);
            this.Controls.Add(this.btn_9);
            this.Controls.Add(this.btn_8);
            this.Controls.Add(this.btn_7);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.Click += new System.EventHandler(this.operators_Clicked);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox numbers_txt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_divide;
        private System.Windows.Forms.Button btn_multiple;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_minus;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_plus;
        private System.Windows.Forms.Button btn_equals;
        private System.Windows.Forms.Button btn_0;
        private System.Windows.Forms.Button btn_positve_negative;
        private System.Windows.Forms.TextBox numbers_lbl;
    }
}

