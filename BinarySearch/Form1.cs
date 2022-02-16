using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinarySearch
{
    public partial class MyForm : Form
    {
        int[] array = new int[30];
        Button[] buttons = new Button[30];

        public MyForm()
        {
            InitializeComponent();
        }

        private void MyForm_Load(object sender, EventArgs e)
        {
            InitializeArray();
            CreateButtons();
        }

        private void Wait(double seconds)
        {
            int ticks = System.Environment.TickCount + (int)Math.Round(seconds * 1000.0);
            while (System.Environment.TickCount < ticks)
            {
                Application.DoEvents();
            }
        }

        void InitializeArray()
        {
            for (int i = 0; i < 10; ++i)
                array[i] = i + 1;

            for (int i = 10; i < 20; ++i)
                array[i] = (i + 1) * 2;

            for (int i = 20; i < 30; ++i)
                array[i] = (i + 1) * 3;
        }

        void CreateButtons()
        {
            for (int i = 0; i < 30; ++i)
            {
                Button button = new Button();
                button.Size = new Size(30, 30);
                button.Location = new Point(30 * i, 0);
                button.Text = Convert.ToString(array[i]);
                Controls.Add(button);
                buttons[i] = button;
            }
        }

        void PaintButtons(int from, int to, String color)
        {
            for (int i = from; i <= to; ++i)
            {
                switch(color)
                {
                    case "Red":
                        {
                            buttons[i].BackColor = Color.Red;
                            break;
                        }
                    case "Yellow":
                        {
                            buttons[i].BackColor = Color.Yellow;
                            break;
                        }
                    case "Green":
                        {
                            buttons[i].BackColor = Color.Green;
                            break;
                        }
                }
            }
        }

        void BinarySearch(int from, int to, int key)
        {
            Wait(1.0);

            int temp = (from + to) / 2;

            if (key == array[temp])
            {
                PaintButtons(temp, temp, "Green");
                return;
            }

            if (from == to)
            {
                PaintButtons(temp, temp, "Red");
                return;
            }

            if (key > array[temp])
            {
                PaintButtons(from, temp, "Red");
                BinarySearch(temp + 1, to, key);
            }

            if (key < array[temp])
            {
                PaintButtons(temp, to, "Red");
                BinarySearch(from, temp - 1, key);
            }

            return;
        }

        void UltraMegaHaroshSearch(int from, int to, int key)
        {
            Wait(1.0);

            int current = (from + to) / 2;
            int temp = from + (to - from) / 3;

            if (key == array[current])
            {
                PaintButtons(current, current, "Green");
                return;
            }

            if (from == to)
            {
                PaintButtons(current, current, "Red");
                return;
            }

            if (key < array[temp + 1])
            {
                PaintButtons(temp + 1, to, "Red");
                UltraMegaHaroshSearch(from, temp, key);
            }

            if (key > array[temp] &&
                key < array[temp * 2 + 1])
            {
                PaintButtons(from, temp, "Red");
                PaintButtons(temp * 2 + 1, to, "Red");
                UltraMegaHaroshSearch(temp + 1, temp * 2, key);
            }

            if (key > array[temp * 2])
            {
                PaintButtons(from, temp * 2, "Red");
                UltraMegaHaroshSearch(temp * 2 + 1, to, key);
            }

            return;
        }

        private void Execute_Click(object sender, EventArgs e)
        {
            if (InputNumber.TextLength == 0)
            {
                MessageBox.Show("Введите значение!");
                return;
            }

            int key = Convert.ToInt32(InputNumber.Text);

            PaintButtons(0, array.Length - 1, "Yellow");

            //BinarySearch(0, array.Length - 1, key);
            UltraMegaHaroshSearch(0, array.Length - 1, key);
        }

        private void InputNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }
    }
}
