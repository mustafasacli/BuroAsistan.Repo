namespace BuroAsistan.View.BO
{
    partial class FrmProcuration
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
            this.tblLytMain = new System.Windows.Forms.TableLayoutPanel();
            this.tblLytButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tblLytProps = new System.Windows.Forms.TableLayoutPanel();
            this.txtDetails = new System.Windows.Forms.TextBox();
            this.lblDetails = new System.Windows.Forms.Label();
            this.lblProcurationId = new System.Windows.Forms.Label();
            this.lblNotaryId = new System.Windows.Forms.Label();
            this.lblRemunerationId = new System.Windows.Forms.Label();
            this.txtProcurationId = new System.Windows.Forms.TextBox();
            this.txtNotaryId = new System.Windows.Forms.TextBox();
            this.txtRemunerationId = new System.Windows.Forms.TextBox();
            this.lblProcurationTime = new System.Windows.Forms.Label();
            this.dtpProcurationTime = new System.Windows.Forms.DateTimePicker();
            this.tblLytMain.SuspendLayout();
            this.tblLytButtons.SuspendLayout();
            this.tblLytProps.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblLytMain
            // 
            this.tblLytMain.ColumnCount = 1;
            this.tblLytMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLytMain.Controls.Add(this.tblLytButtons, 0, 1);
            this.tblLytMain.Controls.Add(this.tblLytProps, 0, 0);
            this.tblLytMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLytMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.tblLytMain.Location = new System.Drawing.Point(0, 0);
            this.tblLytMain.Name = "tblLytMain";
            this.tblLytMain.RowCount = 2;
            this.tblLytMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLytMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tblLytMain.Size = new System.Drawing.Size(362, 368);
            this.tblLytMain.TabIndex = 0;
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
            this.tblLytButtons.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.tblLytButtons.Location = new System.Drawing.Point(3, 311);
            this.tblLytButtons.Name = "tblLytButtons";
            this.tblLytButtons.RowCount = 1;
            this.tblLytButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLytButtons.Size = new System.Drawing.Size(356, 54);
            this.tblLytButtons.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnSave.Location = new System.Drawing.Point(151, 8);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 38);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnCancel.Location = new System.Drawing.Point(271, 8);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 38);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "İptal";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tblLytProps
            // 
            this.tblLytProps.ColumnCount = 2;
            this.tblLytProps.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tblLytProps.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tblLytProps.Controls.Add(this.txtDetails, 1, 4);
            this.tblLytProps.Controls.Add(this.lblDetails, 0, 4);
            this.tblLytProps.Controls.Add(this.lblProcurationId, 0, 0);
            this.tblLytProps.Controls.Add(this.lblNotaryId, 0, 1);
            this.tblLytProps.Controls.Add(this.lblRemunerationId, 0, 2);
            this.tblLytProps.Controls.Add(this.txtProcurationId, 1, 0);
            this.tblLytProps.Controls.Add(this.txtNotaryId, 1, 1);
            this.tblLytProps.Controls.Add(this.txtRemunerationId, 1, 2);
            this.tblLytProps.Controls.Add(this.lblProcurationTime, 0, 3);
            this.tblLytProps.Controls.Add(this.dtpProcurationTime, 1, 3);
            this.tblLytProps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLytProps.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.tblLytProps.Location = new System.Drawing.Point(3, 3);
            this.tblLytProps.Name = "tblLytProps";
            this.tblLytProps.RowCount = 5;
            this.tblLytProps.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tblLytProps.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tblLytProps.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tblLytProps.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tblLytProps.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.tblLytProps.Size = new System.Drawing.Size(356, 302);
            this.tblLytProps.TabIndex = 1;
            // 
            // txtDetails
            // 
            this.txtDetails.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtDetails.Location = new System.Drawing.Point(152, 229);
            this.txtDetails.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.txtDetails.Multiline = true;
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.Size = new System.Drawing.Size(194, 60);
            this.txtDetails.TabIndex = 14;
            this.txtDetails.TextChanged += new System.EventHandler(this.txtDetails_TextChanged);
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblDetails.Location = new System.Drawing.Point(15, 231);
            this.lblDetails.Margin = new System.Windows.Forms.Padding(15, 15, 3, 0);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(72, 17);
            this.lblDetails.TabIndex = 13;
            this.lblDetails.Text = "Açıklama :";
            // 
            // lblProcurationId
            // 
            this.lblProcurationId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblProcurationId.AutoSize = true;
            this.lblProcurationId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblProcurationId.Location = new System.Drawing.Point(15, 18);
            this.lblProcurationId.Margin = new System.Windows.Forms.Padding(15, 0, 3, 0);
            this.lblProcurationId.Name = "lblProcurationId";
            this.lblProcurationId.Size = new System.Drawing.Size(85, 17);
            this.lblProcurationId.TabIndex = 0;
            this.lblProcurationId.Text = "Vekalet No :";
            // 
            // lblNotaryId
            // 
            this.lblNotaryId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNotaryId.AutoSize = true;
            this.lblNotaryId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblNotaryId.Location = new System.Drawing.Point(15, 72);
            this.lblNotaryId.Margin = new System.Windows.Forms.Padding(15, 0, 3, 0);
            this.lblNotaryId.Name = "lblNotaryId";
            this.lblNotaryId.Size = new System.Drawing.Size(75, 17);
            this.lblNotaryId.TabIndex = 0;
            this.lblNotaryId.Text = "Noter Adı :";
            // 
            // lblRemunerationId
            // 
            this.lblRemunerationId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblRemunerationId.AutoSize = true;
            this.lblRemunerationId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblRemunerationId.Location = new System.Drawing.Point(15, 126);
            this.lblRemunerationId.Margin = new System.Windows.Forms.Padding(15, 0, 3, 0);
            this.lblRemunerationId.Name = "lblRemunerationId";
            this.lblRemunerationId.Size = new System.Drawing.Size(91, 17);
            this.lblRemunerationId.TabIndex = 0;
            this.lblRemunerationId.Text = "Yevmiye No :";
            // 
            // txtProcurationId
            // 
            this.txtProcurationId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtProcurationId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtProcurationId.Location = new System.Drawing.Point(152, 15);
            this.txtProcurationId.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.txtProcurationId.Name = "txtProcurationId";
            this.txtProcurationId.Size = new System.Drawing.Size(194, 23);
            this.txtProcurationId.TabIndex = 1;
            this.txtProcurationId.TextChanged += new System.EventHandler(this.txtProcurationId_TextChanged);
            this.txtProcurationId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProcurationId_KeyPress);
            // 
            // txtNotaryId
            // 
            this.txtNotaryId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtNotaryId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtNotaryId.Location = new System.Drawing.Point(152, 69);
            this.txtNotaryId.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.txtNotaryId.Name = "txtNotaryId";
            this.txtNotaryId.Size = new System.Drawing.Size(194, 23);
            this.txtNotaryId.TabIndex = 1;
            this.txtNotaryId.TextChanged += new System.EventHandler(this.txtNotaryId_TextChanged);
            // 
            // txtRemunerationId
            // 
            this.txtRemunerationId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtRemunerationId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtRemunerationId.Location = new System.Drawing.Point(152, 123);
            this.txtRemunerationId.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.txtRemunerationId.Name = "txtRemunerationId";
            this.txtRemunerationId.Size = new System.Drawing.Size(194, 23);
            this.txtRemunerationId.TabIndex = 1;
            this.txtRemunerationId.TextChanged += new System.EventHandler(this.txtRemunerationId_TextChanged);
            this.txtRemunerationId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRemunerationId_KeyPress);
            // 
            // lblProcurationTime
            // 
            this.lblProcurationTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblProcurationTime.AutoSize = true;
            this.lblProcurationTime.Location = new System.Drawing.Point(15, 180);
            this.lblProcurationTime.Margin = new System.Windows.Forms.Padding(15, 0, 3, 0);
            this.lblProcurationTime.Name = "lblProcurationTime";
            this.lblProcurationTime.Size = new System.Drawing.Size(103, 17);
            this.lblProcurationTime.TabIndex = 15;
            this.lblProcurationTime.Text = "Vekalet Tarihi :";
            // 
            // dtpProcurationTime
            // 
            this.dtpProcurationTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpProcurationTime.Location = new System.Drawing.Point(157, 179);
            this.dtpProcurationTime.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.dtpProcurationTime.Name = "dtpProcurationTime";
            this.dtpProcurationTime.Size = new System.Drawing.Size(189, 23);
            this.dtpProcurationTime.TabIndex = 16;
            this.dtpProcurationTime.ValueChanged += new System.EventHandler(this.dtpProcurationTime_ValueChanged);
            // 
            // FrmProcuration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 368);
            this.Controls.Add(this.tblLytMain);
            this.Name = "FrmProcuration";
            this.Text = "Vekalet";
            this.Load += new System.EventHandler(this.FormLoad);
            this.tblLytMain.ResumeLayout(false);
            this.tblLytButtons.ResumeLayout(false);
            this.tblLytProps.ResumeLayout(false);
            this.tblLytProps.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblLytMain;
        private System.Windows.Forms.TableLayoutPanel tblLytButtons;
        private System.Windows.Forms.TableLayoutPanel tblLytProps;
        private System.Windows.Forms.Label lblProcurationId;
        private System.Windows.Forms.Label lblNotaryId;
        private System.Windows.Forms.Label lblRemunerationId;
        private System.Windows.Forms.TextBox txtProcurationId;
        private System.Windows.Forms.TextBox txtNotaryId;
        private System.Windows.Forms.TextBox txtRemunerationId;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.TextBox txtDetails;
        private System.Windows.Forms.Label lblProcurationTime;
        private System.Windows.Forms.DateTimePicker dtpProcurationTime;
    }
}