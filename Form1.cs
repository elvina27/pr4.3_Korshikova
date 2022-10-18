using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr4._3_Korshikova
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSetArray_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBoxN.Text);
            int m = Convert.ToInt32(textBoxM.Text);

            for (int i = 0; i <= m; i++)
            {
                dGVSourseArray.Columns.Add("", "");
                if (i > 0) dGVSourseArray.Columns[i].HeaderText = Convert.ToString(i - 1);
                dGVSourseArray.Columns[i].Width = 40;
            }

            for (int i = 0; i < n; i++)
            {
                dGVSourseArray.Rows.Add(Convert.ToString(i), "");
            }
        }

        private void btnOutputArray_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBoxN.Text);
            int m = Convert.ToInt32(textBoxM.Text);
            int k = 0;
            int[,] aa = new int[n, m];

            for (int i  = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    aa[i, j] = Convert.ToInt32(dGVSourseArray.Rows[i].Cells[j + 1].Value);
                    if(aa[i,j] %2 != 0 && (i+j) %2 == 0)
                    {
                        k++;
                        string r = Convert.ToString(i) + "," + Convert.ToString(j);
                        listBoxResultArray.Items.Add(r);
                    }
                }
            }
            textBoxK.Text = Convert.ToString(k);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
