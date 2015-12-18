﻿using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLourde_PPE4
{
    class modele
    {
        private MySqlConnection myConnection;
        private bool connopen = false;
        private bool errgrave = false;
        private bool chargement = false;
        private MySqlDataAdapter mySqlDataAdapterPPE4 = new MySqlDataAdapter();
        private DataSet dataSetPPE4 = new DataSet();


        #region accesseur
        public MySqlConnection MyConnection
        {
            get { return myConnection; }
            set { myConnection = value; }
        }

        public bool Connopen
        {
            get { return connopen; }
            set { connopen = value; }
        }

        public bool Errgrave
        {
            get { return errgrave; }
            set { errgrave = value; }
        }

        public bool Chargement
        {
            get { return chargement; }
            set { chargement = value; }
        }
        #endregion


        public void seconnecter()
        {
            string myConnectionString = "Database=bd_ppe4_GaubertEtCo;Data Source=localhost;User Id=root;";
            myConnection = new MySqlConnection(myConnectionString);
            try
            {
                myConnection.Open();
                connopen = true;
            }
            catch (Exception err)
            {
                MessageBox.Show("Erreur ouverture bdd : " + err, "PBS connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connopen = false;
                errgrave = true;
            }
        }

        public void sedeconnecter()
        {
            if (!connopen)
                return;
            try
            {
                myConnection.Close();
                myConnection.Dispose();
                connopen = false;
            }
            catch (Exception err)
            {
                MessageBox.Show("Erreur fermeture bdd : " + err, "PBS deconnection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errgrave = true;
            }
        }
        public void import()
        {
            if (!connopen) return;
            mySqlDataAdapterTP7.SelectCommand = new MySqlCommand("select * from formation; select * from personne;", myConnection);
            try
            {
                dataSetPPE4.Clear();
                mySqlDataAdapterTP7.Fill(dataSetPPE4);
                MySqlCommand vcommand = myConnection.CreateCommand();

                vcommand.CommandText = "SELECT AUTO_INCREMENT as last_id FROM INFORMATION_SCHEMA.TABLES WHERE table_name = 'personne'";
                UInt64 der_personne = (UInt64)vcommand.ExecuteScalar();
                dataSetPPE4.Tables[1].Columns[0].AutoIncrement = true;
                dataSetPPE4.Tables[1].Columns[0].AutoIncrementSeed = Convert.ToInt64(der_personne);
                dataSetPPE4.Tables[1].Columns[0].AutoIncrementStep = 1;

                dv_formation = dataSetPPE4.Tables[0].DefaultView;
                dv_personne = dataSetPPE4.Tables[1].DefaultView;
                dv_poste = dataSetPPE4.Tables[2].DefaultView;

                chargement = true;
            }
            catch (Exception err)
            {
                MessageBox.Show("Erreur chargement dataset : " + err, "PBS formation/personne", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errgrave = true;
            }
        }
    }

}
