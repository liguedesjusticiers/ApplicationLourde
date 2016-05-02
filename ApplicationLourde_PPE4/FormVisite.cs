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
    public partial class FormVisite : Form
    {
        private BindingSource bindingSource1 = new BindingSource();

        public FormVisite()
        {
            InitializeComponent();
            chargedgv();
        }

        public void chargedgv()
        {
            bindingSource1.DataSource = controleur.Vmodele.Dv_visite;


            List<KeyValuePair<int, string>> DepList = new List<KeyValuePair<int, string>>();
            DepList.Add(new KeyValuePair<int, string>(0, "toutes les departement"));
            cbDepartement.Items.Add("toutes les departement");

            for (int i = 0; i < controleur.Vmodele.Dv_departement.ToTable().Rows.Count; i++)
            {
                DepList.Add(new KeyValuePair<int,
                string>((int)controleur.Vmodele.Dv_departement.ToTable().Rows[i][0],
                controleur.Vmodele.Dv_departement.ToTable().Rows[i][1].ToString()));
            }
            cbDepartement.DataSource = DepList;
            cbDepartement.ValueMember = "Key";
            cbDepartement.DisplayMember = "Value";
            cbDepartement.Text = cbDepartement.Items[0].ToString();
            cbDepartement.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}