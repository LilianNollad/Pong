using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace balle
{
    public partial class Fm_principal : Form
    {
        public bool a = false;
       
    
        public Fm_principal()
        {
           
            InitializeComponent();
            balle11.Perdu += new EventHandler(Balle1_Perdu);

       
      




        }

        private void bt_quitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bt_jouer_Click(object sender, EventArgs e)
        {
            tempo.Start();
            laRaquette.Focus();
            balle11.Init(laRaquette , lb_score2,a,lb_score4);
            

        }

        private void balle11_Load(object sender, EventArgs e)
        {

        }


        

        private void tempo_Tick(object sender, EventArgs e)
        {
            balle11.deplacer();
            laRaquette.Deplacer();
            balle11.Init(laRaquette,lb_score2,a,lb_score4);
            



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
  

        private void laRaquette_KeyDown_1(object sender, KeyEventArgs e)
        {
            laRaquette.SetDirection(e.KeyCode);

        }

        private void laRaquette_KeyUp_1(object sender, KeyEventArgs e)
        {
            laRaquette.Stopper();
        }
        void Balle1_Perdu(object sender, EventArgs e)
        {

            a = true;
            tempo.Stop();
            MessageBoxButtons buttons = MessageBoxButtons.AbortRetryIgnore;
            DialogResult result = MessageBox.Show("Vous avez perdu ! ,  votre score est de "+lb_score2.Text,"GameOver",buttons, MessageBoxIcon.Warning);
            if (result == DialogResult.Abort)
            {
                Close();

            }
            else if(result == DialogResult.Retry)
            {



            
                tempo.Start();
                laRaquette.Focus();
                balle11.Init(laRaquette, lb_score2,a,lb_score4);
                this.balle11.Location = new System.Drawing.Point(70, 12);
                a = false;   
                




            }


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void leTerrain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
