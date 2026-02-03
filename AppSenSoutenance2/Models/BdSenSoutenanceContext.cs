using MySql.Data.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSenSoutenance2.Models
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class BdSenSoutenanceContext : DbContext
    {
        public BdSenSoutenanceContext() : base("connBdSenSoutenance") { }

        // Table déjà existante
        public DbSet<AnneeAcademique> anneeAcademiques { get; set; }

        // === Tables à rajouter ===
        public DbSet<Utilisateur> Utilisateurs { get; set; }
        public DbSet<Professeur> Professeurs { get; set; }
        public DbSet<ChefDepartement> ChefsDepartement { get; set; }
        public DbSet<Candidat> Candidats { get; set; }
        public DbSet<Admin> Admins { get; set; }
    }

    // ===== ENTITÉS =====

    public class Utilisateur
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public string Tel { get; set; }
        public string Mdp { get; set; }

        // Navigation
        public virtual Professeur Professeur { get; set; }
        public virtual ChefDepartement ChefDepartement { get; set; }
        public virtual Candidat Candidat { get; set; }
        public virtual Admin Admin { get; set; }
    }

    public class Professeur
    {
        public int Id { get; set; } // correspond à Utilisateur.Id
        public string Specialisation { get; set; }

        public virtual Utilisateur Utilisateur { get; set; }
    }

    public class ChefDepartement
    {
        public int Id { get; set; } // correspond à Utilisateur.Id
        public string Departement { get; set; }

        public virtual Utilisateur Utilisateur { get; set; }
    }

    public class Candidat
    {
        public int Id { get; set; } // correspond à Utilisateur.Id
        public string Matricule { get; set; }

        public virtual Utilisateur Utilisateur { get; set; }
    }

    public class Admin
    {
        public int Id { get; set; } // correspond à Utilisateur.Id

        public virtual Utilisateur Utilisateur { get; set; }
    }
}
