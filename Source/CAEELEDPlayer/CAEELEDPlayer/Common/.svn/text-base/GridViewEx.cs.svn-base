using System; 
using System.Collections.Generic; 
using System.Text; 
using System.Windows.Forms; 
using System.Drawing;
using System.Collections;

namespace CAEELEDPlayer.Common
{
    public class GridViewEx
    {
        #region 合并列时使用到的位置和大小属性
        static int cTop = 0;//被合并表头区域的顶部坐标 
        static int cLeft = 0;//被合并表头区域的左边坐标 
        /// <summary> 
        /// 被合并表头区域的宽 
        /// </summary> 
        static int cWidth = 0;
        static int cHeight = 0;//。。。高 
        #endregion
        /// <summary> 
        /// 判断是否已经将datagridview的表头变高了，只增高一次。 
        /// </summary> 
        public static bool isEnLarged = false;

        /// <summary> 
        /// 合并表头,用在dataGridView的CellPainting事件中。 只支持单层表头合并，不支持多重表头
        /// </summary> 
        /// <param name="sender">需要重绘的dataGridview</param> 
        /// <param name="e">CellPainting中的参数</param> 
        ///<param name="colName">列的集合(列必须是连续的，第一列放在最前面)</param> 
        /// <param name="headerText">列合并后显示的文本</param> 
        public static void MergeHeader(object sender, DataGridViewCellPaintingEventArgs e, DataGridViewColumnCollection Columns, string headerText)
        {
            if (e.RowIndex == -1)
            {
                DataGridView grid = sender as DataGridView;
                string colName = grid.Columns[e.ColumnIndex].Name;
                if (!isEnLarged)
                {
                    //0.扩展表头高度为当前的2倍 
                    grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
                    grid.ColumnHeadersHeight = e.CellBounds.Height * 2;
                    isEnLarged = true;
                }
                if (Columns.Contains(colName))
                {
                    #region 重绘列头
                    //1.计算colLen个列的区域 
                    if (Columns.IndexOf(grid.Columns[colName]) == 0)
                    {
                        cTop = e.CellBounds.Top;
                        cLeft = e.CellBounds.Left;

                        cWidth = e.CellBounds.Width;
                        cHeight = e.CellBounds.Height / 2;

                        foreach (DataGridViewColumn item in Columns)
                        {
                            if (item.Equals(grid.Columns[colName]))
                            {//除去自己一个，加了之后colLen-1个列的宽 
                                continue;
                            }
                            cWidth += item.Width;
                        }
                    }

                    Rectangle cArea = new Rectangle(cLeft, cTop, cWidth, cHeight);
                    //2.把区域设置为背景色，没有列的分线及任何文字。 
                    using (Brush backColorBrush = new SolidBrush(e.CellStyle.BackColor))
                    {
                        e.Graphics.FillRectangle(backColorBrush, cArea);

                    }
                    //3.绘制新列头的边框 
                    using (Pen gridPen = new Pen(grid.GridColor))
                    {
                        //3.1 上部边框 
                        e.Graphics.DrawLine(gridPen, cLeft, cTop, cLeft + cWidth, cTop);
                        using (Pen hilightPen = new Pen(Color.WhiteSmoke))
                        {
                            //3.2 顶部高光 
                            e.Graphics.DrawLine(hilightPen, cLeft, cTop + 1, cLeft + cWidth, cTop + 1);
                            //3.3 左部反光线 
                            e.Graphics.DrawLine(hilightPen, cLeft, cTop + 3, cLeft, cTop + cHeight - 2);
                        }
                        //3.4 下部边框 
                        e.Graphics.DrawLine(gridPen, cLeft, cTop + cHeight - 1, cLeft + cWidth, cTop + cHeight - 1);
                        //3.5 右部边框                         
                        e.Graphics.DrawLine(gridPen, cLeft + cWidth - 1, cTop, cLeft + cWidth - 1, cTop + cHeight);//(cTop+cHeight)/2); 
                    }
                    //4.写文本 
                    if (Columns.IndexOf(grid.Columns[colName]) == 0)
                    {//不是第一列则不写文字。 
                        int wHeadStr = (int)(headerText.Length * e.CellStyle.Font.SizeInPoints);
                        int wHeadCell = cWidth;
                        int pHeadLeft = (wHeadCell - wHeadStr) / 2 - 6;
                        using (Brush foreBrush = new SolidBrush(e.CellStyle.ForeColor))
                        {
                            e.Graphics.DrawString(headerText, e.CellStyle.Font, foreBrush, new PointF(cLeft + pHeadLeft, cTop + 3));
                        }
                    }


                    //5 绘制子列背景 
                    int FatherColHeight = e.CellBounds.Height / 2;//上面一行的高度  
                    using (Brush backColorBrush = new SolidBrush(e.CellStyle.BackColor))
                    {
                        e.Graphics.FillRectangle(backColorBrush, new Rectangle(e.CellBounds.X, e.CellBounds.Y + FatherColHeight, e.CellBounds.Width - 1, e.CellBounds.Height / 2 - 1));
                    }
                    //5.1绘制子列的边框                    
                    using (Pen gridPen = new Pen(grid.GridColor))
                    {
                        using (Pen hilightPen = new Pen(Color.WhiteSmoke))
                        {
                            //5.2 左部反光线 
                            e.Graphics.DrawLine(hilightPen, cLeft, cTop + 3 + FatherColHeight, cLeft, cTop + cHeight - 2 + FatherColHeight);
                        }
                        //5.3 下部边框 
                        e.Graphics.DrawLine(gridPen, cLeft, cTop + cHeight - 1 + FatherColHeight, cLeft + cWidth, cTop + cHeight - 1 + FatherColHeight);

                        //5.4 右部边框  
                        e.Graphics.DrawLine(gridPen, e.CellBounds.X + e.CellBounds.Width - 1, e.CellBounds.Top + FatherColHeight, e.CellBounds.X + e.CellBounds.Width - 1, e.CellBounds.Top + e.CellBounds.Height + FatherColHeight);//(cTop+cHeight)/2);                     

                    }
                    //5.5 写子列的文本 
                    int wStr = (int)(grid.Columns[e.ColumnIndex].HeaderText.Length * e.CellStyle.Font.SizeInPoints);
                    int wCell = e.CellBounds.Width;
                    int pLeft = (wCell - wStr) / 2;//相对CELL左边框的左坐标 

                    using (Brush foreBrush = new SolidBrush(e.CellStyle.ForeColor))
                    {
                        e.Graphics.DrawString(grid.Columns[e.ColumnIndex].HeaderText, e.CellStyle.Font, foreBrush, new PointF(e.CellBounds.X + pLeft, cTop + 3 + FatherColHeight));
                    }
                    #endregion
                    e.Handled = true;
                }
            }
        }


