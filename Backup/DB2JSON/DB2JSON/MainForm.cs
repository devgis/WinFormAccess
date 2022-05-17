using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DB2JSON
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            string sql = "select * from projectinfo";
            DataTable dt = AccessHelper.GetDataTable(sql);
            sb.Append("1001[");
            if (dt != null && dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    sb.Append("{");
                    sb.AppendFormat("\"startTime\":\"{0}\",\"captureBalance\":\"{1}\",\"area\":\"{2}\",\"releasePrice\":\"{3}\",\"status\":\"{4}\",\"releaseRatio\":\"{5}\",\"property\":\"{6}\",\"code\":\"{7}\",\"projectName\":\"{8}\"",
                        DateTime.Now.ToString()
                        ,""
                        ,dt.Rows[i]["归属地"].ToString()
                        , dt.Rows[i]["挂牌价格"].ToString()
                        , dt.Rows[i]["交易状态"].ToString()
                        ,""
                        , dt.Rows[i]["产权类型"].ToString()
                        , dt.Rows[i]["项目编号"].ToString()
                        , dt.Rows[i]["项目名称"].ToString());
                    if (i != dt.Rows.Count - 1)
                    {
                        sb.Append("},");
                    }
                    else
                    {
                        sb.Append("}");
                    }
                }
            }
            sb.Append("]");
            tbJSON.Text = sb.ToString();
        }
    }
}
