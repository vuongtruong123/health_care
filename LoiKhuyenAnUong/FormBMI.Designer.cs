namespace LoiKhuyenAnUong
{
    partial class FormBMI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBMI));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCanNang = new System.Windows.Forms.TextBox();
            this.txtChieuCao = new System.Windows.Forms.TextBox();
            this.btnTinh = new System.Windows.Forms.Button();
            this.lbChiSo = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnLoiKhuyenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(74, 86);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cân nặng (kg)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(72, 154);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chiều cao (cm)";
            // 
            // txtCanNang
            // 
            this.txtCanNang.Location = new System.Drawing.Point(255, 74);
            this.txtCanNang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCanNang.MaxLength = 3;
            this.txtCanNang.Name = "txtCanNang";
            this.txtCanNang.Size = new System.Drawing.Size(148, 26);
            this.txtCanNang.TabIndex = 2;
            this.txtCanNang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCanNang_KeyPress);
            // 
            // txtChieuCao
            // 
            this.txtChieuCao.Location = new System.Drawing.Point(255, 154);
            this.txtChieuCao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtChieuCao.MaxLength = 3;
            this.txtChieuCao.Name = "txtChieuCao";
            this.txtChieuCao.Size = new System.Drawing.Size(148, 26);
            this.txtChieuCao.TabIndex = 3;
            this.txtChieuCao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtChieuCao_KeyPress);
            // 
            // btnTinh
            // 
            this.btnTinh.BackColor = System.Drawing.Color.Crimson;
            this.btnTinh.Location = new System.Drawing.Point(523, 107);
            this.btnTinh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(112, 35);
            this.btnTinh.TabIndex = 4;
            this.btnTinh.Text = "Tính";
            this.btnTinh.UseVisualStyleBackColor = false;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // lbChiSo
            // 
            this.lbChiSo.AutoSize = true;
            this.lbChiSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChiSo.Location = new System.Drawing.Point(74, 248);
            this.lbChiSo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbChiSo.Name = "lbChiSo";
            this.lbChiSo.Size = new System.Drawing.Size(0, 29);
            this.lbChiSo.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLoiKhuyenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(663, 35);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnLoiKhuyenToolStripMenuItem
            // 
            this.btnLoiKhuyenToolStripMenuItem.Name = "btnLoiKhuyenToolStripMenuItem";
            this.btnLoiKhuyenToolStripMenuItem.Size = new System.Drawing.Size(110, 29);
            this.btnLoiKhuyenToolStripMenuItem.Text = "Lời Khuyên";
            this.btnLoiKhuyenToolStripMenuItem.Click += new System.EventHandler(this.btnLoiKhuyenToolStripMenuItem_Click);
            // 
            // FormBMI
            // 
            this.AcceptButton = this.btnTinh;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(663, 481);
            this.Controls.Add(this.lbChiSo);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.txtChieuCao);
            this.Controls.Add(this.txtCanNang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormBMI";
            this.Text = "Tính BMI";
            this.Load += new System.EventHandler(this.FormBMI_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCanNang;
        private System.Windows.Forms.TextBox txtChieuCao;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.Label lbChiSo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnLoiKhuyenToolStripMenuItem;
    }
}