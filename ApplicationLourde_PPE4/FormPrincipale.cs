using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calendar;

namespace ApplicationLourde_PPE4
{
    public partial class FormPrincipale : Form
    {
        public FormPrincipale()
        {
            InitializeComponent();
            inspecteurToolStripMenuItem.Visible = false;
            
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inspecteurToolStripMenuItem.Visible = true;
           controleur.init();
            controleur.Vmodele.seconnecter();
            if (controleur.Vmodele.Connopen == false)
            {
                MessageBox.Show("Erreur ouverture bdd : ", "PBS Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                controleur.Vmodele.import();
                if (controleur.Vmodele.Chargement == true)
                {
                    
                }
            }
            controleur.Vmodele.sedeconnecter();
           
           
        }

        private void FormInsertionBDD_FormClosed(object sender, FormClosedEventArgs e)
        {
            controleur.Vmodele.sedeconnecter();
        }

        private void gestionVisiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVisite FP = new FormVisite();
            FP.MdiParent = this;
            FP.Show(); 
        }

        private void FormInsertionBDD_Load(object sender, EventArgs e)
        {

        }

        private void planningToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCalendar FC = new FormCalendar();
            FC.MdiParent = this;
            FC.Show(); 
        }
    }
}
