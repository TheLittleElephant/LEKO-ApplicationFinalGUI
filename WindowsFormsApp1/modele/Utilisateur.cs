//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp1.modele
{
    using System;
    using System.Collections.Generic;
    
    public partial class Utilisateur
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Utilisateur()
        {
            this.LC = new HashSet<LC>();
        }
    
        public int id_utilisateur { get; set; }
        public string nom_utilisateur { get; set; }
        public string prenom_utilisateur { get; set; }
        public string email_utilisateur { get; set; }
        public int id_droit { get; set; }
        public string mdp_utilisateur { get; set; }
        public bool isAdmin { get; set; }
    
        public virtual Droit Droit { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LC> LC { get; set; }
    }
}
