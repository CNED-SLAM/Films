using System;
using System.Windows.Forms;

namespace Films
{
    public partial class frmFilms : Form
    {
        public frmFilms()
        {
            InitializeComponent();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            string titre = txtTitre.Text.ToUpper();
            if (!titre.Equals(""))
            {
                lstTitres.Items.Add(titre);
            }
            GestionZoneDeSaisie();
        }

        private void txtTitre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                btnAjouter_Click(null, null);
            }
        }

        private void frmFilms_Load(object sender, EventArgs e)
        {
            btnSupprimer.Enabled = false;
            lblTitre.Text = "";
            GestionZoneDeSaisie();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if(lstTitres.SelectedIndex != -1)
            {
                btnSupprimer.Enabled = false;
                lstTitres.Items.RemoveAt(lstTitres.SelectedIndex);
                lblTitre.Text = "";
            }
            else
            {
                MessageBox.Show("Sélectionnez une ligne");
            }
            GestionZoneDeSaisie();
        }

        private void btnVider_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Vider la Liste ?", "Confirmation", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                btnSupprimer.Enabled = false;
                lstTitres.Items.Clear();
            }
            GestionZoneDeSaisie();
        }

        private void lstTitres_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstTitres.SelectedIndex != -1)
            {
                btnSupprimer.Enabled = true;
                lblTitre.Text = lstTitres.SelectedItem.ToString();
            }
            GestionZoneDeSaisie();
        }

        private void GestionZoneDeSaisie()
        {
            txtTitre.Text = "";
            txtTitre.Focus();
        }

    }
}
