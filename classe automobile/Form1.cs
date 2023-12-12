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
            public int Marcia { get; set; }

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
            if (acce == true)
            {
                Auto.velo -= 5;
                velocità.Text = Auto.velo.ToString();
            }
            else
            {
                MessageBox.Show("La macchina è spenta, per usare i pedali bisogna accenderla");
            }
        }

        private void marciasu_Click(object sender, EventArgs e)
        {
            if (Auto.Marcia < 7)
            {
                Auto.Marcia++;
                marcia.Text = Auto.Marcia.ToString();
            }
        }

        private void marciagiù_Click(object sender, EventArgs e)
        {
            if (Auto.Marcia == 1)
            {
                marcia.Text = "R";
                Auto.Marcia--;
            }
            else if (Auto.Marcia != 0)
            {
                Auto.Marcia--;
                marcia.Text = Auto.Marcia.ToString();
            }
        }

        private void retromarcia_Click(object sender, EventArgs e)
        {
            if (Auto.Marcia == 1)
            {
                marcia.Text = "N";
                Auto.Marcia--;
            }
            else if (Auto.Marcia != 0)
            {
                Auto.Marcia--;
                marcia.Text = Auto.Marcia.ToString();
            }
            else if (marcia.Text == "N")
            {
                marcia.Text = "R";
            }  
        }
    }
}
