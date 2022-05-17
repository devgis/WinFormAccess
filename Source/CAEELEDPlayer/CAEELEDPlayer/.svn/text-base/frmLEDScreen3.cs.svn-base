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
    public partial class frmLEDScreen3 : Form
    {
        private FormControl fc = FormControl.CreateInstance();
        private Point mouseOffset;

        public frmLEDScreen3()
        {
            InitializeComponent();
        }

        private void frmLEDScreen_MouseDown(object sender, MouseEventArgs e)
        {
            int xOffset,yOffset;

            if (e.Button == MouseButtons.Left)
            {
                Cursor = Cursors.SizeAll;
                xOffset =  -e.X;
                yOffset =  -e.Y;

                mouseOffset = new Point(xOffset, yOffset);
            }
        }

        private void frmLEDScreen_MouseMove(object sender, MouseEventArgs e)
        {
            if (Cursor == Cursors.SizeAll && !fc.CurrentScreen.TopMost)
            {
                Point mousePos = MousePosition;
                mousePos.Offset(mouseOffset.X, mouseOffset.Y);
                Location = mousePos;

                //label1.Text = "Location.X:" + Location.X;
                //label2.Text = "Location.Y:" + Location.Y;

                fc.FConsole.numericX.Value = Location.X;
                fc.FConsole.numericY.Value = Location.Y;
                fc.FConsole.numericH.Value = Height;
                fc.FConsole.numericW.Value = Width;
            }
        }

        private void frmLEDScreen_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Cursor = Cursors.Default;
            }
        }
    }
}