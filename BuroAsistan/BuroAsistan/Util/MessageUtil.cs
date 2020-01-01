using System.Windows.Forms;

namespace BuroAsistan.Util
{
    internal class MessageUtil
    {
        internal static void Error(string message, string caption)
        {
            MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        internal static void Message(string message, string caption)
        {
            MessageBox.Show(message, caption);
        }

        internal static void Info(string message, string caption)
        {
            MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        internal static void Warn(string message, string caption)
        {
            MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        internal static DialogResult ConfirmYesNo(string message, string caption)
        {
            return MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        internal static DialogResult ConfirmYesNoCancel(string message, string caption)
        {
            return MessageBox.Show(message, caption, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
        }
    }
}