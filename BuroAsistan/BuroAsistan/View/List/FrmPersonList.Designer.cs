namespace BuroAsistan.View.List
{
    partial class FrmPersonList
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
            this.components = new System.ComponentModel.Container();
            this.tblLytMain = new System.Windows.Forms.TableLayoutPanel();
            this.grdPersons = new BuroAsistan.Source.UserControls.FreeGridView();
            this.cntxtMnPerson = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tblLytButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnActivate = new System.Windows.Forms.Button();
            this.btnRefreshList = new System.Windows.Forms.Button();
            this.tblLytSearch = new System.Windows.Forms.TableLayoutPanel();
            this.grpSearchOptions = new System.Windows.Forms.GroupBox();
            this.rdbtnContains = new System.Windows.Forms.RadioButton();
            this.rdbtnExactMatch = new System.Windows.Forms.RadioButton();
            this.lblSearchType = new System.Windows.Forms.Label();
            this.cmbxSearchType = new BuroAsistan.Source.UserControls.FreeComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearchText = new System.Windows.Forms.Label();
            this.tblLytMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPersons)).BeginInit();
            this.cntxtMnPerson.SuspendLayout();
            this.tblLytButtons.SuspendLayout();
            this.tblLytSearch.SuspendLayout();
            this.grpSearchOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblLytMain
            // 
            this.tblLytMain.ColumnCount = 1;
            this.tblLytMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLytMain.Controls.Add(this.grdPersons, 0, 0);
            this.tblLytMain.Controls.Add(this.tblLytButtons, 0, 1);
            this.tblLytMain.Controls.Add(this.tblLytSearch, 0, 2);
            this.tblLytMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLytMain.Location = new System.Drawing.Point(0, 0);
            this.tblLytMain.Margin = new System.Windows.Forms.Padding(4);
            this.tblLytMain.Name = "tblLytMain";
            this.tblLytMain.RowCount = 3;
            this.tblLytMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLytMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tblLytMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tblLytMain.Size = new System.Drawing.Size(906, 617);
            this.tblLytMain.TabIndex = 0;
            // 
            // grdPersons
            // 
            this.grdPersons.AllowUserToAddRows = false;
            this.grdPersons.AllowUserToDeleteRows = false;
            this.grdPersons.AllowUserToResizeColumns = false;
            this.grdPersons.AllowUserToResizeRows = false;
            this.grdPersons.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdPersons.ColumnHeaderDeLimiter = '-';
            this.grdPersons.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grdPersons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPersons.ColumnHeaderTextList = "";
            this.grdPersons.ColumnInVisibilityString = "[i]";
            this.grdPersons.ContextMenuStrip = this.cntxtMnPerson;
            this.grdPersons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdPersons.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grdPersons.Location = new System.Drawing.Point(4, 4);
            this.grdPersons.Margin = new System.Windows.Forms.Padding(4);
            this.grdPersons.Name = "grdPersons";
            this.grdPersons.ReadOnly = true;
            this.grdPersons.RowHeadersVisible = false;
            this.grdPersons.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdPersons.Size = new System.Drawing.Size(898, 449);
            this.grdPersons.TabIndex = 0;
            // 
            // cntxtMnPerson
            // 
            this.cntxtMnPerson.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.activateToolStripMenuItem,
            this.refreshListToolStripMenuItem});
            this.cntxtMnPerson.Name = "cntxtMnPerson";
            this.cntxtMnPerson.Size = new System.Drawing.Size(153, 136);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // activateToolStripMenuItem
            // 
            this.activateToolStripMenuItem.Name = "activateToolStripMenuItem";
            this.activateToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.activateToolStripMenuItem.Text = "Activate";
            this.activateToolStripMenuItem.Click += new System.EventHandler(this.activateToolStripMenuItem_Click);
            // 
            // refreshListToolStripMenuItem
            // 
            this.refreshListToolStripMenuItem.Name = "refreshListToolStripMenuItem";
            this.refreshListToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.refreshListToolStripMenuItem.Text = "RefreshList";
            this.refreshListToolStripMenuItem.Click += new System.EventHandler(this.refreshListToolStripMenuItem_Click);
            // 
            // tblLytButtons
            // 
            this.tblLytButtons.ColumnCount = 5;
            this.tblLytButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblLytButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblLytButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblLytButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblLytButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblLytButtons.Controls.Add(this.btnAdd, 0, 0);
            this.tblLytButtons.Controls.Add(this.btnUpdate, 1, 0);
            this.tblLytButtons.Controls.Add(this.btnDelete, 2, 0);
            this.tblLytButtons.Controls.Add(this.btnActivate, 3, 0);
            this.tblLytButtons.Controls.Add(this.btnRefreshList, 4, 0);
            this.tblLytButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLytButtons.Location = new System.Drawing.Point(4, 461);
            this.tblLytButtons.Margin = new System.Windows.Forms.Padding(4);
            this.tblLytButtons.Name = "tblLytButtons";
            this.tblLytButtons.RowCount = 1;
            this.tblLytButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLytButtons.Size = new System.Drawing.Size(898, 72);
            this.tblLytButtons.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.btnAdd.Location = new System.Drawing.Point(28, 6);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(123, 60);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.Location = new System.Drawing.Point(207, 6);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(123, 60);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.btnDelete.Location = new System.Drawing.Point(386, 6);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(123, 60);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnActivate
            // 
            this.btnActivate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnActivate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.btnActivate.Location = new System.Drawing.Point(565, 6);
            this.btnActivate.Margin = new System.Windows.Forms.Padding(4);
            this.btnActivate.Name = "btnActivate";
            this.btnActivate.Size = new System.Drawing.Size(123, 60);
            this.btnActivate.TabIndex = 0;
            this.btnActivate.Text = "Aktif Et";
            this.btnActivate.UseVisualStyleBackColor = true;
            this.btnActivate.Click += new System.EventHandler(this.btnActivate_Click);
            // 
            // btnRefreshList
            // 
            this.btnRefreshList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRefreshList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.btnRefreshList.Location = new System.Drawing.Point(745, 6);
            this.btnRefreshList.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefreshList.Name = "btnRefreshList";
            this.btnRefreshList.Size = new System.Drawing.Size(123, 60);
            this.btnRefreshList.TabIndex = 1;
            this.btnRefreshList.Text = "Listeyi Yenile";
            this.btnRefreshList.UseVisualStyleBackColor = true;
            this.btnRefreshList.Click += new System.EventHandler(this.btnRefreshList_Click);
            // 
            // tblLytSearch
            // 
            this.tblLytSearch.ColumnCount = 7;
            this.tblLytSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tblLytSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLytSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tblLytSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tblLytSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLytSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tblLytSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tblLytSearch.Controls.Add(this.grpSearchOptions, 0, 0);
            this.tblLytSearch.Controls.Add(this.lblSearchType, 2, 0);
            this.tblLytSearch.Controls.Add(this.cmbxSearchType, 3, 0);
            this.tblLytSearch.Controls.Add(this.txtSearch, 6, 0);
            this.tblLytSearch.Controls.Add(this.lblSearchText, 5, 0);
            this.tblLytSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLytSearch.Location = new System.Drawing.Point(3, 540);
            this.tblLytSearch.Name = "tblLytSearch";
            this.tblLytSearch.RowCount = 1;
            this.tblLytSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLytSearch.Size = new System.Drawing.Size(900, 74);
            this.tblLytSearch.TabIndex = 2;
            // 
            // grpSearchOptions
            // 
            this.grpSearchOptions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpSearchOptions.Controls.Add(this.rdbtnContains);
            this.grpSearchOptions.Controls.Add(this.rdbtnExactMatch);
            this.grpSearchOptions.Location = new System.Drawing.Point(3, 7);
            this.grpSearchOptions.Name = "grpSearchOptions";
            this.grpSearchOptions.Size = new System.Drawing.Size(194, 59);
            this.grpSearchOptions.TabIndex = 0;
            this.grpSearchOptions.TabStop = false;
            this.grpSearchOptions.Text = "Arama Seçeneği";
            // 
            // rdbtnContains
            // 
            this.rdbtnContains.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdbtnContains.AutoSize = true;
            this.rdbtnContains.Location = new System.Drawing.Point(114, 19);
            this.rdbtnContains.Name = "rdbtnContains";
            this.rdbtnContains.Size = new System.Drawing.Size(65, 21);
            this.rdbtnContains.TabIndex = 0;
            this.rdbtnContains.TabStop = true;
            this.rdbtnContains.Text = "İçeren";
            this.rdbtnContains.UseVisualStyleBackColor = true;
            this.rdbtnContains.CheckedChanged += new System.EventHandler(this.SearchOptionChanged);
            // 
            // rdbtnExactMatch
            // 
            this.rdbtnExactMatch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdbtnExactMatch.AutoSize = true;
            this.rdbtnExactMatch.Location = new System.Drawing.Point(15, 19);
            this.rdbtnExactMatch.Name = "rdbtnExactMatch";
            this.rdbtnExactMatch.Size = new System.Drawing.Size(49, 21);
            this.rdbtnExactMatch.TabIndex = 0;
            this.rdbtnExactMatch.TabStop = true;
            this.rdbtnExactMatch.Text = "Eşit";
            this.rdbtnExactMatch.UseVisualStyleBackColor = true;
            this.rdbtnExactMatch.CheckedChanged += new System.EventHandler(this.SearchOptionChanged);
            // 
            // lblSearchType
            // 
            this.lblSearchType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSearchType.AutoSize = true;
            this.lblSearchType.Location = new System.Drawing.Point(325, 28);
            this.lblSearchType.Margin = new System.Windows.Forms.Padding(15, 0, 3, 0);
            this.lblSearchType.Name = "lblSearchType";
            this.lblSearchType.Size = new System.Drawing.Size(84, 17);
            this.lblSearchType.TabIndex = 1;
            this.lblSearchType.Text = "Arama Tipi :";
            // 
            // cmbxSearchType
            // 
            this.cmbxSearchType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbxSearchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxSearchType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbxSearchType.FormattingEnabled = true;
            this.cmbxSearchType.Location = new System.Drawing.Point(433, 22);
            this.cmbxSearchType.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.cmbxSearchType.Name = "cmbxSearchType";
            this.cmbxSearchType.Size = new System.Drawing.Size(114, 25);
            this.cmbxSearchType.TabIndex = 2;
            this.cmbxSearchType.SelectedIndexChanged += new System.EventHandler(this.SearchTypeChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSearch.Location = new System.Drawing.Point(783, 24);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(114, 23);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.TextChanged += new System.EventHandler(this.SearchTextChanged);
            // 
            // lblSearchText
            // 
            this.lblSearchText.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSearchText.AutoSize = true;
            this.lblSearchText.Location = new System.Drawing.Point(675, 28);
            this.lblSearchText.Margin = new System.Windows.Forms.Padding(15, 0, 3, 0);
            this.lblSearchText.Name = "lblSearchText";
            this.lblSearchText.Size = new System.Drawing.Size(95, 17);
            this.lblSearchText.TabIndex = 4;
            this.lblSearchText.Text = "Arama Metni :";
            // 
            // FrmPersonList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 617);
            this.Controls.Add(this.tblLytMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPersonList";
            this.Text = "Kişi Listesi";
            this.Load += new System.EventHandler(this.FormLoad);
            this.tblLytMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdPersons)).EndInit();
            this.cntxtMnPerson.ResumeLayout(false);
            this.tblLytButtons.ResumeLayout(false);
            this.tblLytSearch.ResumeLayout(false);
            this.tblLytSearch.PerformLayout();
            this.grpSearchOptions.ResumeLayout(false);
            this.grpSearchOptions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblLytMain;
        private Source.UserControls.FreeGridView grdPersons;
        private System.Windows.Forms.TableLayoutPanel tblLytButtons;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnActivate;
        private System.Windows.Forms.TableLayoutPanel tblLytSearch;
        private System.Windows.Forms.GroupBox grpSearchOptions;
        private System.Windows.Forms.RadioButton rdbtnContains;
        private System.Windows.Forms.RadioButton rdbtnExactMatch;
        private System.Windows.Forms.Label lblSearchType;
        private Source.UserControls.FreeComboBox cmbxSearchType;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearchText;
        private System.Windows.Forms.Button btnRefreshList;
        private System.Windows.Forms.ContextMenuStrip cntxtMnPerson;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshListToolStripMenuItem;
    }
}