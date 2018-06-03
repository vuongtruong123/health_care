namespace LoiKhuyenAnUong
{
    partial class FormLoiKhuyen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLoiKhuyen));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxCheDo = new System.Windows.Forms.ComboBox();
            this.cbxNgheNghiep = new System.Windows.Forms.ComboBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.lbLoiKhuyen = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "LỜI KHUYÊN ĂN UỐNG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(40, 123);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chọn chế độ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(40, 186);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nghề nghiệp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(209, 295);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Lời khuyên";
            this.label4.UseMnemonic = false;
            // 
            // cbxCheDo
            // 
            this.cbxCheDo.BackColor = System.Drawing.Color.SkyBlue;
            this.cbxCheDo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCheDo.FormattingEnabled = true;
            this.cbxCheDo.Items.AddRange(new object[] {
            "Ăn kiêng",
            "Tăng cân"});
            this.cbxCheDo.Location = new System.Drawing.Point(214, 120);
            this.cbxCheDo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxCheDo.Name = "cbxCheDo";
            this.cbxCheDo.Size = new System.Drawing.Size(211, 28);
            this.cbxCheDo.TabIndex = 5;
            this.cbxCheDo.SelectedIndexChanged += new System.EventHandler(this.cbxCheDo_SelectedIndexChanged);
            // 
            // cbxNgheNghiep
            // 
            this.cbxNgheNghiep.BackColor = System.Drawing.Color.SkyBlue;
            this.cbxNgheNghiep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNgheNghiep.FormattingEnabled = true;
            this.cbxNgheNghiep.Items.AddRange(new object[] {
            "Nhân viên văn phòng",
            "Lao động nhẹ",
            "Lao động nặng"});
            this.cbxNgheNghiep.Location = new System.Drawing.Point(214, 178);
            this.cbxNgheNghiep.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxNgheNghiep.Name = "cbxNgheNghiep";
            this.cbxNgheNghiep.Size = new System.Drawing.Size(211, 28);
            this.cbxNgheNghiep.TabIndex = 6;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.Red;
            this.btnOK.Location = new System.Drawing.Point(214, 237);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(112, 35);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lbLoiKhuyen
            // 
            this.lbLoiKhuyen.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lbLoiKhuyen.Location = new System.Drawing.Point(13, 342);
            this.lbLoiKhuyen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLoiKhuyen.Name = "lbLoiKhuyen";
            this.lbLoiKhuyen.Size = new System.Drawing.Size(530, 306);
            this.lbLoiKhuyen.TabIndex = 8;
            this.lbLoiKhuyen.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(392, 662);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(112, 35);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FormLoiKhuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(557, 797);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lbLoiKhuyen);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cbxNgheNghiep);
            this.Controls.Add(this.cbxCheDo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormLoiKhuyen";
            this.Text = "Lời Khuyên Ăn Uống";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxCheDo;
        private System.Windows.Forms.ComboBox cbxNgheNghiep;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lbLoiKhuyen;
        private System.Windows.Forms.Button btnClose;
    }
}

