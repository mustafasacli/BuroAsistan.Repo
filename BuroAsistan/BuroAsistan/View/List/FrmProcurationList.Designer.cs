namespace BuroAsistan.View.List
{
    partial class FrmProcurationList
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
            this.grdProcurations = new BuroAsistan.Source.UserControls.FreeGridView();
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
            this.cntxtMnProcuration = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tblLytMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProcurations)).BeginInit();
            this.tblLytButtons.SuspendLayout();
            this.tblLytSearch.SuspendLayout();
            this.grpSearchOptions.SuspendLayout();
            this.cntxtMnProcuration.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblLytMain
            // 
            this.tblLytMain.ColumnCount = 1;
            this.tblLytMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLytMain.Controls.Add(this.grdProcurations, 0, 0);
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
            this.tblLytMain.Size = new System.Drawing.Size(981, 527);
            this.tblLytMain.TabIndex = 1;
            // 
            // grdProcurations
            // 
            this.grdProcurations.AllowUserToAddRows = false;
            this.grdProcurations.AllowUserToDeleteRows = false;
            this.grdProcurations.AllowUserToResizeColumns = false;
            this.grdProcurations.AllowUserToResizeRows = false;
            this.grdProcurations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdProcurations.ColumnHeaderDeLimiter = '-';
            this.grdProcurations.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grdProcurations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProcurations.ColumnHeaderTextList = "";
            this.grdProcurations.ColumnInVisibilityString = "[i]";
            this.grdProcurations.ContextMenuStrip = this.cntxtMnProcuration;
            this.grdProcurations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdProcurations.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grdProcurations.Location = new System.Drawing.Point(4, 4);
            this.grdProcurations.Margin = new System.Windows.Forms.Padding(4);
            this.grdProcurations.Name = "grdProcurations";
            this.grdProcurations.ReadOnly = true;
            this.grdProcurations.RowHeadersVisible = false;
            this.grdProcurations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdProcurations.Size = new System.Drawing.Size(973, 359);
            this.grdProcurations.TabIndex = 0;
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
            this.tblLytButtons.Location = new System.Drawing.Point(4, 371);
            this.tblLytButtons.Margin = new System.Windows.Forms.Padding(4);
            this.tblLytButtons.Name = "tblLytButtons";
            this.tblLytButtons.RowCount = 1;
            this.tblLytButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLytButtons.Size = new System.Drawing.Size(973, 72);
            this.tblLytButtons.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.btnAdd.Location = new System.Drawing.Point(35, 6);
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
            this.btnUpdate.Location = new System.Drawing.Point(229, 6);
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
            this.btnDelete.Location = new System.Drawing.Point(423, 6);
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
            this.btnActivate.Location = new System.Drawing.Point(617, 6);
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
            this.btnRefreshList.Location = new System.Drawing.Point(813, 6);
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
            this.tblLytSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 121F));
            this.tblLytSearch.Controls.Add(this.grpSearchOptions, 0, 0);
            this.tblLytSearch.Controls.Add(this.lblSearchType, 2, 0);
            this.tblLytSearch.Controls.Add(this.cmbxSearchType, 3, 0);
            this.tblLytSearch.Controls.Add(this.txtSearch, 6, 0);
            this.tblLytSearch.Controls.Add(this.lblSearchText, 5, 0);
            this.tblLytSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLytSearch.Location = new System.Drawing.Point(3, 450);
            this.tblLytSearch.Name = "tblLytSearch";
            this.tblLytSearch.RowCount = 1;
            this.tblLytSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLytSearch.Size = new System.Drawing.Size(975, 74);
            this.tblLytSearch.TabIndex = 2;
            // 
            // grpSearchOptions
            // 
            this.grpSearchOptions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpSearchOptions.Controls.Add(this.rdbtnContains);
            this.grpSearchOptions.Controls.Add(this.rdbtnExactMatch);
            this.grpSearchOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
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
            this.rdbtnContains.Click += new System.EventHandler(this.SearchOptionChanged);
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
            this.rdbtnExactMatch.Click += new System.EventHandler(this.SearchOptionChanged);
            // 
            // lblSearchType
            // 
            this.lblSearchType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSearchType.AutoSize = true;
            this.lblSearchType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblSearchType.Location = new System.Drawing.Point(362, 28);
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
            this.cmbxSearchType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.cmbxSearchType.FormattingEnabled = true;
            this.cmbxSearchType.Location = new System.Drawing.Point(470, 23);
            this.cmbxSearchType.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.cmbxSearchType.Name = "cmbxSearchType";
            this.cmbxSearchType.Size = new System.Drawing.Size(114, 25);
            this.cmbxSearchType.TabIndex = 2;
            this.cmbxSearchType.SelectedIndexChanged += new System.EventHandler(this.SearchTypeChanged);
            this.cmbxSearchType.Click += new System.EventHandler(this.SearchTypeChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtSearch.Location = new System.Drawing.Point(857, 24);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(114, 23);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.Click += new System.EventHandler(this.SearchTextChanged);
            this.txtSearch.TextChanged += new System.EventHandler(this.SearchTextChanged);
            // 
            // lblSearchText
            // 
            this.lblSearchText.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSearchText.AutoSize = true;
            this.lblSearchText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblSearchText.Location = new System.Drawing.Point(749, 28);
            this.lblSearchText.Margin = new System.Windows.Forms.Padding(15, 0, 3, 0);
            this.lblSearchText.Name = "lblSearchText";
            this.lblSearchText.Size = new System.Drawing.Size(95, 17);
            this.lblSearchText.TabIndex = 4;
            this.lblSearchText.Text = "Arama Metni :";
            // 
            // cntxtMnProcuration
            // 
            this.cntxtMnProcuration.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.activateToolStripMenuItem,
            this.refreshListToolStripMenuItem});
            this.cntxtMnProcuration.Name = "cntxtMnProcuration";
            this.cntxtMnProcuration.Size = new System.Drawing.Size(132, 114);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // activateToolStripMenuItem
            // 
            this.activateToolStripMenuItem.Name = "activateToolStripMenuItem";
            this.activateToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.activateToolStripMenuItem.Text = "Activate";
            this.activateToolStripMenuItem.Click += new System.EventHandler(this.activateToolStripMenuItem_Click);
            // 
            // refreshListToolStripMenuItem
            // 
            this.refreshListToolStripMenuItem.Name = "refreshListToolStripMenuItem";
            this.refreshListToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.refreshListToolStripMenuItem.Text = "RefreshList";
            this.refreshListToolStripMenuItem.Click += new System.EventHandler(this.refreshListToolStripMenuItem_Click);
            // 
            // FrmProcurationList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 527);
            this.Controls.Add(this.tblLytMain);
            this.Name = "FrmProcurationList";
            this.Text = "FrmProcurationList";
            this.Load += new System.EventHandler(this.FormLoad);
            this.tblLytMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdProcurations)).EndInit();
            this.tblLytButtons.ResumeLayout(false);
            this.tblLytSearch.ResumeLayout(false);
            this.tblLytSearch.PerformLayout();
            this.grpSearchOptions.ResumeLayout(false);
            this.grpSearchOptions.PerformLayout();
            this.cntxtMnProcuration.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblLytMain;
        private Source.UserControls.FreeGridView grdProcurations;
        private System.Windows.Forms.TableLayoutPanel tblLytButtons;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnActivate;
        private System.Windows.Forms.Button btnRefreshList;
        private System.Windows.Forms.TableLayoutPanel tblLytSearch;
        private System.Windows.Forms.GroupBox grpSearchOptions;
        private System.Windows.Forms.RadioButton rdbtnContains;
        private System.Windows.Forms.RadioButton rdbtnExactMatch;
        private System.Windows.Forms.Label lblSearchType;
        private Source.UserControls.FreeComboBox cmbxSearchType;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearchText;
        private System.Windows.Forms.ContextMenuStrip cntxtMnProcuration;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshListToolStripMenuItem;

    }
}