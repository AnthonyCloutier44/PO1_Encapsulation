using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO1_Encapsulation
{
    public class Personnage
    {
        int pointDeVie;
        int puissanceAttaque;
        private int PointDeVieMaximal;
        public int PointDeVie
        {
            get => pointDeVie;
            set
            {
                if (value < 0)
                {
                    pointDeVie = 0;
                }
                else if (value > 10)
                {
                    pointDeVie = PointDeVieMaximal1;
                }
                else
                {
                    pointDeVie = value;
                }
            }
        }
        public bool EstMort
        {
            get
            {
                if (pointDeVie == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }

        public int PointDeVieMaximal1 { get => PointDeVieMaximal; set => PointDeVieMaximal = value; }
        public int PuissanceAttaque1 { get => puissanceAttaque; set => puissanceAttaque = value; }
    }
}
