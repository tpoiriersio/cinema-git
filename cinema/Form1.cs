using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cinema
{
    public partial class Form1 : Form
    {
        private List<salleCinema> salle;
        public Form1()
        {
            InitializeComponent();
            salle = new List<salleCinema>();

            // Ajout
            salle.Add(new salleCinema("James bond",55,13.5, 1) );
            salle.Add(new salleCinema("Fast & furious", 150, 13.5, 2));
            salle.Add(new salleCinema("La petite maison dans la prairie", 85, 13.5, 3));
            salle.Add(new salleCinema("Nadiazor", 100, 13.5, 4));
        }

        private void Bt_validerSeance_Click(object sender, EventArgs e)
        {


        }
    }
}