        private static SortedList rowSpan = new SortedList();//取得需要重新绘制的单元格
        private static string rowValue = "";//重新绘制的文本框内容

        #region  单元格绘制
        /// <summary>
        /// DataGridView合并单元格(横向)
        /// </summary>
        /// <param name="dgv">绘制的DataGridview </param>
        /// <param name="cellArgs">绘制单元格的参数（DataGridview的CellPainting事件中参数）</param>
        /// <param name="minColIndex">起始单元格在DataGridView中的索引号</param>
        /// <param name="maxColIndex">结束单元格在DataGridView中的索引号</param>
        public static void MerageRowSpan(DataGridView dgv, DataGridViewCellPaintingEventArgs cellArgs, int minColIndex, int maxColIndex)
        {
            if (cellArgs.ColumnIndex < minColIndex || cellArgs.ColumnIndex > maxColIndex) return;

            Rectangle rect = new Rectangle();
            using (Brush gridBrush = new SolidBrush(dgv.GridColor),
                backColorBrush = new SolidBrush(cellArgs.CellStyle.BackColor))
            {
                //抹去原来的cell背景
                cellArgs.Graphics.FillRectangle(backColorBrush, cellArgs.CellBounds);
            }
            cellArgs.Handled = true;

            if (rowSpan[cellArgs.ColumnIndex] == null)
            {
                //首先判断当前单元格是不是需要重绘的单元格
                //保留此单元格的信息，并抹去此单元格的背景
                rect.X = cellArgs.CellBounds.X;
                rect.Y = cellArgs.CellBounds.Y;
                rect.Width = cellArgs.CellBounds.Width;
                rect.Height = cellArgs.CellBounds.Height;

                rowValue += cellArgs.Value ?? string.Empty;
                rowSpan.Add(cellArgs.ColumnIndex, rect);
                if (cellArgs.ColumnIndex != maxColIndex)
                    return;
                MeragePrint(dgv, cellArgs, minColIndex, maxColIndex);
            }
            else
            {
                IsPostMerage(dgv, cellArgs, minColIndex, maxColIndex);
            }
        }

        /// <summary>
        /// 不是初次单元格绘制
        /// </summary>
        /// <param name="dgv"></param>
        /// <param name="cellArgs"></param>
        /// <param name="minColIndex"></param>
        /// <param name="maxColIndex"></param>
        public static void IsPostMerage(DataGridView dgv, DataGridViewCellPaintingEventArgs cellArgs, int minColIndex, int maxColIndex)
        {
            //比较单元是否有变化
            Rectangle rectArgs = (Rectangle)rowSpan[cellArgs.ColumnIndex];
            if (rectArgs.X != cellArgs.CellBounds.X || rectArgs.Y != cellArgs.CellBounds.Y
                || rectArgs.Width != cellArgs.CellBounds.Width || rectArgs.Height != cellArgs.CellBounds.Height)
            {
                rectArgs.X = cellArgs.CellBounds.X;
                rectArgs.Y = cellArgs.CellBounds.Y;
                rectArgs.Width = cellArgs.CellBounds.Width;
                rectArgs.Height = cellArgs.CellBounds.Height;
                rowSpan[cellArgs.ColumnIndex] = rectArgs;
            }
            MeragePrint(dgv, cellArgs, minColIndex, maxColIndex);

        }

