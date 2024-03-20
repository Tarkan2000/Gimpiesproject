using Gimpies_sprint_2.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gimpies_sprint_2
{
    public partial class label1 : Form
    {
        public label1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Wachtwoord_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //loginform//
            Application.Exit();
        }

        private void label1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }
        //Dit is voor de hoeveelheid pogingen//
        int pogingen = 1;
        
      

        private void button1_Click(object sender, EventArgs e)
        {   //Voor het Gebruikersnaam en wachtwoord van de verkoopmedewerker, manager//
            //voor als je de goeie gegevens invult als verkoopmedewerker//
            if (textBox1.Text == "Verkoop" && textBox2.Text == "Gimpies_Verkoop")
            {
               //dit zorgt ervoor dat je de menu krijgt van de verkoopmedewerker wanneer je gaat inloggen met de gegevens van de verkoopmedewerker//
                MessageBox.Show("Welkom verkoopmedewerker");
           verkoopmedewerker Sform = new verkoopmedewerker();
                this.Hide();
                Sform.ShowDialog();
                this.Close();

                
            }
            else
            {
                    //voor als je de goeie gegevens invult als de manager        
                {
                    if (textBox1.Text == "Admin" && textBox2.Text == "Gimpies_Admin")
                    {
                        MessageBox.Show("Welkom Manager");
                        //dit zorgt ervoor dat je de menu krijgt van de manager wanneer je gaat inloggen met de gegevens van de manager//
                        manager Dform = new manager();
                        this.Hide();
                        Dform.ShowDialog();
                        this.Close();
                        
                    } //voor als je de foute gegegens invoert als verkoopmedewerker, manager//
                    else
                    {
                        MessageBox.Show("Foute inloggegevens.. probeer opnieuw in te loggen "+ pogingen + " pogingen uit de 3 "  );
                        pogingen++;
                    }
                   //zorgt ervoor dat als je meer dan 3 pogingen gebruikt dat de programma gaat afsluiten//
                    if (pogingen == 4)
                    {
                        MessageBox.Show("Je hebt het maximum aantal inlogpogingen bereikt.. het programma wordt nu afgesloten");
                        Application.Exit();
                    }

                }
            }
        }
    }
}
