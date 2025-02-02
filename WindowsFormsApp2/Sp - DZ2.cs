using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

        // Константы для сообщений
        private const uint WM_SETTEXT = 0x000C;
        private const uint WM_CLOSE = 0x0010;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtChange_Click(object sender, EventArgs e)
        {
            string windowTitle = txtWindowTitle.Text;
            string newTitle = txtNewTitle.Text;

            // Поиск окна по заголовку
            IntPtr hWnd = FindWindow(null, windowTitle);

            if (hWnd != IntPtr.Zero)
            {
                // Отправка сообщения для изменения заголовка
                SendMessage(hWnd, WM_SETTEXT, IntPtr.Zero, Marshal.StringToHGlobalUni(newTitle));
                MessageBox.Show("Заголовок окна изменен.");
            }
            else
            {
                MessageBox.Show("Окно не найдено.");
            }
        }

        private void BtClose_Click(object sender, EventArgs e)
        {
            string windowTitle = txtWindowTitle.Text;

            // Поиск окна по заголовку
            IntPtr hWnd = FindWindow(null, windowTitle);

            if (hWnd != IntPtr.Zero)
            {
                // Отправка сообщения для закрытия окна
                SendMessage(hWnd, WM_CLOSE, IntPtr.Zero, IntPtr.Zero);
                MessageBox.Show("Окно закрыто.");
            }
            else
            {
                MessageBox.Show("Окно не найдено.");
            }
        }
    }

    }
