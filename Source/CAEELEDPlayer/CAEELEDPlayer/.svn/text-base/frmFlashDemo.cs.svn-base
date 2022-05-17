using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Media;
using System.Text;
using System.Windows.Forms;

namespace CAEELEDPlayer
{
    public partial class frmFlashDemo : Form
    {
        public bool blFlag = false;
        public frmLEDScreen2 frmTemp;
        public int iCloseFlash = 0;

        public bool blSomeOne = false;
        public string MusicFilePath = string.Empty;

        Timer timerClose = new Timer();
        public frmFlashDemo(frmLEDScreen2 frm)
        {
            InitializeComponent();
            frmTemp = frm;
        }

        private void frmFlashDemo_Load(object sender, EventArgs e)
        {
            ShowFlash(blFlag);
            timerClose.Interval = iCloseFlash;
            timerClose.Enabled = true;
            timerClose.Tick += new EventHandler(timerClose_Tick);
        }

        void timerClose_Tick(object sender, EventArgs e)
        {
            timerClose.Enabled = false;
            this.Close();
        }

        private void ShowFlash(bool blStart)
        {
            this.Location = frmTemp.Location;
            this.Size = frmTemp.Size;
            this.BackColor = frmTemp.BackColor;
            string strFilePath = blStart
                                  ? string.Format("{0}\\flash\\BuyStart.swf", Application.StartupPath)
                                  : string.Format("{0}\\flash\\BuyEnd.swf", Application.StartupPath);

            if (!blFlag)
                PlayEndMusic(MusicFilePath, blSomeOne);

            PlayFlash(strFilePath);
        }
               
        private void PlayEndMusic(string strFileName, bool blSomeOne)
        {
            if (!System.IO.File.Exists(strFileName))
                return;
            if (strFileName == string.Empty)
                return;
            System.Media.SoundPlayer sP;
            if (blSomeOne)//有人竞拍
            {
                //如果设置了结束竞价时，有人竞拍为静音，则不播放声音
                if (frmTemp.blMusicSomeOneOpen)
                    return;
                sP = new SoundPlayer(strFileName);
                sP.Play();
            }
            else//无人竞拍
            {
                //如果设置了结束竞价时，无人竞拍为静音，则不播放声音
                if (frmTemp.blMusicNoOneOpen)
                    return;
                sP = new SoundPlayer(strFileName);
                sP.Play();
            }
        }

        private void PlayFlash(string strFileName)
        {
            axShockwaveFlash1.Movie = strFileName;
            axShockwaveFlash1.Menu = false;
            axShockwaveFlash1.Playing = true;
        }
    }
}