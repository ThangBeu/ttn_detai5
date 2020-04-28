namespace ttn_detai5
{
    partial class FormThemDoDung
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.numericUpDownSL = new System.Windows.Forms.NumericUpDown();
            this.comboBoxMaPhong = new System.Windows.Forms.ComboBox();
            this.comboBoxTenDD = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSL)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(157, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên Đò Dùng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(157, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số lượng";
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(186)))), ((int)(((byte)(151)))));
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(336, 327);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(137, 50);
            this.btnThem.TabIndex = 125;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // numericUpDownSL
            // 
            this.numericUpDownSL.Location = new System.Drawing.Point(351, 245);
            this.numericUpDownSL.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownSL.Name = "numericUpDownSL";
            this.numericUpDownSL.Size = new System.Drawing.Size(123, 22);
            this.numericUpDownSL.TabIndex = 127;
            this.numericUpDownSL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericUpDownSL_KeyPress);
            // 
            // comboBoxMaPhong
            // 
            this.comboBoxMaPhong.FormattingEnabled = true;
            this.comboBoxMaPhong.Location = new System.Drawing.Point(351, 97);
            this.comboBoxMaPhong.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxMaPhong.Name = "comboBoxMaPhong";
            this.comboBoxMaPhong.Size = new System.Drawing.Size(303, 24);
            this.comboBoxMaPhong.TabIndex = 128;
            // 
            // comboBoxTenDD
            // 
            this.comboBoxTenDD.FormattingEnabled = true;
            this.comboBoxTenDD.Location = new System.Drawing.Point(351, 165);
            this.comboBoxTenDD.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxTenDD.Name = "comboBoxTenDD";
            this.comboBoxTenDD.Size = new System.Drawing.Size(303, 24);
            this.comboBoxTenDD.TabIndex = 129;
            // 
            // FormThemDoDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxTenDD);
            this.Controls.Add(this.comboBoxMaPhong);
            this.Controls.Add(this.numericUpDownSL);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormThemDoDung";
            this.Text = "FormThemDoDung";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.NumericUpDown numericUpDownSL;
        private System.Windows.Forms.ComboBox comboBoxMaPhong;
        private System.Windows.Forms.ComboBox comboBoxTenDD;
    }
}