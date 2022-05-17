using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CAEELEDPlayer.Common;
using CAEELEDPlayer.Common.Model;

namespace CAEELEDPlayer
{
    public partial class frmChooseBuy : Form
    {
        private FormControl fc = FormControl.CreateInstance();
        List<ProjectShowInfo> tempPrjList = new List<ProjectShowInfo>();
        string strCode = string.Empty;
        
        public frmChooseBuy()
        {
            InitializeComponent();
            int x = Screen.PrimaryScreen.WorkingArea.Size.Width - Width;
            int y = Screen.PrimaryScreen.WorkingArea.Size.Height - Height;
            SetDesktopLocation(x, y);
            DgvChooseBuy.AutoGenerateColumns = false;
            tempPrjList = Screen2Data.GetProjectShowInfo();
            DgvChooseBuy.DataSource = tempPrjList;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmChooseBuy_Load(object sender, EventArgs e)
        {
            
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            ChooseProject();
        }
        
        private void ChooseProject()
        {
            if (DgvChooseBuy.Rows.Count <=0) return;
            
            strCode = string.Empty;

            tempPrjList = Screen2Data.GetProjectShowInfo();
            
            if (tempPrjList.Count <=0) return;

            DataGridViewSelectedRowCollection rc = DgvChooseBuy.SelectedRows;

            if (rc == null)
            {
                MessageBox.Show("请至少选择一个项目！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (rc != null && rc.Count > 1)
            {
                MessageBox.Show("不能选择多个项目！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (rc != null && rc.Count == 1)
            {
                strCode = rc[0].Cells["code"].Value.ToString();
                tempPrjList = tempPrjList.FindAll(FindList);
                fc.FScreen2.blChoose = true;
                fc.FScreen2.blListDetail = false;
                //fc.FScreen2.ListBuyBaseInfo(tempPrjList.Count > 0 ? tempPrjList[0] : null);
            }
        }
        
        private bool FindList(ProjectShowInfo prj)
        {
            if (prj.code == strCode)
                return true;
            return false;
        }

        private void DgvChooseBuy_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ChooseProject();
        }
    }
}