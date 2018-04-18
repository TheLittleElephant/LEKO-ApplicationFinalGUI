//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp1.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Client
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Client()
        {
            this.LC = new HashSet<LC>();
        }
    
        public int id_client { get; set; }
        public string siret { get; set; }
        public string forme_juridique { get; set; }
        public string raison_sociale { get; set; }
        public Nullable<double> CA { get; set; }
        public int effectifs { get; set; }
        public string organisation_comptable { get; set; }
        public Nullable<double> volume_annuel { get; set; }
        public Nullable<System.DateTime> date_immatriculation { get; set; }
        public string lieu_immatriculation { get; set; }
        public string nom_referent { get; set; }
        public string prenom_referent { get; set; }
        public string fonction_referent { get; set; }
        public string sexe_referent { get; set; }
        public Nullable<int> id_activite { get; set; }
        public int id_adresse { get; set; }
        public string site_web { get; set; }
        public Nullable<bool> ESS { get; set; }
        public string tel_fix { get; set; }
        public string tel_portable { get; set; }
        public Nullable<int> id_statut { get; set; }
        public string mail_referent { get; set; }
    
        public virtual Activite Activite { get; set; }
        public virtual Adresse Adresse { get; set; }
        public virtual Statut Statut { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LC> LC { get; set; }
    }
}
