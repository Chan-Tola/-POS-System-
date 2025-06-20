namespace Project
{
    partial class fmPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmPayment));
            this.btnCancel = new System.Windows.Forms.Button();
            this.IpDate = new System.Windows.Forms.Label();
            this.txtStaff = new System.Windows.Forms.TextBox();
            this.sId = new System.Windows.Forms.Label();
            this.sName = new System.Windows.Forms.Label();
            this.cbStaffId = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCPY = new System.Windows.Forms.TextBox();
            this.cbOC = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.la2 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.la1 = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.txtRemain = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtDP = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(461, 20);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(30, 36);
            this.btnCancel.TabIndex = 28;
            this.btnCancel.Text = "X";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // IpDate
            // 
            this.IpDate.AutoSize = true;
            this.IpDate.BackColor = System.Drawing.Color.Transparent;
            this.IpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IpDate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.IpDate.Location = new System.Drawing.Point(169, 23);
            this.IpDate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.IpDate.Name = "IpDate";
            this.IpDate.Size = new System.Drawing.Size(137, 33);
            this.IpDate.TabIndex = 30;
            this.IpDate.Text = "Payment";
            // 
            // txtStaff
            // 
            this.txtStaff.BackColor = System.Drawing.Color.White;
            this.txtStaff.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStaff.Enabled = false;
            this.txtStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaff.Location = new System.Drawing.Point(198, 251);
            this.txtStaff.Multiline = true;
            this.txtStaff.Name = "txtStaff";
            this.txtStaff.ReadOnly = true;
            this.txtStaff.Size = new System.Drawing.Size(268, 33);
            this.txtStaff.TabIndex = 39;
            // 
            // sId
            // 
            this.sId.AutoSize = true;
            this.sId.BackColor = System.Drawing.Color.Transparent;
            this.sId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sId.Location = new System.Drawing.Point(34, 208);
            this.sId.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.sId.Name = "sId";
            this.sId.Size = new System.Drawing.Size(85, 25);
            this.sId.TabIndex = 38;
            this.sId.Text = "Staff Id ";
            // 
            // sName
            // 
            this.sName.AutoSize = true;
            this.sName.BackColor = System.Drawing.Color.Transparent;
            this.sName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sName.Location = new System.Drawing.Point(260, 208);
            this.sName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.sName.Name = "sName";
            this.sName.Size = new System.Drawing.Size(118, 25);
            this.sName.TabIndex = 37;
            this.sName.Text = "Staff Name";
            // 
            // cbStaffId
            // 
            this.cbStaffId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStaffId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStaffId.FormattingEnabled = true;
            this.cbStaffId.Location = new System.Drawing.Point(32, 251);
            this.cbStaffId.Name = "cbStaffId";
            this.cbStaffId.Size = new System.Drawing.Size(113, 33);
            this.cbStaffId.TabIndex = 36;
            this.cbStaffId.SelectionChangeCommitted += new System.EventHandler(this.cbStaffId_SelectionChangeCommitted);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(23, 89);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 25);
            this.label8.TabIndex = 54;
            this.label8.Text = "Import Date :";
            // 
            // dtp
            // 
            this.dtp.CustomFormat = "dd-MM-yyyy";
            this.dtp.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp.Location = new System.Drawing.Point(198, 89);
            this.dtp.Margin = new System.Windows.Forms.Padding(6);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(160, 31);
            this.dtp.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 147);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 55;
            this.label1.Text = "Code :";
            // 
            // txtCPY
            // 
            this.txtCPY.BackColor = System.Drawing.Color.White;
            this.txtCPY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCPY.Enabled = false;
            this.txtCPY.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPY.Location = new System.Drawing.Point(198, 147);
            this.txtCPY.Multiline = true;
            this.txtCPY.Name = "txtCPY";
            this.txtCPY.ReadOnly = true;
            this.txtCPY.Size = new System.Drawing.Size(80, 33);
            this.txtCPY.TabIndex = 56;
            // 
            // cbOC
            // 
            this.cbOC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOC.FormattingEnabled = true;
            this.cbOC.Location = new System.Drawing.Point(28, 344);
            this.cbOC.Name = "cbOC";
            this.cbOC.Size = new System.Drawing.Size(149, 33);
            this.cbOC.TabIndex = 57;
            this.cbOC.SelectionChangeCommitted += new System.EventHandler(this.cbOC_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 309);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 25);
            this.label2.TabIndex = 58;
            this.label2.Text = "Order Code";
            // 
            // la2
            // 
            this.la2.AutoSize = true;
            this.la2.BackColor = System.Drawing.Color.Transparent;
            this.la2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.la2.Location = new System.Drawing.Point(214, 391);
            this.la2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.la2.Name = "la2";
            this.la2.Size = new System.Drawing.Size(85, 25);
            this.la2.TabIndex = 59;
            this.la2.Text = "Deposit";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.White;
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(28, 423);
            this.txtTotal.Multiline = true;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(117, 33);
            this.txtTotal.TabIndex = 62;
            // 
            // la1
            // 
            this.la1.AutoSize = true;
            this.la1.BackColor = System.Drawing.Color.Transparent;
            this.la1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.la1.Location = new System.Drawing.Point(50, 391);
            this.la1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.la1.Name = "la1";
            this.la1.Size = new System.Drawing.Size(60, 25);
            this.la1.TabIndex = 61;
            this.la1.Text = "Total";
            // 
            // btnPay
            // 
            this.btnPay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.Image = ((System.Drawing.Image)(resources.GetObject("btnPay.Image")));
            this.btnPay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPay.Location = new System.Drawing.Point(175, 534);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(140, 44);
            this.btnPay.TabIndex = 63;
            this.btnPay.Text = "Payment";
            this.btnPay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPay.UseVisualStyleBackColor = true;
            // 
            // txtRemain
            // 
            this.txtRemain.BackColor = System.Drawing.Color.White;
            this.txtRemain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemain.Enabled = false;
            this.txtRemain.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemain.Location = new System.Drawing.Point(349, 423);
            this.txtRemain.Multiline = true;
            this.txtRemain.Name = "txtRemain";
            this.txtRemain.ReadOnly = true;
            this.txtRemain.Size = new System.Drawing.Size(117, 33);
            this.txtRemain.TabIndex = 66;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(363, 391);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 25);
            this.label3.TabIndex = 65;
            this.label3.Text = "Remain";
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtDP);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(489, 584);
            this.panel1.TabIndex = 67;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-3, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(491, 584);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtDP
            // 
            this.txtDP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDP.Location = new System.Drawing.Point(185, 410);
            this.txtDP.Multiline = true;
            this.txtDP.Name = "txtDP";
            this.txtDP.Size = new System.Drawing.Size(117, 33);
            this.txtDP.TabIndex = 1;
            this.txtDP.Leave += new System.EventHandler(this.txtDP_Leave);
            // 
            // fmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(513, 608);
            this.Controls.Add(this.txtRemain);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.la1);
            this.Controls.Add(this.la2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbOC);
            this.Controls.Add(this.txtCPY);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.txtStaff);
            this.Controls.Add(this.sId);
            this.Controls.Add(this.sName);
            this.Controls.Add(this.cbStaffId);
            this.Controls.Add(this.IpDate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fmPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fmPayment";
            this.Load += new System.EventHandler(this.fmPayment_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label IpDate;
        private System.Windows.Forms.TextBox txtStaff;
        private System.Windows.Forms.Label sId;
        private System.Windows.Forms.Label sName;
        private System.Windows.Forms.ComboBox cbStaffId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCPY;
        private System.Windows.Forms.ComboBox cbOC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label la2;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label la1;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.TextBox txtRemain;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtDP;
    }
}