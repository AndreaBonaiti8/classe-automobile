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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace classe_automobile
{
    //Estendere la classe automobile dell'esercitazione precedente,
    //aggiungendo gli attributi e  i metodi necessari o riscrivendo i metodi della super classe.
    public partial class Form1 : Form
    {
        public class auto
        {
            public int velo { get; set; }
            public int Marcia { get; set; }
            public override string ToString()
            {
                return Marcia.ToString();
            }
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
           if (Auto.velo == 0 && Auto.Marcia == 1)
           {
                MessageBox.Show("La macchina è spenta");
                acce = false;
           }
           else
           {
                MessageBox.Show("La velocità deve essere 0 e deve essere inserita la prima marcia");
           }
           
        }

        private void acelera_Click(object sender, EventArgs e)
        {
            if (acce == true)
            {
                Auto.velo += 5;
                Auto.Marcia = 1;
                velocità.Text = Auto.velo.ToString();
                marcia.Text = Auto.Marcia.ToString();
                if (Auto.velo > 20 && Auto.Marcia == 1)
                {
                    Auto.Marcia++;
                    marcia.Text = Auto.Marcia.ToString();
                }
                if (Auto.velo > 45 && Auto.Marcia == 2)
                {
                    Auto.Marcia++;
                    marcia.Text = Auto.Marcia.ToString();
                }
                if (Auto.velo > 60 && Auto.Marcia == 3)
                {
                    Auto.Marcia++;
                    marcia.Text = Auto.Marcia.ToString();
                }
                if (Auto.velo > 80 && Auto.Marcia == 4)
                {
                    Auto.Marcia++;
                    marcia.Text = Auto.Marcia.ToString();
                }
                if (Auto.velo > 100 && Auto.Marcia == 5)
                {
                    Auto.Marcia++;
                    marcia.Text = Auto.Marcia.ToString();
                }
                if (Auto.velo > 120 && Auto.Marcia == 5)
                {
                    Auto.Marcia++;
                    marcia.Text = Auto.Marcia.ToString();
                }
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
                Auto.Marcia = Convert.ToInt32(marcia.Text);
                marcia.Text = Auto.Marcia.ToString();
                velocità.Text = Auto.velo.ToString();
            }
            else
            {
                MessageBox.Show("La macchina è spenta, per usare i pedali bisogna accenderla");
            }
            if (Auto.velo == 0 && Auto.Marcia == 1)
            {
                marcia.Text = "R";
            }
            if (Auto.velo < 20 && Auto.Marcia == 2)
            {
                Auto.Marcia--;
                marcia.Text = Auto.Marcia.ToString();
            }
            if (Auto.velo < 45 && Auto.Marcia == 3)
            {
                Auto.Marcia--;
                marcia.Text = Auto.Marcia.ToString();
            }
            if (Auto.velo < 60 && Auto.Marcia == 4)
            {
                Auto.Marcia--;
                marcia.Text = Auto.Marcia.ToString();
            }
            if (Auto.velo < 80 && Auto.Marcia == 5)
            {
                Auto.Marcia--;
                marcia.Text = Auto.Marcia.ToString();
            }
            if (Auto.velo < 100 && Auto.Marcia == 6)
            {
                Auto.Marcia--;
                marcia.Text = Auto.Marcia.ToString();
            }
        }

        private void marciasu_Click(object sender, EventArgs e)
        {
            if (Auto.Marcia < 6)
            {

                if (Auto.velo > 20 && Auto.Marcia == 1)
                {
                    Auto.Marcia++;
                    marcia.Text = Auto.Marcia.ToString();
                }
                if (Auto.velo > 45 && Auto.Marcia == 2)
                {
                    Auto.Marcia++;
                    marcia.Text = Auto.Marcia.ToString();
                }
                if (Auto.velo > 60 && Auto.Marcia == 3)
                {
                    Auto.Marcia++;
                    marcia.Text = Auto.Marcia.ToString();
                }
                if (Auto.velo > 80 && Auto.Marcia == 4)
                {
                    Auto.Marcia++;
                    marcia.Text = Auto.Marcia.ToString();
                }
                if (Auto.velo > 100 && Auto.Marcia == 5)
                {
                    Auto.Marcia++;
                    marcia.Text = Auto.Marcia.ToString();
                }
                if (Auto.velo > 120 && Auto.Marcia == 6)
                {
                    Auto.Marcia++;
                    marcia.Text = Auto.Marcia.ToString();
                }
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
