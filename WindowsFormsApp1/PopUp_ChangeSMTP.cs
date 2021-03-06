﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace LettreCooperation
{
    public partial class PopUp_ChangeSMTP : Form
    {
        public PopUp_ChangeSMTP()
        {
            InitializeComponent();

            // Centrage de la page
            this.CenterToScreen();

            // Nous fixons les dimensions de l'application
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            textBoxSMTP.Text = Properties.Settings.Default.SMTP;
            textBoxPort.Text = Properties.Settings.Default.PortSMTP.ToString();

            labelMessage.Text = "Vous pouvez changer ici votre SMTP.";
        }


        /// <summary>
        /// Méthode qui permet d'enregistrer dans la 
        /// base de données le nouveau SMTP
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonValider_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.SMTP = textBoxSMTP.Text;
            Properties.Settings.Default.PortSMTP = Int32.Parse(textBoxPort.Text);
            Properties.Settings.Default.Save();
        }


        /// <summary>
        /// Méthode qui ferme la page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}
