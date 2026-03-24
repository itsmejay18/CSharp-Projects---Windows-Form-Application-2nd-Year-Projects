namespace CrudUsingMethods
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Names = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quality = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Color = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Name_TXT = new System.Windows.Forms.TextBox();
            this.Price_TXT = new System.Windows.Forms.TextBox();
            this.Quantity_TXT = new System.Windows.Forms.TextBox();
            this.Quality_TXT = new System.Windows.Forms.TextBox();
            this.Color_TXT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Insert_BTN = new System.Windows.Forms.Button();
            this.Update_BTN = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Id_TXT = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Names,
            this.Price,
            this.Quantity,
            this.Quality,
            this.Color});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Right;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(271, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(608, 499);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // Id
            // 
            this.Id.Text = "Id";
            this.Id.Width = 100;
            // 
            // Names
            // 
            this.Names.Text = "Names";
            this.Names.Width = 100;
            // 
            // Price
            // 
            this.Price.Text = "Price";
            this.Price.Width = 100;
            // 
            // Quantity
            // 
            this.Quantity.Text = "Quantity";
            this.Quantity.Width = 100;
            // 
            // Quality
            // 
            this.Quality.Text = "Quality";
            this.Quality.Width = 100;
            // 
            // Color
            // 
            this.Color.Text = "Color";
            this.Color.Width = 100;
            // 
            // Name_TXT
            // 
            this.Name_TXT.Location = new System.Drawing.Point(110, 52);
            this.Name_TXT.Name = "Name_TXT";
            this.Name_TXT.Size = new System.Drawing.Size(123, 20);
            this.Name_TXT.TabIndex = 1;
            // 
            // Price_TXT
            // 
            this.Price_TXT.Location = new System.Drawing.Point(110, 88);
            this.Price_TXT.Name = "Price_TXT";
            this.Price_TXT.Size = new System.Drawing.Size(123, 20);
            this.Price_TXT.TabIndex = 2;
            // 
            // Quantity_TXT
            // 
            this.Quantity_TXT.Location = new System.Drawing.Point(110, 124);
            this.Quantity_TXT.Name = "Quantity_TXT";
            this.Quantity_TXT.Size = new System.Drawing.Size(123, 20);
            this.Quantity_TXT.TabIndex = 3;
            // 
            // Quality_TXT
            // 
            this.Quality_TXT.Location = new System.Drawing.Point(110, 160);
            this.Quality_TXT.Name = "Quality_TXT";
            this.Quality_TXT.Size = new System.Drawing.Size(123, 20);
            this.Quality_TXT.TabIndex = 4;
            // 
            // Color_TXT
            // 
            this.Color_TXT.Location = new System.Drawing.Point(110, 195);
            this.Color_TXT.Name = "Color_TXT";
            this.Color_TXT.Size = new System.Drawing.Size(123, 20);
            this.Color_TXT.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Names";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Quality";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Color";
            // 
            // Insert_BTN
            // 
            this.Insert_BTN.Location = new System.Drawing.Point(27, 256);
            this.Insert_BTN.Name = "Insert_BTN";
            this.Insert_BTN.Size = new System.Drawing.Size(75, 23);
            this.Insert_BTN.TabIndex = 11;
            this.Insert_BTN.Text = "Insert";
            this.Insert_BTN.UseVisualStyleBackColor = true;
            this.Insert_BTN.Click += new System.EventHandler(this.Insert_BTN_Click);
            // 
            // Update_BTN
            // 
            this.Update_BTN.Location = new System.Drawing.Point(158, 256);
            this.Update_BTN.Name = "Update_BTN";
            this.Update_BTN.Size = new System.Drawing.Size(75, 23);
            this.Update_BTN.TabIndex = 12;
            this.Update_BTN.Text = "Update";
            this.Update_BTN.UseVisualStyleBackColor = true;
            this.Update_BTN.Click += new System.EventHandler(this.Update_BTN_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(27, 307);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Id_TXT
            // 
            this.Id_TXT.Location = new System.Drawing.Point(110, 12);
            this.Id_TXT.Name = "Id_TXT";
            this.Id_TXT.Size = new System.Drawing.Size(123, 20);
            this.Id_TXT.TabIndex = 14;
            this.Id_TXT.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 499);
            this.Controls.Add(this.Id_TXT);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Update_BTN);
            this.Controls.Add(this.Insert_BTN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Color_TXT);
            this.Controls.Add(this.Quality_TXT);
            this.Controls.Add(this.Quantity_TXT);
            this.Controls.Add(this.Price_TXT);
            this.Controls.Add(this.Name_TXT);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Names;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader Quantity;
        private System.Windows.Forms.ColumnHeader Quality;
        private System.Windows.Forms.ColumnHeader Color;
        private System.Windows.Forms.TextBox Name_TXT;
        private System.Windows.Forms.TextBox Price_TXT;
        private System.Windows.Forms.TextBox Quantity_TXT;
        private System.Windows.Forms.TextBox Quality_TXT;
        private System.Windows.Forms.TextBox Color_TXT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Insert_BTN;
        private System.Windows.Forms.Button Update_BTN;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox Id_TXT;
    }
}

