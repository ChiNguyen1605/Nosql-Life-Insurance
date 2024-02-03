namespace QL_KhachHangBaoHiem.GUI
{
    partial class TTChiTietHopDong
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNguoiMua = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNguoiHuongBH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTongPhiSP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPhiDinhKy = new System.Windows.Forms.TextBox();
            this.dg_SPMua = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dg_SPMua)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Người Mua";
            // 
            // txtNguoiMua
            // 
            this.txtNguoiMua.Location = new System.Drawing.Point(271, 17);
            this.txtNguoiMua.Name = "txtNguoiMua";
            this.txtNguoiMua.Size = new System.Drawing.Size(346, 30);
            this.txtNguoiMua.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Người Hưởng Bảo Hiểm";
            // 
            // txtNguoiHuongBH
            // 
            this.txtNguoiHuongBH.Location = new System.Drawing.Point(271, 70);
            this.txtNguoiHuongBH.Name = "txtNguoiHuongBH";
            this.txtNguoiHuongBH.Size = new System.Drawing.Size(346, 30);
            this.txtNguoiHuongBH.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 122);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tổng Phí Sản Phẩm";
            // 
            // txtTongPhiSP
            // 
            this.txtTongPhiSP.Location = new System.Drawing.Point(271, 122);
            this.txtTongPhiSP.Name = "txtTongPhiSP";
            this.txtTongPhiSP.Size = new System.Drawing.Size(346, 30);
            this.txtTongPhiSP.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(123, 177);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Phí Định Kỳ";
            // 
            // txtPhiDinhKy
            // 
            this.txtPhiDinhKy.Location = new System.Drawing.Point(271, 177);
            this.txtPhiDinhKy.Name = "txtPhiDinhKy";
            this.txtPhiDinhKy.Size = new System.Drawing.Size(346, 30);
            this.txtPhiDinhKy.TabIndex = 1;
            // 
            // dg_SPMua
            // 
            this.dg_SPMua.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_SPMua.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dg_SPMua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_SPMua.Location = new System.Drawing.Point(13, 270);
            this.dg_SPMua.Name = "dg_SPMua";
            this.dg_SPMua.RowHeadersWidth = 51;
            this.dg_SPMua.RowTemplate.Height = 24;
            this.dg_SPMua.Size = new System.Drawing.Size(665, 175);
            this.dg_SPMua.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Sản Phẩm Mua";
            // 
            // TTChiTietHopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 465);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dg_SPMua);
            this.Controls.Add(this.txtPhiDinhKy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTongPhiSP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNguoiHuongBH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNguoiMua);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TTChiTietHopDong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TTChiTietHopDong";
            this.Load += new System.EventHandler(this.TTChiTietHopDong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_SPMua)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNguoiMua;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNguoiHuongBH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTongPhiSP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPhiDinhKy;
        private System.Windows.Forms.DataGridView dg_SPMua;
        private System.Windows.Forms.Label label5;
    }
}