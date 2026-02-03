using System;
using System.Windows.Forms;

namespace AppSenSoutenance2.Views.Parametre
{
    partial class frmProfesseur
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
            this.label1 = new System.Windows.Forms.Label();
            this.NomduProfesseur = new System.Windows.Forms.Label();
            this.Mailprofesseur = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Soutenances = new System.Windows.Forms.TextBox();
            this.Jury = new System.Windows.Forms.TextBox();
            this.Sujets = new System.Windows.Forms.TextBox();
            this.Candidatures = new System.Windows.Forms.TextBox();
            this.Memoire = new System.Windows.Forms.TextBox();
            this.Vuedensemble = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.GrandPanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnRefuser_Tutorat_Etudiant = new System.Windows.Forms.Button();
            this.btnAccepter_Tutorat_Etudiant = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nom_etudiant_tutorat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sujet_tutorat_etudiant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Decision_tutorat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.nombresoutenanceavenir = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.NombreCandidatureAttente = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.GrandPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(22, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Professeur";
            // 
            // NomduProfesseur
            // 
            this.NomduProfesseur.AutoSize = true;
            this.NomduProfesseur.Location = new System.Drawing.Point(80, 20);
            this.NomduProfesseur.Name = "NomduProfesseur";
            this.NomduProfesseur.Size = new System.Drawing.Size(107, 16);
            this.NomduProfesseur.TabIndex = 1;
            this.NomduProfesseur.Text = "NomPrenomProf";
            // 
            // Mailprofesseur
            // 
            this.Mailprofesseur.AutoSize = true;
            this.Mailprofesseur.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Mailprofesseur.Location = new System.Drawing.Point(80, 49);
            this.Mailprofesseur.Name = "Mailprofesseur";
            this.Mailprofesseur.Size = new System.Drawing.Size(126, 16);
            this.Mailprofesseur.TabIndex = 2;
            this.Mailprofesseur.Text = "professeur@univ.sn";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Soutenances);
            this.panel1.Controls.Add(this.Jury);
            this.panel1.Controls.Add(this.Sujets);
            this.panel1.Controls.Add(this.Candidatures);
            this.panel1.Controls.Add(this.Memoire);
            this.panel1.Controls.Add(this.Vuedensemble);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(243, 566);
            this.panel1.TabIndex = 3;
            // 
            // Soutenances
            // 
            this.Soutenances.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Soutenances.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Soutenances.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Soutenances.Location = new System.Drawing.Point(25, 477);
            this.Soutenances.Multiline = true;
            this.Soutenances.Name = "Soutenances";
            this.Soutenances.Size = new System.Drawing.Size(196, 44);
            this.Soutenances.TabIndex = 7;
            this.Soutenances.Text = "Soutenances";
            this.Soutenances.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Soutenances.TextChanged += new System.EventHandler(this.Soutenances_TextChanged);
            // 
            // Jury
            // 
            this.Jury.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Jury.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Jury.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Jury.Location = new System.Drawing.Point(25, 416);
            this.Jury.Multiline = true;
            this.Jury.Name = "Jury";
            this.Jury.Size = new System.Drawing.Size(196, 44);
            this.Jury.TabIndex = 6;
            this.Jury.Text = "Jury";
            this.Jury.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Jury.TextChanged += new System.EventHandler(this.Jury_TextChanged);
            // 
            // Sujets
            // 
            this.Sujets.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Sujets.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sujets.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Sujets.Location = new System.Drawing.Point(25, 355);
            this.Sujets.Multiline = true;
            this.Sujets.Name = "Sujets";
            this.Sujets.Size = new System.Drawing.Size(196, 44);
            this.Sujets.TabIndex = 5;
            this.Sujets.Text = "Sujets";
            this.Sujets.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Sujets.TextChanged += new System.EventHandler(this.Sujets_TextChanged);
            // 
            // Candidatures
            // 
            this.Candidatures.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Candidatures.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Candidatures.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Candidatures.Location = new System.Drawing.Point(25, 294);
            this.Candidatures.Multiline = true;
            this.Candidatures.Name = "Candidatures";
            this.Candidatures.Size = new System.Drawing.Size(196, 44);
            this.Candidatures.TabIndex = 4;
            this.Candidatures.Text = "Candidatures";
            this.Candidatures.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Candidatures.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Memoire
            // 
            this.Memoire.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Memoire.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Memoire.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Memoire.Location = new System.Drawing.Point(25, 233);
            this.Memoire.Multiline = true;
            this.Memoire.Name = "Memoire";
            this.Memoire.Size = new System.Drawing.Size(196, 44);
            this.Memoire.TabIndex = 3;
            this.Memoire.Text = "Mémoires";
            this.Memoire.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Memoire.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Vuedensemble
            // 
            this.Vuedensemble.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Vuedensemble.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Vuedensemble.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Vuedensemble.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Vuedensemble.Location = new System.Drawing.Point(25, 172);
            this.Vuedensemble.Multiline = true;
            this.Vuedensemble.Name = "Vuedensemble";
            this.Vuedensemble.Size = new System.Drawing.Size(196, 44);
            this.Vuedensemble.TabIndex = 2;
            this.Vuedensemble.Text = "Tableau de bord";
            this.Vuedensemble.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Vuedensemble.TextChanged += new System.EventHandler(this.Vuedensemble_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.NomduProfesseur);
            this.panel2.Controls.Add(this.Mailprofesseur);
            this.panel2.Location = new System.Drawing.Point(4, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(238, 89);
            this.panel2.TabIndex = 1;
            // 
            // GrandPanel
            // 
            this.GrandPanel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.GrandPanel.Controls.Add(this.panel3);
            this.GrandPanel.Controls.Add(this.panel5);
            this.GrandPanel.Controls.Add(this.panel4);
            this.GrandPanel.Controls.Add(this.label4);
            this.GrandPanel.Location = new System.Drawing.Point(243, 0);
            this.GrandPanel.Name = "GrandPanel";
            this.GrandPanel.Size = new System.Drawing.Size(861, 566);
            this.GrandPanel.TabIndex = 4;
            this.GrandPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.nombrecandidatureenattente_Paint);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel3.Controls.Add(this.btnRefuser_Tutorat_Etudiant);
            this.panel3.Controls.Add(this.btnAccepter_Tutorat_Etudiant);
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(52, 209);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(661, 312);
            this.panel3.TabIndex = 3;
            // 
            // btnRefuser_Tutorat_Etudiant
            // 
            this.btnRefuser_Tutorat_Etudiant.BackColor = System.Drawing.Color.Red;
            this.btnRefuser_Tutorat_Etudiant.Location = new System.Drawing.Point(570, 74);
            this.btnRefuser_Tutorat_Etudiant.Name = "btnRefuser_Tutorat_Etudiant";
            this.btnRefuser_Tutorat_Etudiant.Size = new System.Drawing.Size(75, 23);
            this.btnRefuser_Tutorat_Etudiant.TabIndex = 3;
            this.btnRefuser_Tutorat_Etudiant.Text = "Refuser";
            this.btnRefuser_Tutorat_Etudiant.UseVisualStyleBackColor = false;
            // 
            // btnAccepter_Tutorat_Etudiant
            // 
            this.btnAccepter_Tutorat_Etudiant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAccepter_Tutorat_Etudiant.Location = new System.Drawing.Point(452, 74);
            this.btnAccepter_Tutorat_Etudiant.Name = "btnAccepter_Tutorat_Etudiant";
            this.btnAccepter_Tutorat_Etudiant.Size = new System.Drawing.Size(75, 23);
            this.btnAccepter_Tutorat_Etudiant.TabIndex = 2;
            this.btnAccepter_Tutorat_Etudiant.Text = "Accepter";
            this.btnAccepter_Tutorat_Etudiant.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nom_etudiant_tutorat,
            this.Sujet_tutorat_etudiant,
            this.Decision_tutorat});
            this.dataGridView1.Location = new System.Drawing.Point(8, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(650, 213);
            this.dataGridView1.TabIndex = 1;
            // 
            // nom_etudiant_tutorat
            // 
            this.nom_etudiant_tutorat.HeaderText = "Nom Etudiant";
            this.nom_etudiant_tutorat.MinimumWidth = 6;
            this.nom_etudiant_tutorat.Name = "nom_etudiant_tutorat";
            // 
            // Sujet_tutorat_etudiant
            // 
            this.Sujet_tutorat_etudiant.HeaderText = "Sujet";
            this.Sujet_tutorat_etudiant.MinimumWidth = 6;
            this.Sujet_tutorat_etudiant.Name = "Sujet_tutorat_etudiant";
            // 
            // Decision_tutorat
            // 
            this.Decision_tutorat.HeaderText = "Décision";
            this.Decision_tutorat.MinimumWidth = 6;
            this.Decision_tutorat.Name = "Decision_tutorat";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(236, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Liste des demandes de tutorat";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel5.Controls.Add(this.nombresoutenanceavenir);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Location = new System.Drawing.Point(457, 63);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(240, 100);
            this.panel5.TabIndex = 2;
            // 
            // nombresoutenanceavenir
            // 
            this.nombresoutenanceavenir.AutoSize = true;
            this.nombresoutenanceavenir.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombresoutenanceavenir.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.nombresoutenanceavenir.Location = new System.Drawing.Point(101, 20);
            this.nombresoutenanceavenir.Name = "nombresoutenanceavenir";
            this.nombresoutenanceavenir.Size = new System.Drawing.Size(46, 32);
            this.nombresoutenanceavenir.TabIndex = 1;
            this.nombresoutenanceavenir.Text = "13";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(65, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Soutenance à venir";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel4.Controls.Add(this.NombreCandidatureAttente);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(52, 63);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(240, 100);
            this.panel4.TabIndex = 1;
            // 
            // NombreCandidatureAttente
            // 
            this.NombreCandidatureAttente.AutoSize = true;
            this.NombreCandidatureAttente.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreCandidatureAttente.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.NombreCandidatureAttente.Location = new System.Drawing.Point(101, 20);
            this.NombreCandidatureAttente.Name = "NombreCandidatureAttente";
            this.NombreCandidatureAttente.Size = new System.Drawing.Size(30, 32);
            this.NombreCandidatureAttente.TabIndex = 1;
            this.NombreCandidatureAttente.Text = "3";
            this.NombreCandidatureAttente.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Candidatures en attente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(280, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tableau de bord Professeur";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // frmProfesseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1104, 566);
            this.ControlBox = false;
            this.Controls.Add(this.GrandPanel);
            this.Controls.Add(this.panel1);
            this.Name = "frmProfesseur";
            this.Text = "Professeur";
            this.Load += new System.EventHandler(this.frmProfesseur_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.GrandPanel.ResumeLayout(false);
            this.GrandPanel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }
        private void label4_Click(object sender, EventArgs e) { }
        private void Soutenances_TextChanged(object sender, EventArgs e) { }
        private void Jury_TextChanged(object sender, EventArgs e) { }
        private void Sujets_TextChanged(object sender, EventArgs e) { }
        private void textBox3_TextChanged(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void Vuedensemble_TextChanged(object sender, EventArgs e) { }
        private void nombrecandidatureenattente_Paint(object sender, PaintEventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label NomduProfesseur;
        private System.Windows.Forms.Label Mailprofesseur;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox Vuedensemble;
        private System.Windows.Forms.TextBox Candidatures;
        private System.Windows.Forms.TextBox Memoire;
        private System.Windows.Forms.TextBox Soutenances;
        private System.Windows.Forms.TextBox Jury;
        private System.Windows.Forms.TextBox Sujets;
        private System.Windows.Forms.Panel GrandPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label NombreCandidatureAttente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label nombresoutenanceavenir;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom_etudiant_tutorat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sujet_tutorat_etudiant;
        private System.Windows.Forms.DataGridViewTextBoxColumn Decision_tutorat;
        private System.Windows.Forms.Button btnAccepter_Tutorat_Etudiant;
        private System.Windows.Forms.Button btnRefuser_Tutorat_Etudiant;
    }
}