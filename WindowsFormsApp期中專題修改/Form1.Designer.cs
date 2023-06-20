namespace WindowsFormsApp期中專題修改
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.label_Forms = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnOrderMan = new System.Windows.Forms.Button();
            this.btnReserve = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.labelUserInfo = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.labelUserInfo);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(202, 130);
            this.panel2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.panel1.Controls.Add(this.btnOrders);
            this.panel1.Controls.Add(this.btnOrderMan);
            this.panel1.Controls.Add(this.btnReserve);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.ForeColor = System.Drawing.Color.LemonChiffon;
            this.panel1.Location = new System.Drawing.Point(0, 130);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(202, 620);
            this.panel1.TabIndex = 0;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.panelMain.Controls.Add(this.panel3);
            this.panelMain.Location = new System.Drawing.Point(202, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1057, 750);
            this.panelMain.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnLogout);
            this.panel3.Controls.Add(this.label_Forms);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1057, 100);
            this.panel3.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnLogout.Image = global::WindowsFormsApp期中專題修改.Properties.Resources.icons8_logout_64;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogout.Location = new System.Drawing.Point(873, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(131, 67);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "登出";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // label_Forms
            // 
            this.label_Forms.Font = new System.Drawing.Font("微軟正黑體", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Forms.Image = global::WindowsFormsApp期中專題修改.Properties.Resources.icons8_task_64;
            this.label_Forms.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_Forms.Location = new System.Drawing.Point(302, 9);
            this.label_Forms.Name = "label_Forms";
            this.label_Forms.Size = new System.Drawing.Size(322, 78);
            this.label_Forms.TabIndex = 1;
            this.label_Forms.Text = "目前表單";
            this.label_Forms.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Image = global::WindowsFormsApp期中專題修改.Properties.Resources.icons8_nail_64__2_;
            this.label1.Location = new System.Drawing.Point(50, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 78);
            this.label1.TabIndex = 1;
            // 
            // btnOrders
            // 
            this.btnOrders.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnOrders.FlatAppearance.BorderSize = 0;
            this.btnOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrders.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnOrders.ForeColor = System.Drawing.Color.LemonChiffon;
            this.btnOrders.Image = global::WindowsFormsApp期中專題修改.Properties.Resources.icons8_nail_64__1_;
            this.btnOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOrders.Location = new System.Drawing.Point(0, 200);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(202, 100);
            this.btnOrders.TabIndex = 2;
            this.btnOrders.Text = "   美甲服務";
            this.btnOrders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrders.UseVisualStyleBackColor = false;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // btnOrderMan
            // 
            this.btnOrderMan.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnOrderMan.FlatAppearance.BorderSize = 0;
            this.btnOrderMan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderMan.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnOrderMan.ForeColor = System.Drawing.Color.LemonChiffon;
            this.btnOrderMan.Image = global::WindowsFormsApp期中專題修改.Properties.Resources.icons8_search_60;
            this.btnOrderMan.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOrderMan.Location = new System.Drawing.Point(0, 300);
            this.btnOrderMan.Name = "btnOrderMan";
            this.btnOrderMan.Size = new System.Drawing.Size(202, 100);
            this.btnOrderMan.TabIndex = 3;
            this.btnOrderMan.Text = "   訂單管理";
            this.btnOrderMan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrderMan.UseVisualStyleBackColor = false;
            this.btnOrderMan.Click += new System.EventHandler(this.btnOrderMan_Click);
            // 
            // btnReserve
            // 
            this.btnReserve.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnReserve.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReserve.FlatAppearance.BorderSize = 0;
            this.btnReserve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReserve.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReserve.ForeColor = System.Drawing.Color.LemonChiffon;
            this.btnReserve.Image = global::WindowsFormsApp期中專題修改.Properties.Resources.icons8_nail_64;
            this.btnReserve.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReserve.Location = new System.Drawing.Point(0, 100);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(202, 100);
            this.btnReserve.TabIndex = 1;
            this.btnReserve.Text = "   預約美甲";
            this.btnReserve.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReserve.UseVisualStyleBackColor = false;
            this.btnReserve.Click += new System.EventHandler(this.btnReserve_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnLogin.ForeColor = System.Drawing.Color.LemonChiffon;
            this.btnLogin.Image = global::WindowsFormsApp期中專題修改.Properties.Resources.icons8_login_64;
            this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogin.Location = new System.Drawing.Point(0, 0);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(202, 100);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "   Log In";
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // labelUserInfo
            // 
            this.labelUserInfo.AutoSize = true;
            this.labelUserInfo.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelUserInfo.Location = new System.Drawing.Point(46, 87);
            this.labelUserInfo.Name = "labelUserInfo";
            this.labelUserInfo.Size = new System.Drawing.Size(122, 31);
            this.labelUserInfo.TabIndex = 0;
            this.labelUserInfo.Text = "歡迎使用!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(1259, 750);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnOrderMan;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnReserve;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Label label_Forms;
        public System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelUserInfo;
    }
}

