using System;
using System.Windows.Forms;

using Sulakore.Components;

namespace Tanji.Dialogs
{
    public partial class TanjiConstructerEdit : Form
    {
        private readonly SKoreConstructer _hmConstructer;

        public TanjiConstructerEdit(SKoreConstructer hmConstructer)
        {
            InitializeComponent();

            _hmConstructer = hmConstructer;

            TypeTxt.Text = _hmConstructer.SelectedItems[0].SubItems[0].Text;
            ValueTxt.Text = _hmConstructer.SelectedItems[0].SubItems[1].Text;
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            switch (TypeTxt.Text)
            {
                case "String": _hmConstructer.ReplaceSelected(ValueTxt.Text); break;
                case "Integer": _hmConstructer.ReplaceSelected(int.Parse(ValueTxt.Text)); break;
                case "Boolean": _hmConstructer.ReplaceSelected((!string.IsNullOrEmpty(ValueTxt.Text) && (ValueTxt.Text[0] == 't' || ValueTxt.Text[0] == '1'))); break;
            }
            Close();
        }
    }
}