using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static classe_automobile.Form1;

namespace classe_automobile
{
    public partial class Form1 : Form
    {
        public class auto
        {
            public int velo { get; set; }

        }
        auto Auto = new auto();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        bool acce = false;
        private void accendi_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La macchina è accesa");
            acce = true;
        }
        private void spegni_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La macchina è spenta");
            acce = false;
        }

        private void acelera_Click(object sender, EventArgs e)
        {
            if (acce == true)
            {
                Auto.velo += 5;
                velocità.Text = Auto.velo.ToString();
            }
            else
            {
                MessageBox.Show("La macchina è spenta, per usare i pedali bisogna accenderla");
            }
        }

        private void freno_Click(object sender, EventArgs e)
        {

        }

        private void marciasu_Click(object sender, EventArgs e)
        {

        }

        private void marciagiù_Click(object sender, EventArgs e)
        {

        }

        private void retromarcia_Click(object sender, EventArgs e)
        {

        }
    }
}
