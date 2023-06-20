namespace WindowsFormsApp期中專題修改
{
    partial class Form_Products
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
            this.comboClean = new System.Windows.Forms.ComboBox();
            this.comboNail = new System.Windows.Forms.ComboBox();
            this.comboAccOne = new System.Windows.Forms.ComboBox();
            this.lblCleanPrice = new System.Windows.Forms.Label();
            this.lblNailPrice = new System.Windows.Forms.Label();
            this.lblAccOnePrice = new System.Windows.Forms.Label();
            this.btnComfirm = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.numud數量 = new System.Windows.Forms.NumericUpDown();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.comboAccTwo = new System.Windows.Forms.ComboBox();
            this.numud數量1 = new System.Windows.Forms.NumericUpDown();
            this.comboAccThree = new System.Windows.Forms.ComboBox();
            this.numud數量2 = new System.Windows.Forms.NumericUpDown();
            this.lblAccTwoPrice = new System.Windows.Forms.Label();
            this.lblAccThreePrice = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl顧客電話 = new System.Windows.Forms.Label();
            this.lbl顧客姓名 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numud數量)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numud數量1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numud數量2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboClean
            // 
            this.comboClean.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboClean.FormattingEnabled = true;
            this.comboClean.Location = new System.Drawing.Point(223, 115);
            this.comboClean.Name = "comboClean";
            this.comboClean.Size = new System.Drawing.Size(194, 39);
            this.comboClean.TabIndex = 0;
            this.comboClean.Text = "無卸甲";
            this.comboClean.SelectedIndexChanged += new System.EventHandler(this.combo卸甲_SelectedIndexChanged);
            // 
            // comboNail
            // 
            this.comboNail.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboNail.FormattingEnabled = true;
            this.comboNail.Location = new System.Drawing.Point(223, 185);
            this.comboNail.Name = "comboNail";
            this.comboNail.Size = new System.Drawing.Size(194, 39);
            this.comboNail.TabIndex = 1;
            this.comboNail.Text = "無光療美甲";
            this.comboNail.SelectedIndexChanged += new System.EventHandler(this.combo凝膠_SelectedIndexChanged);
            // 
            // comboAccOne
            // 
            this.comboAccOne.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboAccOne.FormattingEnabled = true;
            this.comboAccOne.Location = new System.Drawing.Point(223, 255);
            this.comboAccOne.Name = "comboAccOne";
            this.comboAccOne.Size = new System.Drawing.Size(194, 39);
            this.comboAccOne.TabIndex = 2;
            this.comboAccOne.SelectedIndexChanged += new System.EventHandler(this.combo飾品_SelectedIndexChanged);
            // 
            // lblCleanPrice
            // 
            this.lblCleanPrice.AutoSize = true;
            this.lblCleanPrice.BackColor = System.Drawing.Color.LemonChiffon;
            this.lblCleanPrice.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblCleanPrice.Location = new System.Drawing.Point(545, 120);
            this.lblCleanPrice.Name = "lblCleanPrice";
            this.lblCleanPrice.Size = new System.Drawing.Size(76, 31);
            this.lblCleanPrice.TabIndex = 4;
            this.lblCleanPrice.Text = "NT$0";
            // 
            // lblNailPrice
            // 
            this.lblNailPrice.AutoSize = true;
            this.lblNailPrice.BackColor = System.Drawing.Color.LemonChiffon;
            this.lblNailPrice.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblNailPrice.Location = new System.Drawing.Point(545, 190);
            this.lblNailPrice.Name = "lblNailPrice";
            this.lblNailPrice.Size = new System.Drawing.Size(76, 31);
            this.lblNailPrice.TabIndex = 5;
            this.lblNailPrice.Text = "NT$0";
            // 
            // lblAccOnePrice
            // 
            this.lblAccOnePrice.AutoSize = true;
            this.lblAccOnePrice.BackColor = System.Drawing.Color.LemonChiffon;
            this.lblAccOnePrice.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblAccOnePrice.Location = new System.Drawing.Point(650, 260);
            this.lblAccOnePrice.Name = "lblAccOnePrice";
            this.lblAccOnePrice.Size = new System.Drawing.Size(76, 31);
            this.lblAccOnePrice.TabIndex = 6;
            this.lblAccOnePrice.Text = "NT$0";
            // 
            // btnComfirm
            // 
            this.btnComfirm.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnComfirm.Location = new System.Drawing.Point(768, 533);
            this.btnComfirm.Name = "btnComfirm";
            this.btnComfirm.Size = new System.Drawing.Size(198, 43);
            this.btnComfirm.TabIndex = 7;
            this.btnComfirm.Text = "訂單確認";
            this.btnComfirm.UseVisualStyleBackColor = true;
            this.btnComfirm.Click += new System.EventHandler(this.btnComfirm_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.LemonChiffon;
            this.lblTotal.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTotal.Location = new System.Drawing.Point(217, 510);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(76, 31);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.Text = "NT$0";
            // 
            // numud數量
            // 
            this.numud數量.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.numud數量.Location = new System.Drawing.Point(443, 255);
            this.numud數量.Name = "numud數量";
            this.numud數量.Size = new System.Drawing.Size(75, 39);
            this.numud數量.TabIndex = 10;
            this.numud數量.ValueChanged += new System.EventHandler(this.numud數量_ValueChanged);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtName.Location = new System.Drawing.Point(223, 35);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(161, 39);
            this.txtName.TabIndex = 11;
            this.txtName.Text = "顧客姓名";
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt顧客姓名_MouseClick);
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPhone.Location = new System.Drawing.Point(608, 35);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(223, 39);
            this.txtPhone.TabIndex = 12;
            this.txtPhone.Text = "顧客電話";
            this.txtPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPhone.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt顧客電話_MouseClick);
            // 
            // comboAccTwo
            // 
            this.comboAccTwo.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboAccTwo.FormattingEnabled = true;
            this.comboAccTwo.Location = new System.Drawing.Point(223, 325);
            this.comboAccTwo.Name = "comboAccTwo";
            this.comboAccTwo.Size = new System.Drawing.Size(194, 39);
            this.comboAccTwo.TabIndex = 13;
            this.comboAccTwo.SelectedIndexChanged += new System.EventHandler(this.combo飾品1_SelectedIndexChanged);
            // 
            // numud數量1
            // 
            this.numud數量1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.numud數量1.Location = new System.Drawing.Point(443, 325);
            this.numud數量1.Name = "numud數量1";
            this.numud數量1.Size = new System.Drawing.Size(75, 39);
            this.numud數量1.TabIndex = 14;
            this.numud數量1.ValueChanged += new System.EventHandler(this.numud數量1_ValueChanged);
            // 
            // comboAccThree
            // 
            this.comboAccThree.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboAccThree.FormattingEnabled = true;
            this.comboAccThree.Location = new System.Drawing.Point(223, 395);
            this.comboAccThree.Name = "comboAccThree";
            this.comboAccThree.Size = new System.Drawing.Size(194, 39);
            this.comboAccThree.TabIndex = 15;
            this.comboAccThree.SelectedIndexChanged += new System.EventHandler(this.combo飾品2_SelectedIndexChanged);
            // 
            // numud數量2
            // 
            this.numud數量2.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.numud數量2.Location = new System.Drawing.Point(443, 395);
            this.numud數量2.Name = "numud數量2";
            this.numud數量2.Size = new System.Drawing.Size(75, 39);
            this.numud數量2.TabIndex = 16;
            this.numud數量2.ValueChanged += new System.EventHandler(this.numud數量2_ValueChanged);
            // 
            // lblAccTwoPrice
            // 
            this.lblAccTwoPrice.AutoSize = true;
            this.lblAccTwoPrice.BackColor = System.Drawing.Color.LemonChiffon;
            this.lblAccTwoPrice.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblAccTwoPrice.Location = new System.Drawing.Point(650, 330);
            this.lblAccTwoPrice.Name = "lblAccTwoPrice";
            this.lblAccTwoPrice.Size = new System.Drawing.Size(76, 31);
            this.lblAccTwoPrice.TabIndex = 17;
            this.lblAccTwoPrice.Text = "NT$0";
            // 
            // lblAccThreePrice
            // 
            this.lblAccThreePrice.AutoSize = true;
            this.lblAccThreePrice.BackColor = System.Drawing.Color.LemonChiffon;
            this.lblAccThreePrice.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblAccThreePrice.Location = new System.Drawing.Point(650, 400);
            this.lblAccThreePrice.Name = "lblAccThreePrice";
            this.lblAccThreePrice.Size = new System.Drawing.Size(76, 31);
            this.lblAccThreePrice.TabIndex = 18;
            this.lblAccThreePrice.Text = "NT$0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp期中專題修改.Properties.Resources._15950381667482;
            this.pictureBox1.Location = new System.Drawing.Point(778, 170);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(251, 245);
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.Image = global::WindowsFormsApp期中專題修改.Properties.Resources.icons8_money_bag_50;
            this.label11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label11.Location = new System.Drawing.Point(545, 390);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 49);
            this.label11.TabIndex = 51;
            this.label11.Text = "小計";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Image = global::WindowsFormsApp期中專題修改.Properties.Resources.icons8_money_bag_50;
            this.label10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label10.Location = new System.Drawing.Point(545, 320);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 49);
            this.label10.TabIndex = 50;
            this.label10.Text = "小計";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Image = global::WindowsFormsApp期中專題修改.Properties.Resources.icons8_money_bag_50;
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label9.Location = new System.Drawing.Point(545, 250);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 49);
            this.label9.TabIndex = 49;
            this.label9.Text = "小計";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Image = global::WindowsFormsApp期中專題修改.Properties.Resources.icons8_money_bag_50;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Location = new System.Drawing.Point(437, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 49);
            this.label8.TabIndex = 48;
            this.label8.Text = "小計";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Image = global::WindowsFormsApp期中專題修改.Properties.Resources.icons8_money_bag_50;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Location = new System.Drawing.Point(437, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 49);
            this.label7.TabIndex = 47;
            this.label7.Text = "小計";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl顧客電話
            // 
            this.lbl顧客電話.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl顧客電話.Image = global::WindowsFormsApp期中專題修改.Properties.Resources.icons8_phone_50;
            this.lbl顧客電話.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl顧客電話.Location = new System.Drawing.Point(442, 30);
            this.lbl顧客電話.Name = "lbl顧客電話";
            this.lbl顧客電話.Size = new System.Drawing.Size(159, 49);
            this.lbl顧客電話.TabIndex = 46;
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
            this.lbl顧客姓名.TabIndex = 45;
            this.lbl顧客姓名.Text = "顧客姓名";
            this.lbl顧客姓名.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Image = global::WindowsFormsApp期中專題修改.Properties.Resources.icons8_pearl_48;
            this.label6.Location = new System.Drawing.Point(59, 390);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 49);
            this.label6.TabIndex = 23;
            this.label6.Text = "飾品";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Image = global::WindowsFormsApp期中專題修改.Properties.Resources.icons8_necklace_48;
            this.label5.Location = new System.Drawing.Point(59, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 49);
            this.label5.TabIndex = 22;
            this.label5.Text = "飾品";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Image = global::WindowsFormsApp期中專題修改.Properties.Resources.icons8_diamond_48;
            this.label4.Location = new System.Drawing.Point(59, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 49);
            this.label4.TabIndex = 21;
            this.label4.Text = "飾品";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Image = global::WindowsFormsApp期中專題修改.Properties.Resources.icons8_nail_48;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(59, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 49);
            this.label3.TabIndex = 20;
            this.label3.Text = "美甲類型";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Image = global::WindowsFormsApp期中專題修改.Properties.Resources.icons8_clean_48;
            this.label2.Location = new System.Drawing.Point(59, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 49);
            this.label2.TabIndex = 19;
            this.label2.Text = "卸甲";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Image = global::WindowsFormsApp期中專題修改.Properties.Resources.icons8_money_bag_50;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(76, 510);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "總金額";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form_Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(1041, 611);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl顧客電話);
            this.Controls.Add(this.lbl顧客姓名);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblAccThreePrice);
            this.Controls.Add(this.lblAccTwoPrice);
            this.Controls.Add(this.numud數量2);
            this.Controls.Add(this.comboAccThree);
            this.Controls.Add(this.numud數量1);
            this.Controls.Add(this.comboAccTwo);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.numud數量);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnComfirm);
            this.Controls.Add(this.lblAccOnePrice);
            this.Controls.Add(this.lblNailPrice);
            this.Controls.Add(this.lblCleanPrice);
            this.Controls.Add(this.comboAccOne);
            this.Controls.Add(this.comboNail);
            this.Controls.Add(this.comboClean);
            this.Name = "Form_Products";
            this.Text = "Form_Products";
            this.Load += new System.EventHandler(this.Form_Products_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numud數量)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numud數量1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numud數量2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboClean;
        private System.Windows.Forms.ComboBox comboNail;
        private System.Windows.Forms.ComboBox comboAccOne;
        private System.Windows.Forms.Label lblCleanPrice;
        private System.Windows.Forms.Label lblNailPrice;
        private System.Windows.Forms.Label lblAccOnePrice;
        private System.Windows.Forms.Button btnComfirm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.NumericUpDown numud數量;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.ComboBox comboAccTwo;
        private System.Windows.Forms.NumericUpDown numud數量1;
        private System.Windows.Forms.ComboBox comboAccThree;
        private System.Windows.Forms.NumericUpDown numud數量2;
        private System.Windows.Forms.Label lblAccTwoPrice;
        private System.Windows.Forms.Label lblAccThreePrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl顧客姓名;
        private System.Windows.Forms.Label lbl顧客電話;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}