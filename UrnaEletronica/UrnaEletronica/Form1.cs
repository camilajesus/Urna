using System;
using System.Windows.Forms;

namespace UrnaEletronica
{
    public partial class Form1 : Form
    {
        double m = 0, messi = 0, neymar = 0, cr7 = 0, nulo = 0, branca = 0, rd = 50;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            txtnum.AppendText("1");
        }

        private void lblNC_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtnum.AppendText("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtnum.AppendText("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtnum.AppendText("4");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            pctboxtela.Image = Properties.Resources.TELA;
            txtnome.Clear();
            txtpartido.Clear();


            m = Convert.ToDouble(txtnum.Text);

            if (m == 20)

            {
                cr7 = (cr7 + 1);
              // txt.Text = Convert.ToString(cr7);
                rd = (rd - 10);
                txtnum.Clear();
                rd = rd + 10;


            }
            if (m == 30)

            {
                neymar = (neymar + 1);
                //textBox4.Text = Convert.ToString(neymar);
                rd = (rd - 10);
                txtnum.Clear();
                rd = rd + 10;

            }
            if (m == 40)

            {
                messi= (messi + 1);
                //textBox5.Text = Convert.ToString(messi);
                rd = (rd - 10);
                txtnum.Clear();
                rd = rd + 10;

            }

            if (m == 0)
            {
                branca = (branca + 1);
                //textBox7.Text = Convert.ToString(branca);
                rd = (rd - 10);
                txtnum.Clear();
                rd = rd + 10;
            }

            if (m != 0 && m != 20 && m != 30 && m != 40)

            {
                nulo = (nulo + 1);
                //textBox6.Text = Convert.ToString(nulo);
                rd = (rd - 10);
               txtnum.Clear();
                rd = rd + 10;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtnum.AppendText("0");
            pctboxtela.Image = Properties.Resources.BRANCO;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            rd = (rd - 10);
            txtnum.Clear();
            rd = rd + 10;
            txtnome.Clear();
            txtpartido.Clear();
            pctboxtela.Image = Properties.Resources.TELA;
        }

        private void txtnum_TextChanged(object sender, EventArgs e)
        {
            if (rd > 49)
            {
                m = Convert.ToDouble(txtnum.Text);
                if (m == 0)
                {

                    txtnome.Text = "branco";
                    txtpartido.Text = "branco";

                }
                if (m > 9)
                {
                    if (m != 20 || m != 30 || m != 40)
                    {
                        pctboxtela.Image = Properties.Resources.nulo;
                        txtnome.Text = "Nulo";
                        txtpartido.Text = "Nulo";
                    }

                    if (m == 20)

                    {
                        pctboxtela.Image = Properties.Resources.CR7;
                        txtnome.Text = "CR7";
                        txtpartido.Text = "Mito";


                    }
                    if (m == 30)

                    {
                        pctboxtela.Image = Properties.Resources.NEYMAR;
                        txtnome.Text = "Neymar";
                        txtpartido.Text = "Driblei Voce";

                    }
                    if (m == 40)


                    {
                        pctboxtela.Image = Properties.Resources.MESSI;
                        txtnome.Text = "Messi";
                        txtpartido.Text = "Cristiano Ronaldo é melhor";

                    }


                }
            }
        }

        private void txtresult_Click(object sender, EventArgs e)
        {
            resultado form1 = new resultado();
            form1.cr7 = cr7;
            form1.neymar = neymar;
            form1.messi = messi;
            form1.branco = branca;
            form1.nulo = nulo;

            form1.Show();

        }

        private void sAIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void iNTEGRANTESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Integrantes form1 = new Integrantes();
            form1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtnum.AppendText("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtnum.AppendText("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtnum.AppendText("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtnum.AppendText("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtnum.AppendText("9");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtnum.AppendText("0");

        }
    }
}
