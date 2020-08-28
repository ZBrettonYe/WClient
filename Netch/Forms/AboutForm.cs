using System;
using System.Diagnostics;
using System.Windows.Forms;
using Netch.Utils;

namespace Netch.Forms
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {
            Text = i18N.Translate(Text);
        }

        private void NetchPictureBox_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.otakuyun.net");
        }
    }
}
