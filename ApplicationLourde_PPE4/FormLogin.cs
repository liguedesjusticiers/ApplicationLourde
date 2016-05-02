using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationLourde_PPE4
{
    public partial class FormLogin : Form
    {

        public FormLogin()
        {
            InitializeComponent();
        }

        private void ValidLogin_Click(object sender, EventArgs e)
        {
            controleur.init();
            controleur.Vmodele.seconnecter();
            if (controleur.Vmodele.Connopen == false)
            {
                MessageBox.Show("Erreur ouverture bdd ", "PBS Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                controleur.Vmodele.import();
                if (controleur.Vmodele.Chargement == true)
                {
                    MessageBox.Show("La connexion à la BDD à bien été réalisé", "Connexxion OK!!", MessageBoxButtons.OK);
                }
            }
            FormPrincipale FP = new FormPrincipale();
            FP.Show(); 
            controleur.Vmodele.sedeconnecter();     
        }
    }
}
