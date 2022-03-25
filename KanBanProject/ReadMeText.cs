using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KanBanProject
{
    public partial class ReadMeText : Form
    {
        public ReadMeText()
        {
            InitializeComponent();
        }

        // Tıklandığında eklenen internet sayfaları çılmaktadır.       

        private void lblMustafa_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/m-yilmaz");
        }

        private void lblFurkan_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/FurkanErciyas");
        }

        private void lblAhmet_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/ahmetsarikaya0696");
        }
    }
}
