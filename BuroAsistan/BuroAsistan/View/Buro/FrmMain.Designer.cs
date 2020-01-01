namespace BuroAsistan.View.Buro
{
    partial class FrmMain
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
            this.tblLytUpperMenu = new System.Windows.Forms.TableLayoutPanel();
            this.btnPersonList = new System.Windows.Forms.Button();
            this.btnProcurations = new System.Windows.Forms.Button();
            this.tblLytMain.SuspendLayout();
            this.tblLytUpperMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblLytMain
            // 
            this.tblLytMain.ColumnCount = 1;
            this.tblLytMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLytMain.Controls.Add(this.tblLytUpperMenu, 0, 0);
            this.tblLytMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLytMain.Location = new System.Drawing.Point(0, 0);
            this.tblLytMain.Name = "tblLytMain";
            this.tblLytMain.RowCount = 3;
            this.tblLytMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tblLytMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLytMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tblLytMain.Size = new System.Drawing.Size(811, 486);
            this.tblLytMain.TabIndex = 0;
            // 
            // tblLytUpperMenu
            // 
            this.tblLytUpperMenu.ColumnCount = 5;
            this.tblLytUpperMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblLytUpperMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblLytUpperMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblLytUpperMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblLytUpperMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblLytUpperMenu.Controls.Add(this.btnPersonList, 0, 0);
            this.tblLytUpperMenu.Controls.Add(this.btnProcurations, 1, 0);
            this.tblLytUpperMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLytUpperMenu.Location = new System.Drawing.Point(3, 3);
            this.tblLytUpperMenu.Name = "tblLytUpperMenu";
            this.tblLytUpperMenu.RowCount = 1;
            this.tblLytUpperMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLytUpperMenu.Size = new System.Drawing.Size(805, 74);
            this.tblLytUpperMenu.TabIndex = 0;
            // 
            // btnPersonList
            // 
            this.btnPersonList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.btnPersonList.Location = new System.Drawing.Point(3, 3);
            this.btnPersonList.Name = "btnPersonList";
            this.btnPersonList.Size = new System.Drawing.Size(155, 68);
            this.btnPersonList.TabIndex = 0;
            this.btnPersonList.Text = "Kişi Listesi";
            this.btnPersonList.UseVisualStyleBackColor = true;
            this.btnPersonList.Click += new System.EventHandler(this.btnPersonList_Click);
            // 
            // btnProcurations
            // 
            this.btnProcurations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnProcurations.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.btnProcurations.Location = new System.Drawing.Point(164, 3);
            this.btnProcurations.Name = "btnProcurations";
            this.btnProcurations.Size = new System.Drawing.Size(155, 68);
            this.btnProcurations.TabIndex = 1;
            this.btnProcurations.Text = "Vekaletler Listesi";
            this.btnProcurations.UseVisualStyleBackColor = true;
            this.btnProcurations.Click += new System.EventHandler(this.btnProcurations_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 486);
            this.Controls.Add(this.tblLytMain);
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.tblLytMain.ResumeLayout(false);
            this.tblLytUpperMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblLytMain;
        private System.Windows.Forms.TableLayoutPanel tblLytUpperMenu;
        private System.Windows.Forms.Button btnPersonList;
        private System.Windows.Forms.Button btnProcurations;
    }
}