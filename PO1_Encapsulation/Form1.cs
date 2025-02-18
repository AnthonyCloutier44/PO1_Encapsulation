namespace PO1_Encapsulation
{
    public partial class Form1 : Form
    {
        Personnage joueur;
        Personnage monstre;
        public Form1()
        {
            InitializeComponent();
            joueur = new Personnage();
            joueur.PointDeVieMaximal1 = 10;
            joueur.PointDeVie = 10;
            joueur.PuissanceAttaque1 = 1;
            monstre = new Personnage();
            monstre.PointDeVieMaximal1 = 30;
            monstre.PointDeVie = 30;
            monstre.PuissanceAttaque1 = 3;
        }

        private void btn_attaquer_Click(object sender, EventArgs e)
        {
            monstre.PointDeVie = monstre.PointDeVie - joueur.PuissanceAttaque1;
            //lbl_pointsVieJoueur
            joueur.PointDeVie = joueur.PointDeVie - monstre.PuissanceAttaque1;
        }

        private void btn_seSoigner_Click(object sender, EventArgs e)
        {
            joueur.PointDeVie += 5;
            joueur.PointDeVie = joueur.PointDeVie - monstre.PuissanceAttaque1;
            ActualiserAffichage();
            if (joueur.EstMort)
            {
                MessageBox.Show("Vous êtes mort!");
            }
            if(monstre.EstMort)
            {
                MessageBox.Show("Vous avez gagné");
            }
        }

        private void btn_puissanceAttaque_Click(object sender, EventArgs e)
        {
            joueur.PuissanceAttaque1 += 4;
            joueur.PointDeVie = joueur.PointDeVie - monstre.PuissanceAttaque1;
            ActualiserAffichage();
        }
        private void ActualiserAffichage()
        {

            lbl_pointsVieJoueur.Text = "Points de vie : " + joueur.PointDeVie;
            lbl_pointsVieDragon.Text = "Points de vie : " + monstre.PointDeVie;

            lbl_puissanceAttaqueDragon.Text = "Puissance attaque : " + monstre.PuissanceAttaque1;
            lbl_puissanceAttaqueJoueur.Text = "Puissance attaque : " + joueur.PuissanceAttaque1;

        }
    }
}