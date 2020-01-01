using System;
using System.Windows.Forms;

namespace BuroAsistan.Source.UserControls
{
    /// <summary>
    /// Description of FreeGridView.
    /// </summary>
    public class FreeGridView : DataGridView
    {
        private string _ColumnHeaderTextList = string.Empty;
        private string _ColumnInVisibilityString = "[i]";
        private char _ColumnHeaderDeLimiter = '-';


        public FreeGridView()
            : base()
        {
            InitComp();
        }

        protected void InitComp()
        {
            this.SuspendLayout();
            //
            this.AllowDrop = false;
            this.AllowUserToAddRows = false;
            this.AllowUserToDeleteRows = false;
            this.AllowUserToOrderColumns = false;
            this.AllowUserToResizeColumns = false;
            this.AllowUserToResizeRows = false;
            this.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            this.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ColumnHeadersBorderStyle =
                System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Font = new System.Drawing.Font("Segoe UI", 10.0f, System.Drawing.FontStyle.Regular);
            this.ReadOnly = true;
            this.RowHeadersVisible = false;
            this.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.Text = string.Empty;
            //
            this.ResumeLayout(false);
            this.PerformLayout();
        }


        /// <summary>
        /// Gets, Sets ColumnHeaderTextList.
        /// </summary>
        public string ColumnHeaderTextList
        {
            get { return _ColumnHeaderTextList; }
            set
            {
                if (AllExtensions.IsNullOrSpace(value) == false)
                {
                    _ColumnHeaderTextList = value;
                    SetColumnHeaders();
                }
            }
        }

        /// <summary>
        /// Gets, Sets ColumnHeaderDeLimiter char for setting ColumnHeaderText List.
        /// </summary>
        public char ColumnHeaderDeLimiter
        {
            get { return _ColumnHeaderDeLimiter; }
            set
            {
                if (AllExtensions.IsNullOrSpace(Char.ToString(value)) == false)
                {
                    _ColumnHeaderDeLimiter = value;
                    SetColumnHeaders();
                }
            }
        }


        /// <summary>
        /// Gets, Sets ColumnInVisibilityString for setting InVisibility of Column. 
        /// if ColumnHeaderText contains this string that column is invisible.
        /// </summary>
        public string ColumnInVisibilityString
        {
            get { return _ColumnInVisibilityString; }
            set
            {
                if (AllExtensions.IsNullOrSpace(value) == false)
                {
                    _ColumnInVisibilityString = value;
                    SetColumnHeaders();
                }
            }
        }

        protected void SetColumnHeaders()
        {
            try
            {
                if (AllExtensions.IsNullOrSpace(_ColumnHeaderTextList) == false)
                {
                    string[] cols = _ColumnHeaderTextList.Split(_ColumnHeaderDeLimiter);
                    if (cols != null)
                    {
                        int counter = cols.Length > ColumnCount ? ColumnCount : cols.Length;
                        for (int i = 0; i < counter; i++)
                        {
                            this.Columns[i].HeaderText = cols[i];
                            this.Columns[i].Visible = this.Columns[i].HeaderText.Contains(_ColumnInVisibilityString) == false;
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

    }


    #region [ Internal Extension Class ]

    /// <summary>
    /// All Extension methods contains.
    /// </summary>
    internal static class AllExtensions
    {

        public static bool IsNull(object o)
        {
            return o == null;
        }

        public static bool IsNullOrDbNull(object obj)
        {
            return (null == obj | obj == DBNull.Value);
        }

        public static string ToStr(object obj)
        {
            return IsNullOrDbNull(obj) == true ? string.Empty : obj.ToString();
        }


        public static bool IsNullOrEmpty(string str)
        {
            if (str == null)
            {
                return true;
            }
            else
            {
                return str.Length == 0;
            }
        }

        public static bool IsNullOrSpace(string str)
        {
            if (str == null)
            {
                return true;
            }
            else
            {
                return str.Trim().Length == 0;
            }
        }

    }

    #endregion

}