using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Drawing;

namespace CAEELEDPlayer.ExControls
{
    public class MyColorDialog : ColorDialog
    {
        [DllImport("user32")]
        public static extern long SetWindowPos(IntPtr hwnd, IntPtr hWndInsertAfter, int x, int y, int cx, int cy, int uFlags);

        Rectangle Rect;

        /// <summary>
        /// 实例化窗体，高度和宽度为0的话，则表示使用系统默认的宽高
        /// </summary>
        /// <param name="x">X坐标</param>
        /// <param name="y">Y坐标</param>
        /// <param name="weight">宽度</param>
        /// <param name="height">高度</param>
        public MyColorDialog(int x, int y, int weight, int height)
        {
            Rect = new Rectangle(x, y, weight, height);
        }

        public void SetLocation(IntPtr hWnd)
        {

            if (Rect.Width == 0 || Rect.Height == 0)
            {
                SetWindowPos(hWnd, (IntPtr)0, Rect.X, Rect.Y, Rect.Width, Rect.Height,
                             0x0001 | // SWP_NOSIZE
                             0x0004 | // SWP_NOZORDER
                             0x0010 // SWP_NOACTIVATE
                    );
            }
            else
            {
                SetWindowPos(hWnd, (IntPtr)0, Rect.X, Rect.Y, Rect.Width, Rect.Height, 0);
            }


        }

        //指定为将特定功能添加到通用对话框而重写的通用对话框挂钩程序。 showDialog时会调用这个方法进行通信
        [System.Security.Permissions.PermissionSet(System.Security.Permissions.SecurityAction.Demand, Name = "FullTrust")]
        protected override IntPtr HookProc(IntPtr hWnd, int msg, IntPtr wparam, IntPtr lparam)
        {
            IntPtr returnValue = base.HookProc(hWnd, msg, wparam, lparam);

            //0x110表示窗口已被激活
            if (msg == 0x0110)
            {
                SetLocation(hWnd);
            }

            return returnValue;
        }

    }
}
