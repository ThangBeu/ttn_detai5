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
            this.tableMain = new System.Windows.Forms.DataGridView();
            this.tableMain1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonThemPhong = new System.Windows.Forms.Button();
            this.buttonXoaPhong = new System.Windows.Forms.Button();
            this.buttonThemVD = new System.Windows.Forms.Button();
            this.buttonXoaVD = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSearchPhong = new System.Windows.Forms.Button();
            this.txtSearchPhong = new System.Windows.Forms.TextBox();
            this.buttonSearchVD = new System.Windows.Forms.Button();
            this.textBoxSearchVD = new System.Windows.Forms.TextBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tableMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableMain1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableMain
            // 
            this.tableMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableMain.Location = new System.Drawing.Point(13, 58);
            this.tableMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableMain.Name = "tableMain";
            this.tableMain.RowHeadersWidth = 51;
            this.tableMain.RowTemplate.Height = 24;
            this.tableMain.Size = new System.Drawing.Size(747, 199);
            this.tableMain.TabIndex = 0;
            this.tableMain.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableMain_CellClick);
            this.tableMain.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableMain_CellClick);
            // 
            // tableMain1
            // 
            this.tableMain1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableMain1.Location = new System.Drawing.Point(12, 327);
            this.tableMain1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableMain1.Name = "tableMain1";
            this.tableMain1.RowHeadersWidth = 51;
            this.tableMain1.RowTemplate.Height = 24;
            this.tableMain1.Size = new System.Drawing.Size(748, 222);
            this.tableMain1.TabIndex = 1;
            this.tableMain1.Visible = false;
            this.tableMain1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableMain1_CellClick);
            this.tableMain1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableMain1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Thông Tin Phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Vật Dụng Trong Phòng";
            // 
            // buttonThemPhong
            // 
            this.buttonThemPhong.AutoEllipsis = true;
            this.buttonThemPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonThemPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThemPhong.Location = new System.Drawing.Point(803, 69);
            this.buttonThemPhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonThemPhong.Name = "buttonThemPhong";
            this.buttonThemPhong.Size = new System.Drawing.Size(153, 56);
            this.buttonThemPhong.TabIndex = 4;
            this.buttonThemPhong.Text = "Thêm Phòng";
            this.buttonThemPhong.UseVisualStyleBackColor = false;
            this.buttonThemPhong.Click += new System.EventHandler(this.buttonThemPhong_Click);
            // 
            // buttonXoaPhong
            // 
            this.buttonXoaPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonXoaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXoaPhong.Location = new System.Drawing.Point(803, 157);
            this.buttonXoaPhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonXoaPhong.Name = "buttonXoaPhong";
            this.buttonXoaPhong.Size = new System.Drawing.Size(153, 56);
            this.buttonXoaPhong.TabIndex = 6;
            this.buttonXoaPhong.Text = "Xóa Phòng";
            this.buttonXoaPhong.UseVisualStyleBackColor = false;
            this.buttonXoaPhong.Click += new System.EventHandler(this.btnXoaPhong_Click);
            // 
            // buttonThemVD
            // 
            this.buttonThemVD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonThemVD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThemVD.Location = new System.Drawing.Point(803, 370);
            this.buttonThemVD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonThemVD.Name = "buttonThemVD";
            this.buttonThemVD.Size = new System.Drawing.Size(153, 56);
            this.buttonThemVD.TabIndex = 7;
            this.buttonThemVD.Text = "Thêm Đồ Dùng";
            this.buttonThemVD.UseVisualStyleBackColor = false;
            this.buttonThemVD.Click += new System.EventHandler(this.buttonThemVD_Click);
            // 
            // buttonXoaVD
            // 
            this.buttonXoaVD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonXoaVD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXoaVD.Location = new System.Drawing.Point(803, 459);
            this.buttonXoaVD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonXoaVD.Name = "buttonXoaVD";
            this.buttonXoaVD.Size = new System.Drawing.Size(153, 56);
            this.buttonXoaVD.TabIndex = 8;
            this.buttonXoaVD.Text = "Xóa Đồ Dùng";
            this.buttonXoaVD.UseVisualStyleBackColor = false;
            this.buttonXoaVD.Click += new System.EventHandler(this.btnXoaVD_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 351);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 14;
            // 
            // btnSearchPhong
            // 
            this.btnSearchPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSearchPhong.Location = new System.Drawing.Point(559, 10);
            this.btnSearchPhong.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchPhong.Name = "btnSearchPhong";
            this.btnSearchPhong.Size = new System.Drawing.Size(201, 37);
            this.btnSearchPhong.TabIndex = 78;
            this.btnSearchPhong.Text = "Search";
            this.btnSearchPhong.UseVisualStyleBackColor = true;
            this.btnSearchPhong.Click += new System.EventHandler(this.btnSearchPhong_Click);
            // 
            // txtSearchPhong
            // 
            this.txtSearchPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSearchPhong.Location = new System.Drawing.Point(259, 15);
            this.txtSearchPhong.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchPhong.Name = "txtSearchPhong";
            this.txtSearchPhong.Size = new System.Drawing.Size(292, 27);
            this.txtSearchPhong.TabIndex = 77;
            this.txtSearchPhong.TextChanged += new System.EventHandler(this.txtSearchPhong_TextChanged);
            // 
            // buttonSearchVD
            // 
            this.buttonSearchVD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonSearchVD.Location = new System.Drawing.Point(558, 279);
            this.buttonSearchVD.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSearchVD.Name = "buttonSearchVD";
            this.buttonSearchVD.Size = new System.Drawing.Size(202, 37);
            this.buttonSearchVD.TabIndex = 80;
            this.buttonSearchVD.Text = "Search";
            this.buttonSearchVD.UseVisualStyleBackColor = true;
            // 
            // textBoxSearchVD
            // 
            this.textBoxSearchVD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxSearchVD.Location = new System.Drawing.Point(258, 284);
            this.textBoxSearchVD.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSearchVD.Name = "textBoxSearchVD";
            this.textBoxSearchVD.Size = new System.Drawing.Size(292, 27);
            this.textBoxSearchVD.TabIndex = 79;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefresh.Location = new System.Drawing.Point(803, 242);
            this.buttonRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(153, 56);
            this.buttonRefresh.TabIndex = 81;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // FormPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 585);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonSearchVD);
            this.Controls.Add(this.textBoxSearchVD);
            this.Controls.Add(this.btnSearchPhong);
            this.Controls.Add(this.txtSearchPhong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonXoaVD);
            this.Controls.Add(this.buttonThemVD);
            this.Controls.Add(this.buttonXoaPhong);
            this.Controls.Add(this.buttonThemPhong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableMain1);
            this.Controls.Add(this.tableMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormPhong";
            this.Text = "FormPhong";
            ((System.ComponentModel.ISupportInitialize)(this.tableMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableMain1)).EndInit();
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSearchPhong;
        private System.Windows.Forms.TextBox txtSearchPhong;
        private System.Windows.Forms.Button buttonSearchVD;
        private System.Windows.Forms.TextBox textBoxSearchVD;
        private System.Windows.Forms.Button buttonRefresh;
    }
}