using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AppSenSoutenance2.Views.Parametre
{
    public partial class frmProfesseur : Form
    {
        private string connectionString = "server=localhost;database=soutenancebd;uid=root;pwd=name1234;";

        public frmProfesseur()
        {
            InitializeComponent();
        }

        private void frmProfesseur_Load(object sender, EventArgs e)
        {
            TesterConnexion();
            ChargerNombreCandidatureEnAttente();
            ChargerNombreMemoires();
            ChargerListeMemoires();
        }

        private void ChargerNombreCandidatureEnAttente()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM candidats WHERE Statut='EnAttente'";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                int total = Convert.ToInt32(cmd.ExecuteScalar());
                NombreCandidatureAttente.Text = total.ToString(); // label sur le form
            }
        }
        private void TesterConnexion()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    MessageBox.Show("Connexion à la base réussie !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de connexion : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ChargerNombreMemoires()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM memoires";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                int total = Convert.ToInt32(cmd.ExecuteScalar());
                NombreMemoires.Text = total.ToString(); // label sur le form pour les mémoires
            }
        }

        private void ChargerListeMemoires()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
                    SELECT m.IdMemoire, m.SujetMemoire, a.LibelleAcademique, s.LibelleSession
                    FROM memoires m
                    LEFT JOIN anneeacademiques a ON m.IdAnneeAcademique = a.IdAnneeAcademiqueId
                    LEFT JOIN sessions s ON m.IdSession = s.IdSession";

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView1.DataSource = dt;

                if (dataGridView1.Columns.Count >= 4)
                {
                    dataGridView1.Columns[0].HeaderText = "ID Mémoire";
                    dataGridView1.Columns[1].HeaderText = "Sujet";
                    dataGridView1.Columns[2].HeaderText = "Année Académique";
                    dataGridView1.Columns[3].HeaderText = "Session";
                }
            }
        }

        // Si tu veux gérer d'autres TextChanged ou Paint, tu peux les laisser vides ou supprimer
    }
}
