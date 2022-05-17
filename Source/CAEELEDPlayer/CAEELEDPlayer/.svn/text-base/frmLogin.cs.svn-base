using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CAEELEDPlayer.Common;

namespace CAEELEDPlayer
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            txtManagePwd.Text = "123456";
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtManagePwd.Text == "123456")
            {
                Hide();
                FormControl fc = FormControl.CreateInstance();
                fc.ShowScreen(1);
                fc.ShowConsole();
            }else
            {
                MessageBox.Show("π‹¿Ì√‹¬Î¥ÌŒÛ£°", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}