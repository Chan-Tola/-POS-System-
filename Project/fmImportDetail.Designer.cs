namespace Project
{
    partial class fmImportDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmImportDetail));
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.IpDate = new System.Windows.Forms.Label();
            this.cbId = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sName = new System.Windows.Forms.Label();
            this.sId = new System.Windows.Forms.Label();
            this.txtStaff = new System.Windows.Forms.TextBox();
            this.txtSpId = new System.Windows.Forms.TextBox();
            this.cbSp = new System.Windows.Forms.ComboBox();
            this.txtPID = new System.Windows.Forms.TextBox();
            this.txtPName = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtUP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRm = new System.Windows.Forms.Button();
            this.lvs = new System.Windows.Forms.ListView();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtp
            // 
            this.dtp.CustomFormat = "dd-MM-yyyy";
            this.dtp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp.Location = new System.Drawing.Point(252, 138);
            this.dtp.Margin = new System.Windows.Forms.Padding(6);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(160, 31);
            this.dtp.TabIndex = 0;
            // 
            // IpDate
            // 
            this.IpDate.AutoSize = true;
            this.IpDate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.IpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IpDate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.IpDate.Location = new System.Drawing.Point(317, 66);
            this.IpDate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.IpDate.Name = "IpDate";
            this.IpDate.Size = new System.Drawing.Size(267, 33);
            this.IpDate.TabIndex = 1;
            this.IpDate.Text = "Form ImportDetail";
            // 
            // cbId
            // 
            this.cbId.FormattingEnabled = true;
            this.cbId.Location = new System.Drawing.Point(214, 189);
            this.cbId.Name = "cbId";
            this.cbId.Size = new System.Drawing.Size(62, 33);
            this.cbId.TabIndex = 2;
            this.cbId.SelectionChangeCommitted += new System.EventHandler(this.cbId_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 357);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Supplier\'s Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(112, 297);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Supplier\'s  Id  :";
            // 
            // sName
            // 
            this.sName.AutoSize = true;
            this.sName.BackColor = System.Drawing.Color.White;
            this.sName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sName.Location = new System.Drawing.Point(111, 246);
            this.sName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.sName.Name = "sName";
            this.sName.Size = new System.Drawing.Size(130, 25);
            this.sName.TabIndex = 5;
            this.sName.Text = "Staff Name :";
            // 
            // sId
            // 
            this.sId.AutoSize = true;
            this.sId.BackColor = System.Drawing.Color.White;
            this.sId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sId.Location = new System.Drawing.Point(108, 189);
            this.sId.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.sId.Name = "sId";
            this.sId.Size = new System.Drawing.Size(97, 25);
            this.sId.TabIndex = 6;
            this.sId.Text = "Staff Id : ";
            // 
            // txtStaff
            // 
            this.txtStaff.BackColor = System.Drawing.Color.White;
            this.txtStaff.Location = new System.Drawing.Point(252, 240);
            this.txtStaff.Name = "txtStaff";
            this.txtStaff.ReadOnly = true;
            this.txtStaff.Size = new System.Drawing.Size(268, 31);
            this.txtStaff.TabIndex = 7;
            // 
            // txtSpId
            // 
            this.txtSpId.BackColor = System.Drawing.Color.White;
            this.txtSpId.Location = new System.Drawing.Point(271, 291);
            this.txtSpId.Name = "txtSpId";
            this.txtSpId.ReadOnly = true;
            this.txtSpId.Size = new System.Drawing.Size(141, 31);
            this.txtSpId.TabIndex = 8;
            // 
            // cbSp
            // 
            this.cbSp.FormattingEnabled = true;
            this.cbSp.Location = new System.Drawing.Point(301, 349);
            this.cbSp.Name = "cbSp";
            this.cbSp.Size = new System.Drawing.Size(326, 33);
            this.cbSp.TabIndex = 9;
            this.cbSp.SelectionChangeCommitted += new System.EventHandler(this.cbSp_SelectionChangeCommitted);
            // 
            // txtPID
            // 
            this.txtPID.Location = new System.Drawing.Point(12, 454);
            this.txtPID.Name = "txtPID";
            this.txtPID.Size = new System.Drawing.Size(129, 31);
            this.txtPID.TabIndex = 10;
            this.txtPID.Leave += new System.EventHandler(this.txtPID_Leave);
            // 
            // txtPName
            // 
            this.txtPName.Location = new System.Drawing.Point(158, 454);
            this.txtPName.Name = "txtPName";
            this.txtPName.Size = new System.Drawing.Size(261, 31);
            this.txtPName.TabIndex = 11;
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(444, 454);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(111, 31);
            this.txtQty.TabIndex = 12;
            // 
            // txtUP
            // 
            this.txtUP.Location = new System.Drawing.Point(583, 454);
            this.txtUP.Name = "txtUP";
            this.txtUP.Size = new System.Drawing.Size(129, 31);
            this.txtUP.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(594, 423);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Unit Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(457, 423);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Quanity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(213, 421);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "Product Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(2, 421);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "Product Code :";
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(727, 506);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(109, 36);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSave.Location = new System.Drawing.Point(727, 564);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(109, 36);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRm
            // 
            this.btnRm.Image = ((System.Drawing.Image)(resources.GetObject("btnRm.Image")));
            this.btnRm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRm.Location = new System.Drawing.Point(727, 622);
            this.btnRm.Name = "btnRm";
            this.btnRm.Size = new System.Drawing.Size(124, 36);
            this.btnRm.TabIndex = 20;
            this.btnRm.Text = "Remove";
            this.btnRm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRm.UseVisualStyleBackColor = true;
            this.btnRm.Click += new System.EventHandler(this.btnRm_Click);
            // 
            // lvs
            // 
            this.lvs.FullRowSelect = true;
            this.lvs.GridLines = true;
            this.lvs.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvs.HideSelection = false;
            this.lvs.Location = new System.Drawing.Point(12, 506);
            this.lvs.MultiSelect = false;
            this.lvs.Name = "lvs";
            this.lvs.Size = new System.Drawing.Size(700, 230);
            this.lvs.TabIndex = 21;
            this.lvs.UseCompatibleStateImageBehavior = false;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(234, 739);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(268, 31);
            this.txtTotal.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(153, 745);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 25);
            this.label7.TabIndex = 23;
            this.label7.Text = "Total :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Window;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(112, 144);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 25);
            this.label8.TabIndex = 24;
            this.label8.Text = "Import Date :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(890, 776);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(769, 12);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(109, 44);
            this.btnCancel.TabIndex = 26;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // fmImportDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 776);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lvs);
            this.Controls.Add(this.btnRm);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUP);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.txtPName);
            this.Controls.Add(this.txtPID);
            this.Controls.Add(this.cbSp);
            this.Controls.Add(this.txtSpId);
            this.Controls.Add(this.txtStaff);
            this.Controls.Add(this.sId);
            this.Controls.Add(this.sName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbId);
            this.Controls.Add(this.IpDate);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimizeBox = false;
            this.Name = "fmImportDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IMPORT DETAIL FORM";
            this.Load += new System.EventHandler(this.ImportDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.Label IpDate;
        private System.Windows.Forms.ComboBox cbId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label sName;
        private System.Windows.Forms.Label sId;
        private System.Windows.Forms.TextBox txtStaff;
        private System.Windows.Forms.TextBox txtSpId;
        private System.Windows.Forms.ComboBox cbSp;
        private System.Windows.Forms.TextBox txtPID;
        private System.Windows.Forms.TextBox txtPName;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.TextBox txtUP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRm;
        private System.Windows.Forms.ListView lvs;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCancel;
    }
}