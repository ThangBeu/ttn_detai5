namespace ttn_detai5
{
    partial class FormPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPhong));
            this.tableMain = new System.Windows.Forms.DataGridView();
            this.tableMain1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonThemPhong = new System.Windows.Forms.Button();
            this.buttonXoaPhong = new System.Windows.Forms.Button();
            this.buttonThemVD = new System.Windows.Forms.Button();
            this.buttonXoaVD = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSearchPhong = new System.Windows.Forms.Button();
            this.txtSearchPhong = new System.Windows.Forms.TextBox();
            this.buttonSearchVD = new System.Windows.Forms.Button();
            this.textBoxSearchVD = new System.Windows.Forms.TextBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tableMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableMain1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // tableMain
            // 
            this.tableMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableMain.Location = new System.Drawing.Point(10, 47);
            this.tableMain.Margin = new System.Windows.Forms.Padding(2);
            this.tableMain.Name = "tableMain";
            this.tableMain.RowHeadersWidth = 51;
            this.tableMain.RowTemplate.Height = 24;
            this.tableMain.Size = new System.Drawing.Size(541, 162);
            this.tableMain.TabIndex = 0;
            this.tableMain.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableMain_CellClick);
            this.tableMain.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableMain_CellClick);
            // 
            // tableMain1
            // 
            this.tableMain1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableMain1.Location = new System.Drawing.Point(9, 266);
            this.tableMain1.Margin = new System.Windows.Forms.Padding(2);
            this.tableMain1.Name = "tableMain1";
            this.tableMain1.RowHeadersWidth = 51;
            this.tableMain1.RowTemplate.Height = 24;
            this.tableMain1.Size = new System.Drawing.Size(542, 180);
            this.tableMain1.TabIndex = 1;
            this.tableMain1.Visible = false;
            this.tableMain1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableMain1_CellClick);
            this.tableMain1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableMain1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 236);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Vật Dụng Trong Phòng";
            // 
            // buttonThemPhong
            // 
            this.buttonThemPhong.AutoEllipsis = true;
            this.buttonThemPhong.Location = new System.Drawing.Point(626, 57);
            this.buttonThemPhong.Margin = new System.Windows.Forms.Padding(2);
            this.buttonThemPhong.Name = "buttonThemPhong";
            this.buttonThemPhong.Size = new System.Drawing.Size(76, 31);
            this.buttonThemPhong.TabIndex = 4;
            this.buttonThemPhong.Text = "Thêm Phòng";
            this.buttonThemPhong.UseVisualStyleBackColor = true;
            this.buttonThemPhong.Click += new System.EventHandler(this.buttonThemPhong_Click);
            // 
            // buttonXoaPhong
            // 
            this.buttonXoaPhong.Location = new System.Drawing.Point(626, 109);
            this.buttonXoaPhong.Margin = new System.Windows.Forms.Padding(2);
            this.buttonXoaPhong.Name = "buttonXoaPhong";
            this.buttonXoaPhong.Size = new System.Drawing.Size(76, 32);
            this.buttonXoaPhong.TabIndex = 6;
            this.buttonXoaPhong.Text = "Xóa";
            this.buttonXoaPhong.UseVisualStyleBackColor = true;
            this.buttonXoaPhong.Click += new System.EventHandler(this.btnXoaPhong_Click);
            // 
            // buttonThemVD
            // 
            this.buttonThemVD.Location = new System.Drawing.Point(626, 285);
            this.buttonThemVD.Margin = new System.Windows.Forms.Padding(2);
            this.buttonThemVD.Name = "buttonThemVD";
            this.buttonThemVD.Size = new System.Drawing.Size(76, 43);
            this.buttonThemVD.TabIndex = 7;
            this.buttonThemVD.Text = "Thêm Vật Dụng";
            this.buttonThemVD.UseVisualStyleBackColor = true;
            this.buttonThemVD.Click += new System.EventHandler(this.buttonThemVD_Click);
            // 
            // buttonXoaVD
            // 
            this.buttonXoaVD.Location = new System.Drawing.Point(626, 343);
            this.buttonXoaVD.Margin = new System.Windows.Forms.Padding(2);
            this.buttonXoaVD.Name = "buttonXoaVD";
            this.buttonXoaVD.Size = new System.Drawing.Size(76, 43);
            this.buttonXoaVD.TabIndex = 8;
            this.buttonXoaVD.Text = "Xóa";
            this.buttonXoaVD.UseVisualStyleBackColor = true;
            this.buttonXoaVD.Click += new System.EventHandler(this.btnXoaVD_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(580, 57);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.ErrorImage")));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(580, 109);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(42, 31);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.InitialImage = null;
            this.pictureBox4.Location = new System.Drawing.Point(571, 285);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(42, 43);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.InitialImage")));
            this.pictureBox5.Location = new System.Drawing.Point(571, 343);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(42, 43);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 13;
            this.pictureBox5.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 285);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 14;
            // 
            // btnSearchPhong
            // 
            this.btnSearchPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSearchPhong.Location = new System.Drawing.Point(390, 8);
            this.btnSearchPhong.Name = "btnSearchPhong";
            this.btnSearchPhong.Size = new System.Drawing.Size(132, 30);
            this.btnSearchPhong.TabIndex = 78;
            this.btnSearchPhong.Text = "Search";
            this.btnSearchPhong.UseVisualStyleBackColor = true;
            this.btnSearchPhong.Click += new System.EventHandler(this.btnSearchPhong_Click);
            // 
            // txtSearchPhong
            // 
            this.txtSearchPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSearchPhong.Location = new System.Drawing.Point(165, 12);
            this.txtSearchPhong.Name = "txtSearchPhong";
            this.txtSearchPhong.Size = new System.Drawing.Size(220, 23);
            this.txtSearchPhong.TabIndex = 77;
            this.txtSearchPhong.TextChanged += new System.EventHandler(this.txtSearchPhong_TextChanged);
            // 
            // buttonSearchVD
            // 
            this.buttonSearchVD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonSearchVD.Location = new System.Drawing.Point(390, 227);
            this.buttonSearchVD.Name = "buttonSearchVD";
            this.buttonSearchVD.Size = new System.Drawing.Size(132, 30);
            this.buttonSearchVD.TabIndex = 80;
            this.buttonSearchVD.Text = "Search";
            this.buttonSearchVD.UseVisualStyleBackColor = true;
            // 
            // textBoxSearchVD
            // 
            this.textBoxSearchVD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxSearchVD.Location = new System.Drawing.Point(165, 231);
            this.textBoxSearchVD.Name = "textBoxSearchVD";
            this.textBoxSearchVD.Size = new System.Drawing.Size(220, 23);
            this.textBoxSearchVD.TabIndex = 79;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(626, 157);
            this.buttonRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(76, 32);
            this.buttonRefresh.TabIndex = 81;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // FormPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 475);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonSearchVD);
            this.Controls.Add(this.textBoxSearchVD);
            this.Controls.Add(this.btnSearchPhong);
            this.Controls.Add(this.txtSearchPhong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonXoaVD);
            this.Controls.Add(this.buttonThemVD);
            this.Controls.Add(this.buttonXoaPhong);
            this.Controls.Add(this.buttonThemPhong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableMain1);
            this.Controls.Add(this.tableMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormPhong";
            this.Text = "FormPhong";
            ((System.ComponentModel.ISupportInitialize)(this.tableMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableMain1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tableMain;
        private System.Windows.Forms.DataGridView tableMain1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonThemPhong;
        private System.Windows.Forms.Button buttonXoaPhong;
        private System.Windows.Forms.Button buttonThemVD;
        private System.Windows.Forms.Button buttonXoaVD;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSearchPhong;
        private System.Windows.Forms.TextBox txtSearchPhong;
        private System.Windows.Forms.Button buttonSearchVD;
        private System.Windows.Forms.TextBox textBoxSearchVD;
        private System.Windows.Forms.Button buttonRefresh;
    }
}