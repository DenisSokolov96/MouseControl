//1050; 590 location 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace MouseControl
{   
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();            
            windOutInfo.Text = " ";
            SetHook();
            SetHook2();
        }

        public static IntPtr hhook = IntPtr.Zero;
        public static IntPtr hhook2 = IntPtr.Zero;

        public void MoveCursor()
        {
           int X = Cursor.Position.X;
           int Y = Cursor.Position.Y;

           oXTextBox.Text = Cursor.Position.X.ToString();
           oYTextBox.Text = Cursor.Position.Y.ToString();
         

            Point p;
           if (WinAPI.GetCursorPos(out p))
           {
               IntPtr hWnd = WinAPI.WindowFromPoint(p);
             
              if (hWnd != IntPtr.Zero)
               {
                  int length = WinAPI.GetWindowTextLength(hWnd);
                  StringBuilder sb = new StringBuilder(length + 1);
                  WinAPI.GetWindowText(hWnd, sb, sb.Capacity);
                    windOutInfo.Text = sb.ToString();
                }               
            }


           WinAPI.UnhookWindowsHookEx(hhook);
           SetHook();

        }

        public void SetHook()
        {
            IntPtr hInstance = WinAPI.LoadLibrary("User32");     
            hhook = WinAPI.SetWindowsHookEx(WinAPI.WH_MOUSE_LL, hookProc, hInstance, 0);            
        }
        
        public IntPtr hookProc(int code, IntPtr wParam, IntPtr lParam)
        {        
            MoveCursor();            
            return WinAPI.CallNextHookEx(hhook, code, (int)wParam, lParam);
        }
        


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)//закрытие формы
        {
            // убираем хуки         
            WinAPI.UnhookWindowsHookEx(hhook);
            WinAPI2.UnhookWindowsHookEx(hhook2);
        }






        public static long k = 0;

        public void myfunc(char s)
        {

            k++;
            if ((int)s == 8) { symbolOutWind.Text = "Backspace!"; outSymbolsOnScreen.Text += " "; }
            else
            {
                symbolOutWind.Text = (s).ToString();
                outSymbolsOnScreen.Text += symbolOutWind.Text;
                allSymbol.Text = k.ToString();
                allSymbol.Text = k.ToString();
                allSymbol.Text = k.ToString();
            }

            if (k % 30 == 0)
            {
                outSymbolsOnScreen.Text = "";
            }
            WinAPI2.UnhookWindowsHookEx(hhook2);
            SetHook2();

        }
        public void SetHook2()
        {
            IntPtr hInstance = WinAPI2.LoadLibrary("User32");
            hhook2 = WinAPI2.SetWindowsHookEx(WinAPI2.WH_KEYBOARD_LL, hookProc2, hInstance, 0);
        }
        public IntPtr hookProc2(int code, IntPtr wParam, IntPtr lParam)//клава
        {
            if (code >= 0 && wParam == (IntPtr)WinAPI2.WM_KEYDOWN)
            {

                int vkCode = Marshal.ReadInt32(lParam);
                char simvol = (char)vkCode;
                myfunc(simvol);

            }
            return WinAPI2.CallNextHookEx(hhook2, code, (int)wParam, lParam);
        }

    }

    public static class WinAPI
    {
        [DllImport("user32.dll")]//повесить хук
        public static extern IntPtr SetWindowsHookEx(int idHook, LowLevelMouseProc callback, IntPtr hInstance, uint threadId);

        [DllImport("user32.dll")]//загрузка функции для удаления хука
        public static extern bool UnhookWindowsHookEx(IntPtr hInstance); // отмена хук

        [DllImport("user32.dll")]//загрузить и повесить следующий хук
        public static extern IntPtr CallNextHookEx(IntPtr idHook, int nCode, int wParam, IntPtr lParam);

        [DllImport("kernel32.dll")]
        public static extern IntPtr LoadLibrary(string lpFileName);


        public delegate IntPtr LowLevelMouseProc(int nCode, IntPtr wParam, IntPtr lParam);


        public const int WH_MOUSE_LL = 14;   // Номер глобального LowLevel-хука на клавиатуру 
               


        [DllImport("user32.dll")]
        public static extern IntPtr WindowFromPoint(System.Drawing.Point p);

        [DllImport("user32.dll")]
        public static extern bool GetCursorPos(out Point lpPoint);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int GetWindowTextLength(IntPtr hWnd);
    }
    public static class WinAPI2
    {
        [DllImport("user32.dll")]//повесить хук
        public static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc callback, IntPtr hInstance, uint threadId);

        [DllImport("user32.dll")]//загрузка функции для удаления хука
        public static extern bool UnhookWindowsHookEx(IntPtr hInstance); // отмена хук

        [DllImport("user32.dll")]//загрузить и повесить следующий хук
        public static extern IntPtr CallNextHookEx(IntPtr idHook, int nCode, int wParam, IntPtr lParam);

        [DllImport("kernel32.dll")]
        public static extern IntPtr LoadLibrary(string lpFileName);

        public delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

        public const int WH_KEYBOARD_LL = 13; // Номер глобального LowLevel-хука на клавиатуру      
        public const int WM_KEYDOWN = 0x100;// Сообщения нажатия клавиши
  
    }
}
