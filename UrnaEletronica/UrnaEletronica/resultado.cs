using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrnaEletronica
{
    public partial class resultado : Form
    {
        public double cr7;
        public double neymar;
        public double messi;
        public double nulo;
        public double branco;
        public resultado()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            txtbranco.Text = Convert.ToString(branco);
            txtcr7.Text = Convert.ToString(cr7);
            txtmessi.Text = Convert.ToString(messi);
            txtney.Text = Convert.ToString(neymar);
            txtnulo.Text = Convert.ToString(nulo);
        }
    }
}
