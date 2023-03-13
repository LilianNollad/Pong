using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace balle
{
    public partial class Balle1 : UserControl
    {
        public bool b = false;
        public int score;
        private Raquette laRaquette;
        public event EventHandler Perdu;
        public Label flb_score4;
        public int m_score;
        

        private int deplacementX = 1;
        private int deplacementY = 1;
        public Balle1()
        {
            InitializeComponent();
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(0, 0, 20, 20);
            Region = new Region(gp);
            







        }

        private void Balle1_Load(object sender, EventArgs e)
        {

        }
        public void Init(Raquette p_raquette, Label lb_score2, bool a,Label lb_score4)
        {
            laRaquette = p_raquette;
            lb_score2.Text = "" + score;
            b = a;
            flb_score4 = lb_score4;
            flb_score4.Text = "" + m_score;
 
        }
       

        public void deplacer()
        {
            Location = new Point(Location.X + deplacementX,
            Location.Y + deplacementY);
            Location = new Point(Location.X + deplacementX, Location.Y + deplacementY);
            if (Location.X + Width > Parent.Width)
            {
                deplacementX = -deplacementX;
            }  
            else  if (Location.Y < 0 )
            {
                deplacementY = -deplacementY;
            }
            else if (Location.X < 0)
            {
                deplacementX = -deplacementX;

            }
            else if (Location.Y + Height > Parent.Height)
            {

                Perdu(this, null);
            }
            laRaquette.RenvoyerBalle(this);
            {
                if (laRaquette.RenvoyerBalle(this) == true)
                {

                    deplacementY = -deplacementY;
                    score++;


                }


            }
            if (b == true)
            {
                score = 0;
               


            }
            if(m_score < score)
            {
                m_score = score;
                flb_score4.Text = "" + m_score;


            }


        }
        
    }
}
