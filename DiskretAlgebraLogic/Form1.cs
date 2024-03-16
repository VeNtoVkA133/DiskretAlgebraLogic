using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiskretAlgebraLogic
{



    public partial class Form1 : Form
    {
        int[] a = { 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1 };
        int[] b = { 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 1, 1, 1, 1 };
        int[] c = { 0, 0, 1, 1, 0, 0, 1, 1, 0, 0, 1, 1, 0, 0, 1, 1 };
        int[] d = { 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1 };
        int[] maUmbYc = new int[16];
        int[] aUbUcUd = new int[16];
        int[] aUb = new int[16];
        int[] cUd = new int[16];
        int[] aYb = new int[16];
        int[] cYd = new int[16];
        int[] ac = new int[16];
        int[] ab = new int[16];

        int mpaUmpbYpc;
        int paUpbUpcUpd;
        int paUpb;
        int pcUpd;
        int paYpb;
        int pcYpd;
        int pac;
        int pab;


        public int aub(int x, int y)
        {
            // a+b
            return oneitsone(x + y);
        }
        public int ayb(int x, int y)
        {
            // a*b
            return oneitsone(x * y);
        }
        public int aubucud(int aUb, int cUd)
        {
            // a+b+c+d
            return oneitsone(aUb + cUd);
        }
        public int mambyc(int a, int b, int c)
        {
            // -a+-b*c
            int ma;
            int mb;
                ma = returnnum(a);
                mb = returnnum(b);
            return oneitsone((ma + mb) * c);
        }
        public int aic(int a, int c)
        {
            // a>>c
            int ac;
            if (a == c)
            {
                ac = 1;
            }
            else
            {
                ac = 0;
            }
            return ac;
        }
        public int aiib(int a, int b)
        {
            // a>>c
            int ab;
            if (a == b)
            {
                ab = 0;
            }
            else
            {
                ab = 1;
            }
            return ab;
        }

        static int oneitsone(int i)
        {
            if (i > 1)
            {
                i = 1;
            }
            return i;
        }
        static int returnnum(int i)
        {
            if (i == 0)
            {
                i = 1;
            }
            else if (i == 1)
            {
                i = 0;
            }
            return i;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            listBox5.Items.Clear();
            listBox6.Items.Clear();
            listBox7.Items.Clear();
            listBox8.Items.Clear();
            listBox9.Items.Clear();
            listBox10.Items.Clear();
            for (int i = 0; i < a.Length; i++)
            {
                aUb[i] = aub(a[i], b[i]);
            }
            for (int i = 0; i < a.Length; i++)
                aYb[i] = ayb(a[i], b[i]);
            for (int i = 0; i < a.Length; i++)
                cUd[i] = aub(c[i], d[i]);
            for (int i = 0; i < a.Length; i++)
                cYd[i] = ayb(c[i], d[i]);
            for (int i = 0; i < a.Length; i++)
                aUbUcUd[i] = aubucud(aUb[i], cUd[i]);
            for (int i = 0; i < a.Length; i++)
                maUmbYc[i] = mambyc(a[i], b[i], c[i]);
            for (int i = 0; i < a.Length; i++)
                ac[i] = aic(a[i], c[i]);
            for (int i = 0; i < a.Length; i++)
                ab[i] = aiib(a[i], b[i]);
            for (int i = 0; i < a.Length; i++)
            {
                listBox3.Items.Add("   " + aUb[i]);
                listBox4.Items.Add("   " + aYb[i]);
                listBox5.Items.Add("   " + cUd[i]);
                listBox6.Items.Add("   " + cYd[i]);
                listBox7.Items.Add("      " + aUbUcUd[i]);
                listBox8.Items.Add("      " + maUmbYc[i]);
                listBox9.Items.Add("   " + ac[i]);
                listBox10.Items.Add("   " + ab[i]);
            }
                // Вывод вводных данных в виде таблице
                for (int i = 0; i < a.Length; i++)
            {
                listBox1.Items.Add(a[i].ToString() + "    " + b[i].ToString() + "    " + c[i].ToString() + "    " + d[i].ToString());

            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            listBox28.Items.Clear();
            listBox29.Items.Clear();
            listBox30.Items.Clear();
            listBox31.Items.Clear();
            listBox32.Items.Clear();
            listBox33.Items.Clear();
            listBox34.Items.Clear();
            listBox35.Items.Clear();
            int pa = Convert.ToInt32(textBox1.Text);
            int pb = Convert.ToInt32(textBox2.Text);
            int pc = Convert.ToInt32(textBox3.Text);
            int pd = Convert.ToInt32(textBox4.Text);

            if (pa < 0 || pa > 1)
            {
                label2.Text = ("ОШИБКА в А!! Введите число 0 или 1");
                label2.Visible = true;
                label3.Text = "Ошибочное значение заменено на 0!!!";
                label3.Visible = true;
                textBox1.Text = "0";
            }
            else if (pb < 0 || pb > 1)
            {
                label2.Text = ("ОШИБКА в B!! Введите число 0 или 1");
                label2.Visible = true;
                label3.Text = "Ошибочное значение заменено на 0!!!";
                label3.Visible = true;
                textBox2.Text = "0";
            }
            else if (pc < 0 || pc > 1)
            {
                label2.Text = ("ОШИБКА в C!! Введите число 0 или 1");
                label2.Visible = true;
                label3.Text = "Ошибочное значение заменено на 0!!!";
                label3.Visible = true;
                textBox3.Text = "0";
            }
            else if (pd < 0 || pd > 1)
            {
                label2.Text = ("ОШИБКА в D!! Введите число 0 или 1");
                label2.Visible = true;
                label3.Text = "Ошибочное значение заменено на 0!!!";
                label3.Visible = true;
                textBox4.Text = "0";
            }
            else
            {
                label2.Visible = false;
                label3.Visible = false;
            }


            paUpb = aub(pa, pb);
            paYpb = ayb(pa, pb);
            pcUpd = aub(pc, pd);
            pcYpd = ayb(pc, pd);
            paUpbUpcUpd = aubucud(paUpb, pcUpd);
            mpaUmpbYpc = mambyc(pa, pb, pc);
            pac = aic(pa, pc);
            pab = aiib(pa, pb);
                listBox35.Items.Add("   " + paUpb);
                listBox34.Items.Add("   " + paYpb);
                listBox33.Items.Add("   " + pcUpd);
                listBox32.Items.Add("   " + pcYpd);
                listBox31.Items.Add("      " + paUpbUpcUpd);
                listBox30.Items.Add("      " + mpaUmpbYpc);
                listBox29.Items.Add("   " + pac);
                listBox28.Items.Add("   " + pab);
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox8_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void listBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
