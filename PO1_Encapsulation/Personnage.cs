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
        int attaque;

        public int PointDeVie { get => pointDeVie; set => pointDeVie = value; }
        public int Attaque { get => attaque; set => attaque = value; }
    }
}
