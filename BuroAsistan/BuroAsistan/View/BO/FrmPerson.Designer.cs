namespace BuroAsistan.View.BO
{
    partial class FrmPerson
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

        private void InitializeComponent()
        {
            this.tblLytMain = new System.Windows.Forms.TableLayoutPanel();
            this.tblLytProperties = new System.Windows.Forms.TableLayoutPanel();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblIdentity = new System.Windows.Forms.Label();
            this.lblAdress = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtIdentity = new System.Windows.Forms.TextBox();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblForeName = new System.Windows.Forms.Label();
            this.txtForeName = new System.Windows.Forms.TextBox();
            this.tblLytButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblDetails = new System.Windows.Forms.Label();
            this.txtDetails = new System.Windows.Forms.TextBox();
            this.tblLytMain.SuspendLayout();
            this.tblLytProperties.SuspendLayout();
            this.tblLytButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblLytMain
            // 
            this.tblLytMain.ColumnCount = 1;
            this.tblLytMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLytMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblLytMain.Controls.Add(this.tblLytProperties, 0, 0);
            this.tblLytMain.Controls.Add(this.tblLytButtons, 0, 1);
            this.tblLytMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLytMain.Location = new System.Drawing.Point(0, 0);
            this.tblLytMain.Name = "tblLytMain";
            this.tblLytMain.RowCount = 2;
            this.tblLytMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLytMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tblLytMain.Size = new System.Drawing.Size(463, 410);
            this.tblLytMain.TabIndex = 0;
            // 
            // tblLytProperties
            // 
            this.tblLytProperties.ColumnCount = 2;
            this.tblLytProperties.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tblLytProperties.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tblLytProperties.Controls.Add(this.lblFirstName, 0, 0);
            this.tblLytProperties.Controls.Add(this.lblIdentity, 0, 3);
            this.tblLytProperties.Controls.Add(this.lblAdress, 0, 4);
            this.tblLytProperties.Controls.Add(this.txtFirstName, 1, 0);
            this.tblLytProperties.Controls.Add(this.txtIdentity, 1, 3);
            this.tblLytProperties.Controls.Add(this.txtAdress, 1, 4);
            this.tblLytProperties.Controls.Add(this.txtLastName, 1, 1);
            this.tblLytProperties.Controls.Add(this.lblLastName, 0, 1);
            this.tblLytProperties.Controls.Add(this.lblForeName, 0, 2);
            this.tblLytProperties.Controls.Add(this.txtForeName, 1, 2);
            this.tblLytProperties.Controls.Add(this.lblDetails, 0, 5);
            this.tblLytProperties.Controls.Add(this.txtDetails, 1, 5);
            this.tblLytProperties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLytProperties.Location = new System.Drawing.Point(3, 3);
            this.tblLytProperties.Name = "tblLytProperties";
            this.tblLytProperties.RowCount = 6;
            this.tblLytProperties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tblLytProperties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tblLytProperties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tblLytProperties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tblLytProperties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblLytProperties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblLytProperties.Size = new System.Drawing.Size(457, 354);
            this.tblLytProperties.TabIndex = 0;
            // 
            // lblFirstName
            // 
            this.lblFirstName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblFirstName.Location = new System.Drawing.Point(15, 18);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(15, 0, 3, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(36, 17);
            this.lblFirstName.TabIndex = 8;
            this.lblFirstName.Text = "Adı :";
            // 
            // lblIdentity
            // 
            this.lblIdentity.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblIdentity.AutoSize = true;
            this.lblIdentity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblIdentity.Location = new System.Drawing.Point(15, 177);
            this.lblIdentity.Margin = new System.Windows.Forms.Padding(15, 0, 3, 0);
            this.lblIdentity.Name = "lblIdentity";
            this.lblIdentity.Size = new System.Drawing.Size(96, 17);
            this.lblIdentity.TabIndex = 11;
            this.lblIdentity.Text = "TC Kimlik No :";
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblAdress.Location = new System.Drawing.Point(15, 227);
            this.lblAdress.Margin = new System.Windows.Forms.Padding(15, 15, 3, 0);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(53, 17);
            this.lblAdress.TabIndex = 12;
            this.lblAdress.Text = "Adres :";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtFirstName.Location = new System.Drawing.Point(192, 15);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(255, 23);
            this.txtFirstName.TabIndex = 0;
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            // 
            // txtIdentity
            // 
            this.txtIdentity.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtIdentity.Location = new System.Drawing.Point(192, 174);
            this.txtIdentity.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.txtIdentity.MaxLength = 11;
            this.txtIdentity.Name = "txtIdentity";
            this.txtIdentity.Size = new System.Drawing.Size(255, 23);
            this.txtIdentity.TabIndex = 3;
            this.txtIdentity.TextChanged += new System.EventHandler(this.txtIdentity_TextChanged);
            this.txtIdentity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdentity_KeyPress);
            // 
            // txtAdress
            // 
            this.txtAdress.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtAdress.Location = new System.Drawing.Point(192, 217);
            this.txtAdress.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.txtAdress.Multiline = true;
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(255, 60);
            this.txtAdress.TabIndex = 4;
            this.txtAdress.TextChanged += new System.EventHandler(this.txtAdress_TextChanged);
            // 
            // txtLastName
            // 
            this.txtLastName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtLastName.Location = new System.Drawing.Point(192, 68);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(255, 23);
            this.txtLastName.TabIndex = 1;
            this.txtLastName.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
            // 
            // lblLastName
            // 
            this.lblLastName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblLastName.Location = new System.Drawing.Point(15, 71);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(15, 0, 3, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(59, 17);
            this.lblLastName.TabIndex = 10;
            this.lblLastName.Text = "Soyadı :";
            // 
            // lblForeName
            // 
            this.lblForeName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblForeName.AutoSize = true;
            this.lblForeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblForeName.Location = new System.Drawing.Point(15, 124);
            this.lblForeName.Margin = new System.Windows.Forms.Padding(15, 0, 3, 0);
            this.lblForeName.Name = "lblForeName";
            this.lblForeName.Size = new System.Drawing.Size(71, 17);
            this.lblForeName.TabIndex = 9;
            this.lblForeName.Text = "İkinci Adı :";
            // 
            // txtForeName
            // 
            this.txtForeName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtForeName.Location = new System.Drawing.Point(192, 121);
            this.txtForeName.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.txtForeName.Name = "txtForeName";
            this.txtForeName.Size = new System.Drawing.Size(255, 23);
            this.txtForeName.TabIndex = 2;
            this.txtForeName.TextChanged += new System.EventHandler(this.txtForeName_TextChanged);
            // 
            // tblLytButtons
            // 
            this.tblLytButtons.ColumnCount = 3;
            this.tblLytButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLytButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tblLytButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tblLytButtons.Controls.Add(this.btnSave, 1, 0);
            this.tblLytButtons.Controls.Add(this.btnCancel, 2, 0);
            this.tblLytButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLytButtons.Location = new System.Drawing.Point(3, 363);
            this.tblLytButtons.Name = "tblLytButtons";
            this.tblLytButtons.RowCount = 1;
            this.tblLytButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLytButtons.Size = new System.Drawing.Size(457, 44);
            this.tblLytButtons.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSave.Location = new System.Drawing.Point(252, 3);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 38);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCancel.Location = new System.Drawing.Point(372, 3);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 38);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "İptal";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblDetails.Location = new System.Drawing.Point(15, 297);
            this.lblDetails.Margin = new System.Windows.Forms.Padding(15, 15, 3, 0);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(72, 17);
            this.lblDetails.TabIndex = 12;
            this.lblDetails.Text = "Açıklama :";
            // 
            // txtDetails
            // 
            this.txtDetails.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtDetails.Location = new System.Drawing.Point(192, 288);
            this.txtDetails.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.txtDetails.Multiline = true;
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.Size = new System.Drawing.Size(255, 60);
            this.txtDetails.TabIndex = 4;
            this.txtDetails.TextChanged += new System.EventHandler(this.txtDetails_TextChanged);
            // 
            // FrmPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 410);
            this.Controls.Add(this.tblLytMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Name = "FrmPerson";
            this.Text = "Kişi Ekle/Güncelle";
            this.Load += new System.EventHandler(this.FormLoad);
            this.tblLytMain.ResumeLayout(false);
            this.tblLytProperties.ResumeLayout(false);
            this.tblLytProperties.PerformLayout();
            this.tblLytButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion


        private System.Windows.Forms.TableLayoutPanel tblLytProperties;
        private System.Windows.Forms.TableLayoutPanel tblLytButtons;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblForeName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblIdentity;
        private System.Windows.Forms.Label lblAdress;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtForeName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtIdentity;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.TableLayoutPanel tblLytMain;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.TextBox txtDetails;


    }
}