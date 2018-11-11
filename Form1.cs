using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ID_Calc
{
    public partial class Form1 : Form
    {
        int[] temp = new int[] { 1, 2, 1, 2, 1, 2, 1, 2 };
        int[] sum = new int[8];
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt8DigitId.Text = CalculateFullID(txtFullId.Text);
        }

        private string CalculateFullID(string id)
        {
            
            int total = 0;
            if (id.Length < 8)
            {
                id = id.PadLeft(8, '0');
            }
            else if (id.Length == 9)
            {
                id = id.Substring(0, 8);
            }
            else if (id.Length > 9)
            {
                return "Error";
            }
            for (int i = 0; i < temp.Length; i++)
            {

                sum[i] = temp[i] * int.Parse(id[i].ToString());
                sum[i] = AddDigits(sum[i]);
                total += sum[i];

            }

            txtBikoret.Text = (10 - (total % 10)).ToString();

            return id;
        }

        private int AddDigits(int num)
        {
            if (num < 10)
            {
                return num;
            }
            return num % 10 + num / 10;

        }
    }
}
