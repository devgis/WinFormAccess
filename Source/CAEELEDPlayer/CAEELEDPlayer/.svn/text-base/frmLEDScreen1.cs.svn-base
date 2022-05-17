using System;
using System.Collections;
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
    public partial class frmLEDScreen1 : Form
    {
        public enum TableBorderType
        {
            None,
            FixedSingle,
            FixedDouble,
        }

        private TableBorderType _TableBorderType;
        private int _TableBorderSize;
        private FormControl fc = FormControl.CreateInstance();
        private Point mouseOffset;
        private static int _pageSize = 10;
        private int _rowHeight;
        private int _pageIndex = 1;
        private int _pageCount;
        private int _recordCount;
        public Timer timer = new Timer();
        public Timer timerSyn = new Timer();
        public int DataFlag = 0; //0为显示全部数据源，1为显示更新过的数据源
        
        private static readonly object lockHelper = new object();

        private static List<ProjectInfo> tempList= new List<ProjectInfo>();

        public int RowHeight
        {
            get { return _rowHeight; }
            set { _rowHeight = value; }
        }

        public int PageSize
        {
            get { return _pageSize; }
            set { _pageSize = value; }
        }

        public frmLEDScreen1()
        {

            InitializeComponent();
            //启动时进行数据同步
            if (tempList == null)
            {
                tempList = Screen1Data.GetProjectInfo();
            }
            
            bindDate();
            timer.Enabled = true;
            timer.Interval = 1000;
            timer.Tick += new EventHandler(timer_Tick);

            //timerSyn.Enabled = true;
            //timerSyn.Interval = 300*1000;
            //timerSyn.Tick += new EventHandler(timerSyn_Tick);
            RowHeight = GridViewDate.ColumnHeadersHeight;
            GridViewDate.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            GridViewDate.EnableHeadersVisualStyles = false;
        }

        /// <summary>
        /// 双线边框距离
        /// </summary>
        public int TableBorderSize
        {
            set { _TableBorderSize = value;
                TableBorderStyle = TableBorderStyle;
            }
            get { return _TableBorderSize; }
        }

        /// <summary>
        /// 边框样式
        /// </summary>
        public TableBorderType TableBorderStyle
        {
            set
            {
                switch(value)
                {
                    case TableBorderType.None:
                        GridViewDate.Dock = DockStyle.Fill;
                        GridViewDate.BorderStyle = BorderStyle.None;
                        panelContent.BorderStyle = BorderStyle.None;
                        break;
                    case TableBorderType.FixedSingle:
                        GridViewDate.Dock = DockStyle.Fill;
                        GridViewDate.BorderStyle = BorderStyle.None;
                        panelContent.BorderStyle = BorderStyle.FixedSingle;
                        panelContent.BorderColor = GridViewDate.GridColor;
                        break;
                    case TableBorderType.FixedDouble:
                        GridViewDate.Dock = DockStyle.None;
                        GridViewDate.BorderStyle = BorderStyle.None;
                        panelContent.BorderStyle = BorderStyle.FixedSingle;
                        panelContent.BorderColor = GridViewDate.GridColor;

                        GridViewDate.Width = panelContent.Width - (TableBorderSize * 2);
                        GridViewDate.Height = panelContent.Height - (TableBorderSize * 2);

                        GridViewDate.Location = new Point(TableBorderSize - 1, TableBorderSize - 1);
                        break;
                }
                _TableBorderType = value;
            }
            get { return _TableBorderType; }
        }

        private void timerSyn_Tick(object sender, EventArgs e)
        {
            tempList = null;
            if (tempList == null)
            {
                tempList = Screen1Data.GetProjectInfo();
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lock (lockHelper)
            {
                ListData();
            }
        }
        
        public void ListData()
        {
            if (_pageIndex < _pageCount)
            {
                _pageIndex++;
            }
            else
            {
                _pageIndex = 1;
            }

            GridViewDate.DataSource = GetListPage(tempList, _pageSize, _pageIndex, ref _pageCount, ref _recordCount);
            GridViewDate.ClearSelection();
            SetRowHeight();
        }

        public void SetRowHeight()
        {
            if (fc.FScreen1 == null) return;
            if (fc.FScreen1.GridViewDate.Rows.Count <= 0) return;
            foreach (DataGridViewRow row in fc.FScreen1.GridViewDate.Rows)
            {
                row.Height = RowHeight;
                row.Selected = false;
            }
            fc.FScreen1.panelTitle.Focus();
        }

        /// <summary>
        /// 列表分页
        /// </summary>
        /// <param name="list"></param>
        /// <param name="ps">每页行数</param>
        /// <param name="pi">当前页</param>
        /// <param name="pc">页数</param>
        /// <param name="rc">记录数</param>
        /// <returns></returns>
        public static List<ProjectInfo> GetListPage(List<ProjectInfo> list, int ps, int pi, ref int pc, ref int rc)
        {
            if (list==null)
            {
                return new List<ProjectInfo>();
            }
            rc = list.Count;
            pc = rc > ps
                     ? ((rc%ps > 0) ? (rc/ps) + 1 : (rc/ps))
                     : 1;

            List<ProjectInfo> retds = new List<ProjectInfo>();

            int firstRow = (pi > 0 ? pi - 1 : pi)*ps;

            for (int i = firstRow; i < firstRow + ps; i++)
            {
                if (i < rc)
                    retds.Add(list[i]);
            }
            while (retds.Count < _pageSize)
            {
                retds.Add(new ProjectInfo());
            }
            return retds;
        }

        private void bindDate()
        {
            GridViewDate.AutoGenerateColumns = false; 
            tempList = Screen1Data.GetProjectInfo();
            GridViewDate.DataSource = GetListPage(tempList, _pageSize, _pageIndex, ref _pageCount, ref _recordCount);
            GridViewDate.ClearSelection();
            SetRowHeight();
        }

        private void frmLEDScreen_MouseDown(object sender, MouseEventArgs e)
        {
            int xOffset,yOffset;

            if (e.Button != MouseButtons.Left) return;
            Cursor = Cursors.SizeAll;
            if (sender is Label)
            {
                xOffset = -(e.X + (Width - lblTitle.Width) / 2);
                yOffset = -(e.Y + (lblTitle.Parent.Height - lblTitle.Height) / 2);
                
            }
            else
            {
                xOffset = -e.X;
                yOffset = -e.Y;
            }

            mouseOffset = new Point(xOffset, yOffset);
        }

        private void frmLEDScreen_MouseMove(object sender, MouseEventArgs e)
        {
            if (Cursor != Cursors.SizeAll || fc.CurrentScreen.TopMost) return;
            Point mousePos = MousePosition;
            mousePos.Offset(mouseOffset.X, mouseOffset.Y);
            Location = mousePos;

            fc.FConsole.numericX.Value = Location.X;
            fc.FConsole.numericY.Value = Location.Y;
            fc.FConsole.numericH.Value = Height;
            fc.FConsole.numericW.Value = Width;
        }

        private void frmLEDScreen_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Cursor = Cursors.Default;
            }
        }

        private void panelTitle_SizeChanged(object sender, EventArgs e)
        {
            TableBorderSize = TableBorderSize;
            if (((Panel)sender).Name.Equals(lblTitle.Name))
            {
                lblTitle.Location = new Point((panelTitle.Location.X + panelTitle.Width - lblTitle.Width)/2,
                                              (panelTitle.Location.Y + panelTitle.Height - lblTitle.Height)/2);
            }

        }
        private void GridViewDate_SizeChanged(object sender, EventArgs e)
        {
            if (fc.FSetting == null) return;
            if (fc.FSetting.tabSettings.TabPages["tabScreen1"] == null) return;
            Control[] numColumnWidths = fc.FSetting.tabSettings.TabPages["tabScreen1"].Controls.Find("numColumnWidth", false);
            foreach (NumericUpDown num in numColumnWidths)
            {
                num.Value = GridViewDate.Columns[num.Tag.ToString()].Width;
            }
        }

        private void CurrentTime_timer_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            lbl_CurrentTime.Text = string.Format("{0}年{1}月{2}日 {3} {4:T}", dt.Year, dt.Month, dt.Day,
                                                 CommFunction.GetWeekOfDay(dt), dt);
        }

        public void AddData(List<ProjectInfo> modelist)
        {
            if (tempList == null)
            {
                tempList = Screen1Data.GetProjectInfo();
            }
            
            if (modelist == null || modelist.Count <=0)
                return;
            
            lock(lockHelper)
            {
                tempList.AddRange(modelist);
            }
        }
    }
}