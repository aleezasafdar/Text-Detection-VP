﻿using System;
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
    public partial class Form_Language : Form
    {
        public Form_Language()
        {
            InitializeComponent();
        }

        private void Language_menu_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form_menu = new MainMenu();
            form_menu.Show();
        }
    }
}

