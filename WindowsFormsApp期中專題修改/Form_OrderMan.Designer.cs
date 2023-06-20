namespace WindowsFormsApp期中專題修改
{
    partial class Form_OrderMan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvOrderInfo = new System.Windows.Forms.DataGridView();
            this.lblID = new System.Windows.Forms.Label();
            this.txtboxPhone = new System.Windows.Forms.TextBox();
            this.txtboxName = new System.Windows.Forms.TextBox();
            this.CalendarDate = new System.Windows.Forms.MonthCalendar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl顧客電話 = new System.Windows.Forms.Label();
            this.lbl顧客姓名 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOrderInfo
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微軟正黑體", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrderInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOrderInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微軟正黑體", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrderInfo.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOrderInfo.Location = new System.Drawing.Point(263, 94);
            this.dgvOrderInfo.Name = "dgvOrderInfo";
            this.dgvOrderInfo.RowTemplate.Height = 24;
            this.dgvOrderInfo.Size = new System.Drawing.Size(622, 505);
            this.dgvOrderInfo.TabIndex = 0;
            this.dgvOrderInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderInfo_CellContentClick);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblID.Location = new System.Drawing.Point(15, 9);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(23, 16);
            this.lblID.TabIndex = 38;
            this.lblID.Text = "ID";
            this.lblID.Visible = false;
            // 
            // txtboxPhone
            // 
            this.txtboxPhone.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtboxPhone.Location = new System.Drawing.Point(608, 35);
            this.txtboxPhone.Name = "txtboxPhone";
            this.txtboxPhone.Size = new System.Drawing.Size(223, 39);
            this.txtboxPhone.TabIndex = 43;
            // 
            // txtboxName
            // 
            this.txtboxName.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtboxName.Location = new System.Drawing.Point(223, 35);
            this.txtboxName.Name = "txtboxName";
            this.txtboxName.Size = new System.Drawing.Size(161, 39);
            this.txtboxName.TabIndex = 42;
            // 
            // CalendarDate
            // 
            this.CalendarDate.BackColor = System.Drawing.Color.LightYellow;
            this.CalendarDate.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CalendarDate.Location = new System.Drawing.Point(8, 152);
            this.CalendarDate.Name = "CalendarDate";
            this.CalendarDate.TabIndex = 47;
            this.CalendarDate.TitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.CalendarDate.TitleForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CalendarDate.TrailingForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp期中專題修改.Properties.Resources.images__3_;
            this.pictureBox1.Location = new System.Drawing.Point(8, 418);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(249, 181);
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // lbl顧客電話
            // 
            this.lbl顧客電話.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl顧客電話.Image = global::WindowsFormsApp期中專題修改.Properties.Resources.icons8_phone_50;
            this.lbl顧客電話.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl顧客電話.Location = new System.Drawing.Point(442, 30);
            this.lbl顧客電話.Name = "lbl顧客電話";
            this.lbl顧客電話.Size = new System.Drawing.Size(159, 49);
            this.lbl顧客電話.TabIndex = 41;
            this.lbl顧客電話.Text = "顧客電話";
            this.lbl顧客電話.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl顧客姓名
            // 
            this.lbl顧客姓名.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl顧客姓名.Image = global::WindowsFormsApp期中專題修改.Properties.Resources.icons8_trollface_48;
            this.lbl顧客姓名.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl顧客姓名.Location = new System.Drawing.Point(59, 30);
            this.lbl顧客姓名.Name = "lbl顧客姓名";
            this.lbl顧客姓名.Size = new System.Drawing.Size(158, 49);
            this.lbl顧客姓名.TabIndex = 40;
            this.lbl顧客姓名.Text = "顧客姓名";
            this.lbl顧客姓名.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Image = global::WindowsFormsApp期中專題修改.Properties.Resources.icons8_calendar1_48;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(59, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 49);
            this.label3.TabIndex = 39;
            this.label3.Text = "選取日期";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDelete.Image = global::WindowsFormsApp期中專題修改.Properties.Resources.icons8_delete_64;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDelete.Location = new System.Drawing.Point(895, 488);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(134, 111);
            this.btnDelete.TabIndex = 37;
            this.btnDelete.Text = "紀錄刪除";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnUpdate.Image = global::WindowsFormsApp期中專題修改.Properties.Resources.icons8_task_64;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUpdate.Location = new System.Drawing.Point(895, 355);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(134, 111);
            this.btnUpdate.TabIndex = 36;
            this.btnUpdate.Text = "紀錄修改";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnReload
            // 
            this.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReload.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReload.Image = global::WindowsFormsApp期中專題修改.Properties.Resources.icons8_available_updates_64;
            this.btnReload.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReload.Location = new System.Drawing.Point(895, 226);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(134, 111);
            this.btnReload.TabIndex = 35;
            this.btnReload.Text = "表單重整";
            this.btnReload.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSearch.Image = global::WindowsFormsApp期中專題修改.Properties.Resources.icons8_search_64;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSearch.Location = new System.Drawing.Point(895, 94);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(134, 111);
            this.btnSearch.TabIndex = 34;
            this.btnSearch.Text = "紀錄搜尋";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Form_OrderMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(1041, 611);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CalendarDate);
            this.Controls.Add(this.txtboxPhone);
            this.Controls.Add(this.txtboxName);
            this.Controls.Add(this.lbl顧客電話);
            this.Controls.Add(this.lbl顧客姓名);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvOrderInfo);
            this.Name = "Form_OrderMan";
            this.Text = "Form_OrderMan";
            this.Load += new System.EventHandler(this.Form_OrderMan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOrderInfo;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lbl顧客電話;
        private System.Windows.Forms.Label lbl顧客姓名;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtboxPhone;
        private System.Windows.Forms.TextBox txtboxName;
        private System.Windows.Forms.MonthCalendar CalendarDate;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}