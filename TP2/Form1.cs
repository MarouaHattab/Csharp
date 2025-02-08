namespace TP2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }



        private void buttonAfficher_Click_1(object sender, EventArgs e)
        {
            //labelMessage.Text = "Bonjour, " + textBoxNom.Text + "!";

            string message = "Bonjour, ";

            if (radioButtonF.Checked)
            {
                message += " Madame ";
            }
            else if (radioButtonM.Checked)
            {
                message += " Monsieur ";
            }
            message += textBoxNom.Text + "!"; 

            if (checkBox1.Checked && checkBox2.Checked)
            {
                message += " Vous avez choisi les options 1 et 2";
            }
            else if (checkBox1.Checked)
            {
                message += " Vous avez choisi l'option 1";
            }
            else if (checkBox2.Checked)
            {
                message += " Vous avez choisi l'option 2";
            }

            MessageBox.Show(message, "Message");
        }



        private void textBoxNom_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNom.Text))
            {
                return;
            }

            if (!textBoxNom.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
            {
                MessageBox.Show("Erreur : Veuillez saisir un nom valide (caractères alphabétiques uniquement)", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxNom.Text = "";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
