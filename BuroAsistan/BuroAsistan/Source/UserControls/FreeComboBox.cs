using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using System.Windows.Forms;

namespace BuroAsistan.Source.UserControls
{
    /// <summary>
    /// Description of FreeComboBox.
    /// </summary>
    public class FreeComboBox : ComboBox
    {
        private List<FreeObject> ObjList;
        protected object _value = null;
        private string _text;

        public FreeComboBox()
            : base()
        {
            this.ObjList = new List<FreeObject>();
            this.InitComp();
        }

        protected void InitComp()
        {
            this.SuspendLayout();
            this.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DropDownStyle = ComboBoxStyle.DropDownList;
            this.Font = new System.Drawing.Font("Segoe UI", 10.0f, System.Drawing.FontStyle.Regular);
            this.Text = string.Empty;
            this.ResumeLayout(false);
            this.PerformLayout();
        }


        protected override void OnSelectedIndexChanged(EventArgs e)
        {
            base.OnSelectedIndexChanged(e);
            this.SetSelectionValue();
        }

        protected override void OnSelectedItemChanged(EventArgs e)
        {
            base.OnSelectedItemChanged(e);
            this.SetSelectionValue();
        }

        protected override void OnSelectedValueChanged(EventArgs e)
        {
            base.OnSelectedValueChanged(e);
            this.SetSelectionValue();
        }


        protected void SetSelectionValue()
        {
            try
            {
                this.SelectionValue = ObjList[this.SelectedIndex].Value;
                this.SelectionText = ObjList[this.SelectedIndex].Text;
            }
            catch (Exception)
            {
                this.SelectionValue = null;
                this.SelectionText = string.Empty;
            }
        }


        public string SelectionText
        {
            get { return _text; }
            internal set { _text = value; }
        }


        /// <summary>
        /// Gets Value Of Selected Index;
        /// </summary>
        public object SelectionValue
        {
            get { return this._value; }
            internal set { this._value = value; }
        }

        /// <summary>
        /// Set Combobox İtems with given resource string and delimiter parameters.
        /// </summary>
        /// <param name="itemList">String Resource of ComboBox.</param>
        /// <param name="itemDelimiter">Key-Value Pairs delimiter char.</param>
        /// <param name="propDelimiter">Delimiter char between Key and Value.</param>
        public void SetItemSource(string itemList, char itemDelimiter, char propDelimiter)
        {
            if (AllExtensions.IsNullOrSpace(itemList) ||
                AllExtensions.IsNullOrEmpty(Char.ToString(itemDelimiter)) ||
                AllExtensions.IsNullOrEmpty(Char.ToString(propDelimiter)))
            {
                return;
            }
            else
            {
                try
                {
                    string[] itemsSrc = itemList.Split(itemDelimiter);
                    string[] strarr;
                    FreeObject _op;
                    foreach (string item in itemsSrc)
                    {
                        strarr = item.Split(propDelimiter);
                        if (strarr != null)
                        {
                            if (strarr.Length == 2)
                            {
                                _op = new FreeObject { Text = strarr[0], Value = strarr[1] };
                                ObjList.Add(_op);
                            }
                        }
                    }
                }
                catch (Exception)
                {
                    this.ObjList = new List<FreeObject>();
                }
                finally
                {
                    this.RefreshSource();
                    this.SelectedIndex = -1;
                }
            }
        }

        protected override void OnDataSourceChanged(EventArgs e)
        {
            int index = this.SelectedIndex;
            base.OnDataSourceChanged(e);
            this.RefreshSource();
            this.SelectedIndex = index;
        }

        private void RefreshSource()
        {
            this.DisplayMember = "Text";
            this.ValueMember = "Value";
            this.DataSource = ObjList;
        }


        public void BindDataSource(DataTable dt, string displayMember, string valueMember)
        {
            try
            {
                List<FreeObject> _list = new List<FreeObject>();
                FreeObject obj;
                foreach (DataRow rw in dt.Rows)
                {
                    obj = new FreeObject(AllExtensions.ToStr(rw[displayMember]), rw[valueMember]);
                    _list.Add(obj);
                }
                this.ObjList = _list;
                this.RefreshSource();
                this.SelectedIndex = -1;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void BindDataSource<T>(IList<T> list, string displayMember, string valueMember) where T : new()
        {
            List<FreeObject> _list = new List<FreeObject>();
            try
            {
                PropertyInfo textProp = typeof(T).GetProperty(displayMember);
                PropertyInfo valueProp = typeof(T).GetProperty(valueMember);
                FreeObject obj;
                foreach (T _t in list)
                {
                    obj = new FreeObject()
                    {
                        Text = AllExtensions.ToStr(textProp.GetValue(_t, null)),
                        Value = valueProp.GetValue(_t, null)
                    };
                    _list.Add(obj);
                }
                this.ObjList = _list;
                this.RefreshSource();
                this.SelectedIndex = -1;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void BindDataSource(Hashtable h)
        {
            List<FreeObject> list = new List<FreeObject>();
            try
            {
                IDictionaryEnumerator iDict = h.GetEnumerator();
                FreeObject obj;
                while (iDict.MoveNext())
                {
                    obj = new FreeObject(AllExtensions.ToStr(iDict.Key), iDict.Value);
                    list.Add(obj);
                }
                this.ObjList = list;
                this.RefreshSource();
                this.SelectedIndex = -1;
            }
            catch (Exception)
            {
                throw;
            }
        }


        public void ItemAdd(string text, object value)
        {
            try
            {
                int index = this.SelectedIndex;
                this.ObjList.Add(new FreeObject(text, value));
                this.RefreshSource();
                this.SelectedIndex = index;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Remove(string text)
        {
            try
            {
                int index = -1;
                for (int i = 0; i < ObjList.Count; i++)
                {
                    index = this.ObjList[i].Text.Equals(text) ? i : -1;

                    if (index != -1)
                        break;
                }

                if (index != -1)
                {
                    this.ObjList.RemoveAt(index);
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                this.RefreshSource();
                this.Refresh();
            }
        }

        public void Remove(int index)
        {
            try
            {
                this.ObjList.RemoveAt(index);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                this.RefreshSource();
                this.Refresh();
            }
        }
    }
}