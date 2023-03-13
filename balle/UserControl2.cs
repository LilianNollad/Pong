using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace balle
{
    public partial class Raquette : UserControl
    {
        public bool RenvoyerBalle(Balle1 b)
        {
            bool res = false;


            if(res == false)
            {


                if (Location.Y == b.Location.Y + b.Width)
                {
                    if (b.Location.X + Width > this.Location.X)
                    {
                        if (b.Location.X - Width < this.Location.X)
                        {
                            res = true;

                        }
                    }
                }
                        
                    


             }
       


            




            return res;
        }

        public Raquette()
        {
            InitializeComponent();

        }

        private void Raquette_Load(object sender, EventArgs e)
        {

        }
        private int deplacementX = 0;
        public void SetDirection(Keys touche)
        {
            if (touche == Keys.Q)
            {
                deplacementX = -3;
            }
            else
            {
                if (touche == Keys.M)
                {
                    deplacementX = 3;
                }
            }
        }
        public void Stopper()
        {
            deplacementX = 0;
        }
        public void Deplacer()
        {
            bool depOk = false;

            if (deplacementX == -3)
            {
                if(Location.X >0)
                {
                    depOk = true;

                }                         
            }
           else if (deplacementX == 3)
            {
                if(Location.X + Width < Parent.Width)
                {

                    depOk = true;
                }

            }
            if(depOk == true)
            {
                Location = new Point(Location.X + deplacementX,
                Location.Y);
                Location = new Point(Location.X + deplacementX, Location.Y);



            }
        }





    }
  
    
}
