namespace ApplicationLourde_PPE4
{
    partial class FormLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelID = new System.Windows.Forms.Label();
            this.labelMDP = new System.Windows.Forms.Label();
            this.cb_id_inspecteur = new System.Windows.Forms.ComboBox();
            this.cb_mdp_inspecteur = new System.Windows.Forms.ComboBox();
            this.ValidLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.labelID.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(41, 94);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(102, 23);
            this.labelID.TabIndex = 0;
            this.labelID.Text = "Identifiant :";
            // 
            // labelMDP
            // 
            this.labelMDP.AutoSize = true;
            this.labelMDP.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.labelMDP.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMDP.Location = new System.Drawing.Point(41, 178);
            this.labelMDP.Name = "labelMDP";
            this.labelMDP.Size = new System.Drawing.Size(118, 23);
            this.labelMDP.TabIndex = 1;
            this.labelMDP.Text = "Mot De Passe :";
            // 
            // cb_id_inspecteur
            // 
            this.cb_id_inspecteur.FormattingEnabled = true;
            this.cb_id_inspecteur.Location = new System.Drawing.Point(191, 98);
            this.cb_id_inspecteur.Name = "cb_id_inspecteur";
            this.cb_id_inspecteur.Size = new System.Drawing.Size(145, 21);
            this.cb_id_inspecteur.TabIndex = 2;
            // 
            // cb_mdp_inspecteur
            // 
            this.cb_mdp_inspecteur.FormattingEnabled = true;
            this.cb_mdp_inspecteur.Location = new System.Drawing.Point(191, 182);
            this.cb_mdp_inspecteur.Name = "cb_mdp_inspecteur";
            this.cb_mdp_inspecteur.Size = new System.Drawing.Size(145, 21);
            this.cb_mdp_inspecteur.TabIndex = 3;
            // 
            // ValidLogin
            // 
            this.ValidLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValidLogin.Location = new System.Drawing.Point(182, 267);
            this.ValidLogin.Name = "ValidLogin";
            this.ValidLogin.Size = new System.Drawing.Size(85, 32);
            this.ValidLogin.TabIndex = 4;
            this.ValidLogin.Text = "Valider";
            this.ValidLogin.UseVisualStyleBackColor = true;
            this.ValidLogin.Click += new System.EventHandler(this.ValidLogin_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ApplicationLourde_PPE4.Properties.Resources.fond1_320;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(472, 379);
            this.Controls.Add(this.ValidLogin);
            this.Controls.Add(this.cb_mdp_inspecteur);
            this.Controls.Add(this.cb_id_inspecteur);
            this.Controls.Add(this.labelMDP);
            this.Controls.Add(this.labelID);
            this.Name = "FormLogin";
            this.Text = "FormLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelMDP;
        private System.Windows.Forms.ComboBox cb_id_inspecteur;
        private System.Windows.Forms.ComboBox cb_mdp_inspecteur;
        private System.Windows.Forms.Button ValidLogin;
    }
}