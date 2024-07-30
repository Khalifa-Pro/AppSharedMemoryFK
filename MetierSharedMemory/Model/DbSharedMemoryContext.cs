using MySql.Data.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.OleDb;
using System.Linq;
using System.Web;

namespace MetierSharedMemory.Model
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class DbSharedMemoryContext: DbContext
    {
        
        public DbSharedMemoryContext() : base("connGp2SharedMemory")
        {

        }

        public DbSet<Personne> personnes { get; set; }
        public DbSet<Encadreur> encadreurs { get; set; }
        public DbSet<MembreJury> membreJurys { get; set; }
        public DbSet<Memoire> memoires { get; set; }
        public DbSet<Utilisateur> utilisateurs { get;set; }
        public DbSet<ResponsableBibliotheque> responsableBibliotheques { get; set; }
        public DbSet<Lecteur> lecteurs { get; set; }
        public DbSet<Expert> experts { get; set; }
        public DbSet<LectureMemoire> lectureMemoires { get; set; }
        public DbSet<Commentaire> commentaires { get; set; }

    }
}