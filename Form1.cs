using System;
using System.Windows.Forms;

namespace htmlInTextbox
{
    public partial class Form1 : Form
    {
        private const string Test1HtmlTag = "<b>{0}</b>";

        private const string Test2HtmlTag = "<p>{0}</p>";

        private const string Test3HtmlTag = "</br>";

        public Form1()
        {
            InitializeComponent();
        }

        private void ReplaceText(string text)
        {
            var startIndex = this.valueTextBox.SelectionStart;
            var selectedTextLength = this.valueTextBox.SelectionLength;
            var newText = string.Format(text, this.valueTextBox.SelectedText);
            this.valueTextBox.Text = this.valueTextBox.Text.Remove(startIndex, selectedTextLength);
            this.valueTextBox.Text = this.valueTextBox.Text.Insert(startIndex, newText);
            this.valueTextBox.SelectionStart = startIndex + newText.Length;
        }

        private void InsertText(string text)
        {
            var selectionStart = this.valueTextBox.SelectionStart;
            this.valueTextBox.Text = this.valueTextBox.Text.Insert(this.valueTextBox.SelectionStart, text);
            this.valueTextBox.SelectionStart = selectionStart + text.Length;
        }

        private void test1Button_Click(object sender, EventArgs e)
        {
            this.ReplaceText(Test1HtmlTag);
        }

        private void test2Button_Click(object sender, EventArgs e)
        {
            this.ReplaceText(Test2HtmlTag);
        }

        private void test3Button_Click(object sender, EventArgs e)
        {
            this.InsertText(Test3HtmlTag);
        }
    }
}
