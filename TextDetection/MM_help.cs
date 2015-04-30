using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextDetection
{
    public partial class MM_help : Form
    {
        public MM_help()
        {
            InitializeComponent();
        }

        private void Help_menu_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form_menu = new MainMenu();
            form_menu.Show();

        }
    }
}
