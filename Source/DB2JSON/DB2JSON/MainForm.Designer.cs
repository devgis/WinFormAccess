﻿namespace DB2JSON
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tbJSON = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbJSON
            // 
            this.tbJSON.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbJSON.Location = new System.Drawing.Point(0, 0);
            this.tbJSON.Multiline = true;
            this.tbJSON.Name = "tbJSON";
            this.tbJSON.ReadOnly = true;
            this.tbJSON.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbJSON.Size = new System.Drawing.Size(985, 261);
            this.tbJSON.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 261);
            this.Controls.Add(this.tbJSON);
            this.Name = "MainForm";
            this.Text = "JSON转换工具";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbJSON;
    }
}

