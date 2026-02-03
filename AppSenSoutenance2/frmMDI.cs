using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSenSoutenance
{
    public partial class frmConnexion : Form
    {
        private Panel panelGauche;
        private Panel panelDroit;
        private ComboBox cmbTypeUtilisateur;

        public frmConnexion()
        {
            InitializeComponent();
            CreerDesignModerne();
        }

        private void CreerDesignModerne()
        {
            // Configuration du formulaire
            this.Size = new Size(900, 600);
            this.BackColor = Color.White;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.None;

            // Ajouter des coins arrondis au formulaire
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            // Panel gauche - Section colorée
            panelGauche = new Panel
            {
                Size = new Size(400, this.Height),
                Location = new Point(0, 0),
                BackColor = Color.FromArgb(99, 110, 250)
            };

            // Dégradé pour le panel gauche
            panelGauche.Paint += (s, e) =>
            {
                LinearGradientBrush gradientBrush = new LinearGradientBrush(
                    panelGauche.ClientRectangle,
                    Color.FromArgb(99, 110, 250),
                    Color.FromArgb(139, 92, 246),
                    LinearGradientMode.Vertical);
                e.Graphics.FillRectangle(gradientBrush, panelGauche.ClientRectangle);
            };

            // Logo/Titre dans le panel gauche
            Label lblLogo = new Label
            {
                Text = "🎓",
                Font = new Font("Segoe UI", 72, FontStyle.Regular),
                ForeColor = Color.White,
                AutoSize = false,
                Size = new Size(350, 100),
                Location = new Point(125, 100),
                TextAlign = ContentAlignment.MiddleCenter
            };

            Label lblAppNom = new Label
            {
                Text = "SEN SOUTENANCE",
                Font = new Font("Segoe UI", 24, FontStyle.Bold),
                ForeColor = Color.White,
                AutoSize = false,
                Size = new Size(350, 50),
                Location = new Point(25, 210),
                TextAlign = ContentAlignment.MiddleCenter
            };

            Label lblAppDesc = new Label
            {
                Text = "Plateforme de gestion\ndes soutenances académiques",
                Font = new Font("Segoe UI", 11, FontStyle.Regular),
                ForeColor = Color.FromArgb(230, 230, 250),
                AutoSize = false,
                Size = new Size(350, 60),
                Location = new Point(25, 270),
                TextAlign = ContentAlignment.MiddleCenter
            };

            // Motif décoratif
            Panel decoratifPanel = new Panel
            {
                Size = new Size(200, 200),
                Location = new Point(-50, 400),
                BackColor = Color.Transparent
            };
            decoratifPanel.Paint += (s, e) =>
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                using (SolidBrush brush = new SolidBrush(Color.FromArgb(50, 255, 255, 255)))
                {
                    e.Graphics.FillEllipse(brush, 0, 0, 150, 150);
                    e.Graphics.FillEllipse(brush, 80, 80, 100, 100);
                }
            };

            panelGauche.Controls.Add(lblLogo);
            panelGauche.Controls.Add(lblAppNom);
            panelGauche.Controls.Add(lblAppDesc);
            panelGauche.Controls.Add(decoratifPanel);

            // Panel droit - Formulaire de connexion
            panelDroit = new Panel
            {
                Size = new Size(500, this.Height),
                Location = new Point(400, 0),
                BackColor = Color.White
            };

            // Bouton de fermeture
            Button btnClose = new Button
            {
                Text = "✕",
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                Size = new Size(40, 40),
                Location = new Point(450, 10),
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.White,
                ForeColor = Color.FromArgb(150, 150, 150),
                Cursor = Cursors.Hand
            };
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.Click += (s, e) => Application.Exit();
            btnClose.MouseEnter += (s, e) => btnClose.ForeColor = Color.FromArgb(231, 76, 60);
            btnClose.MouseLeave += (s, e) => btnClose.ForeColor = Color.FromArgb(150, 150, 150);

            // Titre connexion
            Label lblConnexion = new Label
            {
                Text = "Connexion",
                Font = new Font("Segoe UI", 28, FontStyle.Bold),
                ForeColor = Color.FromArgb(30, 30, 30),
                AutoSize = false,
                Size = new Size(400, 50),
                Location = new Point(50, 60),
                TextAlign = ContentAlignment.MiddleLeft
            };

            Label lblBienvenue = new Label
            {
                Text = "Bienvenue ! Connectez-vous pour continuer",
                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                ForeColor = Color.FromArgb(120, 120, 120),
                AutoSize = false,
                Size = new Size(400, 30),
                Location = new Point(50, 110),
                TextAlign = ContentAlignment.MiddleLeft
            };

            panelDroit.Controls.Add(btnClose);
            panelDroit.Controls.Add(lblConnexion);
            panelDroit.Controls.Add(lblBienvenue);

            this.Controls.Add(panelGauche);
            this.Controls.Add(panelDroit);

            // Ajouter le menu déroulant pour le type d'utilisateur
            AjouterMenuTypeUtilisateur();

            // Styliser les contrôles existants
            StyliserControlesModernes();
        }

        private void AjouterMenuTypeUtilisateur()
        {
            // Label pour le type d'utilisateur
            Label lblTypeUtilisateur = new Label
            {
                Text = "👥  Type d'utilisateur",
                Font = new Font("Segoe UI", 9, FontStyle.Regular),
                ForeColor = Color.FromArgb(100, 100, 120),
                AutoSize = false,
                Size = new Size(200, 20),
                Location = new Point(60, 155),
                BackColor = Color.Transparent
            };

            // Panel conteneur pour le ComboBox
            Panel cmbPanel = new Panel
            {
                Size = new Size(380, 45),
                Location = new Point(60, 178),
                BackColor = Color.FromArgb(245, 247, 250)
            };

            // Couleur de bordure par défaut
            Color couleurBordure = Color.FromArgb(220, 220, 230);

            cmbPanel.Paint += (s, e) =>
            {
                Rectangle rect = cmbPanel.ClientRectangle;
                rect.Width -= 1;
                rect.Height -= 1;
                using (Pen pen = new Pen(couleurBordure, 2))
                {
                    e.Graphics.DrawRectangle(pen, rect);
                }
            };

            // ComboBox pour choisir le type d'utilisateur
            cmbTypeUtilisateur = new ComboBox
            {
                Font = new Font("Segoe UI", 11),
                Size = new Size(360, 40),
                Location = new Point(10, 7),
                DropDownStyle = ComboBoxStyle.DropDownList,
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.FromArgb(245, 247, 250),
                ForeColor = Color.FromArgb(52, 73, 94),
                Cursor = Cursors.Hand
            };

            // Ajouter les options
            cmbTypeUtilisateur.Items.Add("👤 Chef de Projet");
            cmbTypeUtilisateur.Items.Add("🔐 Administrateur");
            cmbTypeUtilisateur.SelectedIndex = 0;

            // Changement de couleur au focus
            cmbTypeUtilisateur.GotFocus += (s, e) =>
            {
                cmbPanel.BackColor = Color.White;
                cmbPanel.Invalidate();
            };

            cmbTypeUtilisateur.LostFocus += (s, e) =>
            {
                cmbPanel.BackColor = Color.FromArgb(245, 247, 250);
                cmbPanel.Invalidate();
            };

            // Changement de bordure selon le type sélectionné
            cmbTypeUtilisateur.SelectedIndexChanged += (s, e) =>
            {
                if (cmbTypeUtilisateur.SelectedIndex == 1) // Administrateur
                    couleurBordure = Color.FromArgb(231, 76, 60);
                else // Chef de projet
                    couleurBordure = Color.FromArgb(220, 220, 230);

                cmbPanel.Invalidate();
            };

            cmbPanel.Controls.Add(cmbTypeUtilisateur);
            panelDroit.Controls.Add(lblTypeUtilisateur);
            panelDroit.Controls.Add(cmbPanel);
        }

        private void StyliserControlesModernes()
        {
            int yPosition = 250;
            int compteur = 0;

            foreach (Control ctrl in this.Controls.Cast<Control>().ToList())
            {
                if (ctrl is TextBox)
                {
                    TextBox txt = (TextBox)ctrl;
                    txt.Parent = panelDroit;
                    txt.Font = new Font("Segoe UI", 11);
                    txt.Size = new Size(380, 40);
                    txt.Location = new Point(60, yPosition);
                    txt.BorderStyle = BorderStyle.None;

                    // Panel conteneur avec bordure
                    Panel txtPanel = new Panel
                    {
                        Size = new Size(380, 45),
                        Location = new Point(60, yPosition - 2),
                        BackColor = Color.FromArgb(245, 247, 250),
                        Tag = txt
                    };

                    txtPanel.Paint += (s, e) =>
                    {
                        Rectangle rect = txtPanel.ClientRectangle;
                        rect.Width -= 1;
                        rect.Height -= 1;
                        using (Pen pen = new Pen(Color.FromArgb(220, 220, 230), 2))
                        {
                            e.Graphics.DrawRectangle(pen, rect);
                        }
                    };

                    // Label flottant
                    Label lblField = new Label
                    {
                        Text = compteur == 0 ? "👤  Nom d'utilisateur" : "🔒  Mot de passe",
                        Font = new Font("Segoe UI", 9, FontStyle.Regular),
                        ForeColor = Color.FromArgb(100, 100, 120),
                        AutoSize = false,
                        Size = new Size(200, 20),
                        Location = new Point(60, yPosition - 25),
                        BackColor = Color.Transparent
                    };

                    txt.GotFocus += (s, e) =>
                    {
                        Panel p = (Panel)txtPanel;
                        p.BackColor = Color.White;
                        p.Invalidate();
                    };

                    txt.LostFocus += (s, e) =>
                    {
                        Panel p = (Panel)txtPanel;
                        p.BackColor = Color.FromArgb(245, 247, 250);
                        p.Invalidate();
                    };

                    panelDroit.Controls.Add(txtPanel);
                    panelDroit.Controls.Add(lblField);
                    txt.BringToFront();

                    if (compteur == 1)
                    {
                        txt.PasswordChar = '●';
                    }

                    yPosition += 80;
                    compteur++;
                }

                if (ctrl is Button)
                {
                    Button btn = (Button)ctrl;
                    btn.Parent = panelDroit;
                    btn.Font = new Font("Segoe UI", 11, FontStyle.Bold);
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.Cursor = Cursors.Hand;

                    if (btn.Name.Contains("Connecter") || btn.Text.Contains("Connecter"))
                    {
                        btn.Text = "SE CONNECTER";
                        btn.Size = new Size(380, 50);
                        btn.Location = new Point(60, yPosition + 20);
                        btn.BackColor = Color.FromArgb(99, 110, 250);
                        btn.ForeColor = Color.White;
                        btn.FlatAppearance.BorderSize = 0;

                        btn.MouseEnter += (s, e) =>
                        {
                            btn.BackColor = Color.FromArgb(79, 90, 230);
                        };
                        btn.MouseLeave += (s, e) =>
                        {
                            btn.BackColor = Color.FromArgb(99, 110, 250);
                        };
                    }
                    else // Bouton Annuler/Quitter
                    {
                        btn.Text = "ANNULER";
                        btn.Size = new Size(180, 45);
                        btn.Location = new Point(160, yPosition + 85);
                        btn.BackColor = Color.Transparent;
                        btn.ForeColor = Color.FromArgb(120, 120, 120);
                        btn.FlatAppearance.BorderSize = 0;
                        btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 240, 240);
                    }
                }
            }

            // Lien "Mot de passe oublié"
            LinkLabel lnkMotDePasse = new LinkLabel
            {
                Text = "Mot de passe oublié ?",
                Font = new Font("Segoe UI", 9, FontStyle.Regular),
                LinkColor = Color.FromArgb(99, 110, 250),
                ActiveLinkColor = Color.FromArgb(79, 90, 230),
                AutoSize = true,
                Location = new Point(60, yPosition),
                Cursor = Cursors.Hand
            };
            lnkMotDePasse.LinkClicked += (s, e) =>
            {
                MessageBox.Show("Veuillez contacter l'administrateur.", "Récupération de mot de passe",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            };

            panelDroit.Controls.Add(lnkMotDePasse);

            // Copyright
            Label lblCopyright = new Label
            {
                Text = "© 2026 Sen Soutenance. Tous droits réservés.",
                Font = new Font("Segoe UI", 8, FontStyle.Regular),
                ForeColor = Color.FromArgb(160, 160, 160),
                AutoSize = false,
                Size = new Size(400, 20),
                Location = new Point(60, 550),
                TextAlign = ContentAlignment.MiddleLeft
            };
            panelDroit.Controls.Add(lblCopyright);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // ============================================================
        // CONNEXION : ouvre le bon dashboard selon le type sélectionné
        // ============================================================
        private void btnSeConnecter_Click(object sender, EventArgs e)
        {
            // Validation des champs
            bool champsRemplis = true;

            foreach (Control ctrl in panelDroit.Controls)
            {
                if (ctrl is TextBox && string.IsNullOrWhiteSpace(ctrl.Text))
                {
                    champsRemplis = false;
                    ctrl.BackColor = Color.FromArgb(255, 230, 230);
                    Timer resetColor = new Timer { Interval = 2000 };
                    resetColor.Tick += (s, args) =>
                    {
                        ctrl.BackColor = Color.FromArgb(245, 247, 250);
                        resetColor.Stop();
                    };
                    resetColor.Start();
                }
            }

            if (!champsRemplis)
            {
                MessageBox.Show("Veuillez remplir tous les champs !", "Attention",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Déterminer le type d'utilisateur sélectionné
            string typeUtilisateur = cmbTypeUtilisateur.SelectedItem.ToString();

            // Animation de fadeout puis ouvrir le bon dashboard
            Timer fadeOut = new Timer { Interval = 20 };
            fadeOut.Tick += (s, args) =>
            {
                if (this.Opacity > 0)
                {
                    this.Opacity -= 0.05;
                }
                else
                {
                    fadeOut.Stop();

                    Form dashboardForm = null;

                    if (typeUtilisateur.Contains("Administrateur"))
                    {
                        // Ouvre le Dashboard de l'administrateur
                        dashboardForm = new Dashboard_administrateur();
                    }
                    else if (typeUtilisateur.Contains("Chef de Projet"))
                    {
                        // Ouvre le Dashboard du Chef de Projet
                        // Remplacez "frmMDI" par votre classe de dashboard Chef de Projet
                        dashboardForm = new frmMDI();
                    }

                    if (dashboardForm != null)
                    {
                        dashboardForm.Show();
                    }

                    // Cacher la page de connexion
                    this.Hide();
                }
            };
            fadeOut.Start();
        }

        private void frmConnexion_Load(object sender, EventArgs e)
        {
            // Animation d'apparition
            this.Opacity = 0;
            Timer fadeIn = new Timer { Interval = 20 };
            fadeIn.Tick += (s, args) =>
            {
                if (this.Opacity < 1)
                {
                    this.Opacity += 0.05;
                }
                else
                {
                    fadeIn.Stop();
                }
            };
            fadeIn.Start();
        }

        // Import pour coins arrondis
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, int nTopRect, int nRightRect, int nBottomRect,
            int nWidthEllipse, int nHeightEllipse);

        // Permettre le déplacement du formulaire
        private Point mouseLocation;
        private bool mouseDown;

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Y < 60)
            {
                mouseDown = true;
                mouseLocation = e.Location;
            }
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (mouseDown)
            {
                this.Location = new Point(
                    this.Location.X + e.X - mouseLocation.X,
                    this.Location.Y + e.Y - mouseLocation.Y);
            }
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            mouseDown = false;
        }

        private void TxtIdentifiant_TextChanged(object sender, EventArgs e)
        {

        }
    }
}