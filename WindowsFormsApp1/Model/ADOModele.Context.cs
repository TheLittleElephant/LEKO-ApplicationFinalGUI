﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LettreCooperation.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class LCBDEntities3 : DbContext
    {
        public LCBDEntities3()
            : base("name=LCBDEntities3")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Adresse> Adresse { get; set; }
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Droit> Droit { get; set; }
        public virtual DbSet<Etat> Etat { get; set; }
        public virtual DbSet<LC> LC { get; set; }
        public virtual DbSet<Modele> Modele { get; set; }
        public virtual DbSet<Utilisateur> Utilisateur { get; set; }
    }
}
