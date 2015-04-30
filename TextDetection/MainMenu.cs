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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void MM_proceed_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form_change = new Text_identifier();
            form_change.Show();
        }

        private void MM_language_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form_language = new Form_Language();
            form_language.Show();

        }

        private void MM_help_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form_help = new MM_help();
            form_help.Show();

        }

       
    }
}
