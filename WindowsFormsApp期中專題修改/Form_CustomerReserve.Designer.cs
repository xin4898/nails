namespace WindowsFormsApp期中專題修改
{
    partial class Form_CustomerBooking
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
            this.txtboxName = new System.Windows.Forms.TextBox();
            this.txtboxPhone = new System.Windows.Forms.TextBox();
            this.CalendarDate = new System.Windows.Forms.MonthCalendar();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn10 = new System.Windows.Forms.Button();
            this.btn11 = new System.Windows.Forms.Button();
            this.btn15 = new System.Windows.Forms.Button();
            this.btn16 = new System.Windows.Forms.Button();
            this.btn18 = new System.Windows.Forms.Button();
            this.btn19 = new System.Windows.Forms.Button();
            this.btn20 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn14 = new System.Windows.Forms.Button();
            this.dgvReserveInfo = new System.Windows.Forms.DataGridView();
            this.lblID = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReserveInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtboxName
            // 
            this.txtboxName.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtboxName.Location = new System.Drawing.Point(223, 35);
            this.txtboxName.Name = "txtboxName";
            this.txtboxName.Size = new System.Drawing.Size(161, 39);
            this.txtboxName.TabIndex = 21;
            // 
            // txtboxPhone
            // 
            this.txtboxPhone.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtboxPhone.Location = new System.Drawing.Point(608, 35);
            this.txtboxPhone.Name = "txtboxPhone";
            this.txtboxPhone.Size = new System.Drawing.Size(161, 39);
            this.txtboxPhone.TabIndex = 23;
            // 
            // CalendarDate
            // 
            this.CalendarDate.BackColor = System.Drawing.Color.LightYellow;
            this.CalendarDate.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CalendarDate.Location = new System.Drawing.Point(94, 107);
            this.CalendarDate.MaxSelectionCount = 365;
            this.CalendarDate.Name = "CalendarDate";
            this.CalendarDate.SelectionRange = new System.Windows.Forms.SelectionRange(new System.DateTime(2022, 5, 1, 0, 0, 0, 0), new System.DateTime(2023, 4, 26, 0, 0, 0, 0));
            this.CalendarDate.TabIndex = 25;
            this.CalendarDate.TitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.CalendarDate.TitleForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CalendarDate.TrailingForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn9.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn9.FlatAppearance.BorderSize = 0;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn9.ForeColor = System.Drawing.Color.Black;
            this.btn9.Location = new System.Drawing.Point(0, 0);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(520, 35);
            this.btn9.TabIndex = 0;
            this.btn9.Text = "09:00";
            this.btn9.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn10
            // 
            this.btn10.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn10.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn10.FlatAppearance.BorderSize = 0;
            this.btn10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn10.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn10.ForeColor = System.Drawing.Color.Black;
            this.btn10.Location = new System.Drawing.Point(0, 35);
            this.btn10.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btn10.Name = "btn10";
            this.btn10.Size = new System.Drawing.Size(520, 35);
            this.btn10.TabIndex = 1;
            this.btn10.Text = "10:00";
            this.btn10.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btn10.UseVisualStyleBackColor = false;
            this.btn10.Click += new System.EventHandler(this.btn10_Click);
            // 
            // btn11
            // 
            this.btn11.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn11.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn11.FlatAppearance.BorderSize = 0;
            this.btn11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn11.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn11.ForeColor = System.Drawing.Color.Black;
            this.btn11.Location = new System.Drawing.Point(0, 70);
            this.btn11.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btn11.Name = "btn11";
            this.btn11.Size = new System.Drawing.Size(520, 35);
            this.btn11.TabIndex = 2;
            this.btn11.Text = "11:00";
            this.btn11.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btn11.UseVisualStyleBackColor = false;
            this.btn11.Click += new System.EventHandler(this.btn11_Click);
            // 
            // btn15
            // 
            this.btn15.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn15.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn15.FlatAppearance.BorderSize = 0;
            this.btn15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn15.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn15.ForeColor = System.Drawing.Color.Black;
            this.btn15.Location = new System.Drawing.Point(0, 140);
            this.btn15.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btn15.Name = "btn15";
            this.btn15.Size = new System.Drawing.Size(520, 35);
            this.btn15.TabIndex = 4;
            this.btn15.Text = "15:00";
            this.btn15.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btn15.UseVisualStyleBackColor = false;
            this.btn15.Click += new System.EventHandler(this.btn15_Click);
            // 
            // btn16
            // 
            this.btn16.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn16.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn16.FlatAppearance.BorderSize = 0;
            this.btn16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn16.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn16.ForeColor = System.Drawing.Color.Black;
            this.btn16.Location = new System.Drawing.Point(0, 175);
            this.btn16.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btn16.Name = "btn16";
            this.btn16.Size = new System.Drawing.Size(520, 35);
            this.btn16.TabIndex = 5;
            this.btn16.Text = "16:00";
            this.btn16.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btn16.UseVisualStyleBackColor = false;
            this.btn16.Click += new System.EventHandler(this.btn16_Click);
            // 
            // btn18
            // 
            this.btn18.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn18.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn18.FlatAppearance.BorderSize = 0;
            this.btn18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn18.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn18.ForeColor = System.Drawing.Color.Black;
            this.btn18.Location = new System.Drawing.Point(0, 210);
            this.btn18.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btn18.Name = "btn18";
            this.btn18.Size = new System.Drawing.Size(520, 35);
            this.btn18.TabIndex = 6;
            this.btn18.Text = "18:00";
            this.btn18.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btn18.UseVisualStyleBackColor = false;
            this.btn18.Click += new System.EventHandler(this.btn18_Click);
            // 
            // btn19
            // 
            this.btn19.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn19.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn19.FlatAppearance.BorderSize = 0;
            this.btn19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn19.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn19.ForeColor = System.Drawing.Color.Black;
            this.btn19.Location = new System.Drawing.Point(0, 245);
            this.btn19.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btn19.Name = "btn19";
            this.btn19.Size = new System.Drawing.Size(520, 35);
            this.btn19.TabIndex = 7;
            this.btn19.Text = "19:00";
            this.btn19.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btn19.UseVisualStyleBackColor = false;
            this.btn19.Click += new System.EventHandler(this.btn19_Click);
            // 
            // btn20
            // 
            this.btn20.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn20.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn20.FlatAppearance.BorderSize = 0;
            this.btn20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn20.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn20.ForeColor = System.Drawing.Color.Black;
            this.btn20.Location = new System.Drawing.Point(0, 280);
            this.btn20.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btn20.Name = "btn20";
            this.btn20.Size = new System.Drawing.Size(520, 35);
            this.btn20.TabIndex = 8;
            this.btn20.Text = "20:00";
            this.btn20.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btn20.UseVisualStyleBackColor = false;
            this.btn20.Click += new System.EventHandler(this.btn20_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn20);
            this.panel1.Controls.Add(this.btn19);
            this.panel1.Controls.Add(this.btn18);
            this.panel1.Controls.Add(this.btn16);
            this.panel1.Controls.Add(this.btn15);
            this.panel1.Controls.Add(this.btn14);
            this.panel1.Controls.Add(this.btn11);
            this.panel1.Controls.Add(this.btn10);
            this.panel1.Controls.Add(this.btn9);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(355, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(520, 317);
            this.panel1.TabIndex = 26;
            // 
            // btn14
            // 
            this.btn14.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn14.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn14.FlatAppearance.BorderSize = 0;
            this.btn14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn14.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn14.ForeColor = System.Drawing.Color.Black;
            this.btn14.Location = new System.Drawing.Point(0, 105);
            this.btn14.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btn14.Name = "btn14";
            this.btn14.Size = new System.Drawing.Size(520, 35);
            this.btn14.TabIndex = 3;
            this.btn14.Text = "14:00";
            this.btn14.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btn14.UseVisualStyleBackColor = false;
            this.btn14.Click += new System.EventHandler(this.btn14_Click);
            // 
            // dgvReserveInfo
            // 
            this.dgvReserveInfo.BackgroundColor = System.Drawing.Color.LightGoldenrodYellow;
            this.dgvReserveInfo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微軟正黑體", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReserveInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReserveInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微軟正黑體", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReserveInfo.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReserveInfo.Location = new System.Drawing.Point(355, 430);
            this.dgvReserveInfo.Name = "dgvReserveInfo";
            this.dgvReserveInfo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvReserveInfo.RowTemplate.Height = 24;
            this.dgvReserveInfo.Size = new System.Drawing.Size(520, 169);
            this.dgvReserveInfo.TabIndex = 27;
            this.dgvReserveInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReserveInfo_CellClick);
            this.dgvReserveInfo.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReserveInfo_CellContentDoubleClick);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblID.Location = new System.Drawing.Point(1012, -2);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(27, 21);
            this.lblID.TabIndex = 32;
            this.lblID.Text = "ID";
            this.lblID.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp期中專題修改.Properties.Resources.images;
            this.pictureBox1.Location = new System.Drawing.Point(33, 403);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(258, 196);
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Image = global::WindowsFormsApp期中專題修改.Properties.Resources.icons8_phone_50;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label1.Location = new System.Drawing.Point(297, 430);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 169);
            this.label1.TabIndex = 34;
            this.label1.Text = "預約列表";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.btnDelete.TabIndex = 33;
            this.btnDelete.Text = "預約刪除";
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
            this.btnUpdate.TabIndex = 31;
            this.btnUpdate.Text = "預約修改";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAdd.Image = global::WindowsFormsApp期中專題修改.Properties.Resources.icons8_calendar_48;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.Location = new System.Drawing.Point(805, 30);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(187, 49);
            this.btnAdd.TabIndex = 30;
            this.btnAdd.Text = "加入預約";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.btnReload.TabIndex = 29;
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
            this.btnSearch.TabIndex = 28;
            this.btnSearch.Text = "預約搜尋";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Image = global::WindowsFormsApp期中專題修改.Properties.Resources.icons8_phone_50;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(414, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 49);
            this.label5.TabIndex = 22;
            this.label5.Text = "預約人電話";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Image = global::WindowsFormsApp期中專題修改.Properties.Resources.icons8_trollface_48;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(30, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 49);
            this.label4.TabIndex = 20;
            this.label4.Text = "預約人姓名";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Image = global::WindowsFormsApp期中專題修改.Properties.Resources.icons8_phone_50;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label3.Location = new System.Drawing.Point(30, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 169);
            this.label3.TabIndex = 18;
            this.label3.Text = "預約時段";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form_CustomerBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(1041, 611);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvReserveInfo);
            this.Controls.Add(this.CalendarDate);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtboxPhone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtboxName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "Form_CustomerBooking";
            this.Text = "CustmerBooking";
            this.Load += new System.EventHandler(this.Form_CustomerBooking_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReserveInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtboxName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtboxPhone;
        private System.Windows.Forms.MonthCalendar CalendarDate;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn10;
        private System.Windows.Forms.Button btn11;
        private System.Windows.Forms.Button btn15;
        private System.Windows.Forms.Button btn16;
        private System.Windows.Forms.Button btn18;
        private System.Windows.Forms.Button btn19;
        private System.Windows.Forms.Button btn20;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn14;
        private System.Windows.Forms.DataGridView dgvReserveInfo;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}