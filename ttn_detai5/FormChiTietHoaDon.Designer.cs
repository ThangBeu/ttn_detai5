namespace ttn_detai5
{
    partial class FormChiTietHoaDon
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
            this.lblMaHD = new System.Windows.Forms.Label();
            this.dataGridViewPhong = new System.Windows.Forms.DataGridView();
            this.dataGridViewDichVu = new System.Windows.Forms.DataGridView();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDichVu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(289, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hóa đơn : ";
            // 
            // lblMaHD
            // 
            this.lblMaHD.AutoSize = true;
            this.lblMaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHD.Location = new System.Drawing.Point(442, 34);
            this.lblMaHD.Name = "lblMaHD";
            this.lblMaHD.Size = new System.Drawing.Size(35, 24);
            this.lblMaHD.TabIndex = 1;
            this.lblMaHD.Text = ". . .";
            // 
            // dataGridViewPhong
            // 
            this.dataGridViewPhong.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPhong.Location = new System.Drawing.Point(26, 97);
            this.dataGridViewPhong.Name = "dataGridViewPhong";
            this.dataGridViewPhong.Size = new System.Drawing.Size(746, 103);
            this.dataGridViewPhong.TabIndex = 2;
            // 
            // dataGridViewDichVu
            // 
            this.dataGridViewDichVu.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDichVu.Location = new System.Drawing.Point(27, 265);
            this.dataGridViewDichVu.Name = "dataGridViewDichVu";
            this.dataGridViewDichVu.Size = new System.Drawing.Size(745, 100);
            this.dataGridViewDichVu.TabIndex = 3;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(329, 389);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(130, 35);
            this.btnThoat.TabIndex = 86;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 24);
            this.label2.TabIndex = 87;
            this.label2.Text = "Chi Tiết Hóa Đơn Phòng :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 24);
            this.label3.TabIndex = 88;
            this.label3.Text = "Chi Tiết Hóa Đơn Dịch Vụ :";
            // 
            // FormChiTietHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.dataGridViewDichVu);
            this.Controls.Add(this.dataGridViewPhong);
            this.Controls.Add(this.lblMaHD);
            this.Controls.Add(this.label1);
            this.Name = "FormChiTietHoaDon";
            this.Text = "FormChiTietHoaDon";
            this.Load += new System.EventHandler(this.FormChiTietHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDichVu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMaHD;
        private System.Windows.Forms.DataGridView dataGridViewPhong;
        private System.Windows.Forms.DataGridView dataGridViewDichVu;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}