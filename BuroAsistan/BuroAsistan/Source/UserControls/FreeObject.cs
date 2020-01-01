namespace BuroAsistan.Source.UserControls
{

    #region [ FreeObject struct ]

    /// <summary>
    /// Description of FreeObject.
    /// </summary>
    internal struct FreeObject
    {
        private string _Text;
        private object _Value;

        public FreeObject(string text, object value)
        {
            _Text = text;
            _Value = value;
        }

        public object Value
        {
            get { return _Value; }
            set { _Value = value; }
        }

        public string Text
        {
            get { return _Text; }
            set { _Text = value; }
        }
    }

    #endregion

}