        //画制单元格
        private static void MeragePrint(DataGridView dgv, DataGridViewCellPaintingEventArgs cellArgs, int minColIndex, int maxColIndex)
        {

            int width = 0;//合并后单元格总宽度
            int height = cellArgs.CellBounds.Height;//合并后单元格总高度

            for (int i = minColIndex; i <= maxColIndex; i++)
            {
                width += ((Rectangle)rowSpan[i]).Width;
            }

            Rectangle rectBegin = (Rectangle)rowSpan[minColIndex];//合并第一个单元格的位置信息
            Rectangle rectEnd = (Rectangle)rowSpan[maxColIndex];//合并最后一个单元格的位置信息

            //合并单元格的位置信息
            Rectangle reBounds = new Rectangle();
            reBounds.X = rectBegin.X;
            reBounds.Y = rectBegin.Y;
            reBounds.Width = width - 1;
            reBounds.Height = height - 1;


            using (Brush gridBrush = new SolidBrush(dgv.GridColor),
                         backColorBrush = new SolidBrush(cellArgs.CellStyle.BackColor))
            {
                using (Pen gridLinePen = new Pen(gridBrush))
                {
                    // 画出上下两条边线，左右边线无
                    Point blPoint = new Point(rectBegin.Left, rectBegin.Bottom - 1);//底线左边位置
                    Point brPoint = new Point(rectEnd.Right - 1, rectEnd.Bottom - 1);//底线右边位置
                    cellArgs.Graphics.DrawLine(gridLinePen, blPoint, brPoint);//下边线 

                    Point tlPoint = new Point(rectBegin.Left, rectBegin.Top);//上边线左边位置
                    Point trPoint = new Point(rectEnd.Right - 1, rectEnd.Top);//上边线右边位置
                    cellArgs.Graphics.DrawLine(gridLinePen, tlPoint, trPoint); //上边线

                    Point ltPoint = new Point(rectBegin.Left, rectBegin.Top);//左边线顶部位置
                    Point lbPoint = new Point(rectBegin.Left, rectBegin.Bottom - 1);//左边线底部位置
                    cellArgs.Graphics.DrawLine(gridLinePen, ltPoint, lbPoint); //左边线

                    Point rtPoint = new Point(rectEnd.Right - 1, rectEnd.Top);//右边线顶部位置
                    Point rbPoint = new Point(rectEnd.Right - 1, rectEnd.Bottom - 1);//右边线底部位置
                    cellArgs.Graphics.DrawLine(gridLinePen, rtPoint, rbPoint); //右边线

                    //计算绘制字符串的位置
                    SizeF sf = cellArgs.Graphics.MeasureString(rowValue, cellArgs.CellStyle.Font);
                    float lstr = (width - sf.Width) / 2;
                    float rstr = (height - sf.Height) / 2;

                    //画出文本框
                    if (rowValue != "")
                    {
                        cellArgs.Graphics.DrawString(rowValue, cellArgs.CellStyle.Font,
                                                   new SolidBrush(cellArgs.CellStyle.ForeColor),
                                                     rectBegin.Left + lstr,
                                                     rectBegin.Top + rstr,
                                                     StringFormat.GenericDefault);
                    }
                }
                cellArgs.Handled = true;
            }
        }

        /// <summary>
        /// DataGridView合并单元格(纵向)
        /// </summary>
        /// <param name="dgv">绘制的DataGridview </param>
        /// <param name="cellArgs">绘制单元格的参数（DataGridview的CellPainting事件中参数）</param>
        /// <param name="minColIndex">起始单元格在DataGridView中的索引号</param>
        /// <param name="maxColIndex">结束单元格在DataGridView中的索引号</param>
        public static void MerageColSpan(DataGridView dgv, DataGridViewColumn col, DataGridViewCellPaintingEventArgs cellArgs, int minRowIndex, int maxRowIndex)
        {
            if (col.Index != cellArgs.ColumnIndex) return;
            if (cellArgs.RowIndex < minRowIndex || cellArgs.RowIndex > maxRowIndex) return;

            Rectangle rect = new Rectangle();
            using (Brush gridBrush = new SolidBrush(dgv.GridColor),
                backColorBrush = new SolidBrush(cellArgs.CellStyle.BackColor))
            {
                //抹去原来的cell背景
                cellArgs.Graphics.FillRectangle(backColorBrush, cellArgs.CellBounds);
            }
            cellArgs.Handled = true;

            if (rowSpan[cellArgs.ColumnIndex] == null)
            {
                //首先判断当前单元格是不是需要重绘的单元格
                //保留此单元格的信息，并抹去此单元格的背景
                rect.X = cellArgs.CellBounds.X;
                rect.Y = cellArgs.CellBounds.Y;
                rect.Width = cellArgs.CellBounds.Width;
                rect.Height = cellArgs.CellBounds.Height;

                rowValue += cellArgs.Value.ToString();
                rowSpan.Add(cellArgs.RowIndex, rect);
                if (cellArgs.RowIndex != maxRowIndex)
                    return;
                MeragePrint(dgv, cellArgs, minRowIndex, maxRowIndex);
            }
            else
            {
                IsPostMerage(dgv, cellArgs, minRowIndex, maxRowIndex);
            }
        }

        #endregion
    }
}