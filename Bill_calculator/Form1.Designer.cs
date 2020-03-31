namespace Bill_calculator
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
            this.no_label = new System.Windows.Forms.Label();
            this.name_label = new System.Windows.Forms.Label();
            this.tf_label = new System.Windows.Forms.Label();
            this.units_label = new System.Windows.Forms.Label();
            this.c_no = new System.Windows.Forms.TextBox();
            this.c_name = new System.Windows.Forms.TextBox();
            this.c_type = new System.Windows.Forms.TextBox();
            this.units = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.view_panel = new System.Windows.Forms.ListBox();
            this.Date = new System.Windows.Forms.Label();
            this.c_amount = new System.Windows.Forms.Button();
            this.Total_earnings = new System.Windows.Forms.Button();
            this.list_clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // no_label
            // 
            this.no_label.AutoSize = true;
            this.no_label.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no_label.Location = new System.Drawing.Point(25, 201);
            this.no_label.Name = "no_label";
            this.no_label.Size = new System.Drawing.Size(115, 23);
            this.no_label.TabIndex = 0;
            this.no_label.Text = "Customer No";
            this.no_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.name_label.Location = new System.Drawing.Point(25, 260);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(139, 23);
            this.name_label.TabIndex = 1;
            this.name_label.Text = "Customer Name";
            this.name_label.Click += new System.EventHandler(this.label2_Click);
            // 
            // tf_label
            // 
            this.tf_label.AutoSize = true;
            this.tf_label.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.tf_label.Location = new System.Drawing.Point(25, 323);
            this.tf_label.Name = "tf_label";
            this.tf_label.Size = new System.Drawing.Size(100, 23);
            this.tf_label.TabIndex = 2;
            this.tf_label.Text = "Tariff Code";
            this.tf_label.Click += new System.EventHandler(this.label3_Click);
            // 
            // units_label
            // 
            this.units_label.AutoSize = true;
            this.units_label.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.units_label.Location = new System.Drawing.Point(25, 388);
            this.units_label.Name = "units_label";
            this.units_label.Size = new System.Drawing.Size(144, 23);
            this.units_label.TabIndex = 3;
            this.units_label.Text = "Number of Units";
            // 
            // c_no
            // 
            this.c_no.Location = new System.Drawing.Point(221, 201);
            this.c_no.Name = "c_no";
            this.c_no.Size = new System.Drawing.Size(155, 22);
            this.c_no.TabIndex = 4;
            this.c_no.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.c_no_KeyPress);
            // 
            // c_name
            // 
            this.c_name.Location = new System.Drawing.Point(221, 260);
            this.c_name.MaxLength = 100;
            this.c_name.Name = "c_name";
            this.c_name.Size = new System.Drawing.Size(155, 22);
            this.c_name.TabIndex = 5;
            this.c_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.c_name_KeyPress);
            // 
            // c_type
            // 
            this.c_type.Location = new System.Drawing.Point(221, 325);
            this.c_type.MaxLength = 1;
            this.c_type.Name = "c_type";
            this.c_type.Size = new System.Drawing.Size(155, 22);
            this.c_type.TabIndex = 6;
            this.c_type.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.c_type_KeyPress);
            // 
            // units
            // 
            this.units.Location = new System.Drawing.Point(221, 388);
            this.units.Name = "units";
            this.units.Size = new System.Drawing.Size(155, 22);
            this.units.TabIndex = 7;
            this.units.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.units_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(342, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(474, 68);
            this.label5.TabIndex = 12;
            this.label5.Text = "E-bill Calculator ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(29, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(966, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(117, 116);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(404, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(252, 27);
            this.label6.TabIndex = 15;
            this.label6.Text = "Ceylon Electricity Board";
            // 
            // view_panel
            // 
            this.view_panel.FormattingEnabled = true;
            this.view_panel.ItemHeight = 16;
            this.view_panel.Location = new System.Drawing.Point(630, 184);
            this.view_panel.Name = "view_panel";
            this.view_panel.Size = new System.Drawing.Size(499, 276);
            this.view_panel.TabIndex = 16;
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.Location = new System.Drawing.Point(837, 158);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(0, 23);
            this.Date.TabIndex = 18;
            this.Date.Click += new System.EventHandler(this.Date_Click);
            // 
            // c_amount
            // 
            this.c_amount.BackColor = System.Drawing.Color.Maroon;
            this.c_amount.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c_amount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.c_amount.Location = new System.Drawing.Point(429, 216);
            this.c_amount.Name = "c_amount";
            this.c_amount.Size = new System.Drawing.Size(152, 66);
            this.c_amount.TabIndex = 19;
            this.c_amount.Text = "Amount Payable";
            this.c_amount.UseVisualStyleBackColor = false;
            this.c_amount.Click += new System.EventHandler(this.c_amount_Click_1);
            // 
            // Total_earnings
            // 
            this.Total_earnings.BackColor = System.Drawing.Color.Maroon;
            this.Total_earnings.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.Total_earnings.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Total_earnings.Location = new System.Drawing.Point(429, 339);
            this.Total_earnings.Name = "Total_earnings";
            this.Total_earnings.Size = new System.Drawing.Size(152, 62);
            this.Total_earnings.TabIndex = 20;
            this.Total_earnings.Text = "Total Earnings";
            this.Total_earnings.UseVisualStyleBackColor = false;
            this.Total_earnings.Click += new System.EventHandler(this.Total_earnings_Click);
            // 
            // list_clear
            // 
            this.list_clear.BackColor = System.Drawing.Color.Maroon;
            this.list_clear.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.list_clear.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.list_clear.Location = new System.Drawing.Point(1004, 466);
            this.list_clear.Name = "list_clear";
            this.list_clear.Size = new System.Drawing.Size(125, 44);
            this.list_clear.TabIndex = 21;
            this.list_clear.Text = "Clear";
            this.list_clear.UseVisualStyleBackColor = false;
            this.list_clear.Click += new System.EventHandler(this.list_clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1189, 539);
            this.Controls.Add(this.list_clear);
            this.Controls.Add(this.Total_earnings);
            this.Controls.Add(this.c_amount);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.view_panel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.units);
            this.Controls.Add(this.c_type);
            this.Controls.Add(this.c_name);
            this.Controls.Add(this.c_no);
            this.Controls.Add(this.units_label);
            this.Controls.Add(this.tf_label);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.no_label);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "CEB-Monthly Bill Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label no_label;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label tf_label;
        private System.Windows.Forms.Label units_label;
        private System.Windows.Forms.TextBox c_no;
        private System.Windows.Forms.TextBox c_name;
        private System.Windows.Forms.TextBox c_type;
        private System.Windows.Forms.TextBox units;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox view_panel;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Button c_amount;
        private System.Windows.Forms.Button Total_earnings;
        private System.Windows.Forms.Button list_clear;
    }
}

