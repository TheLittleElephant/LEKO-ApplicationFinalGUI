﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp1.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.6.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool MillesimeADateCourante {
            get {
                return ((bool)(this["MillesimeADateCourante"]));
            }
            set {
                this["MillesimeADateCourante"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public int FormatDate {
            get {
                return ((int)(this["FormatDate"]));
            }
            set {
                this["FormatDate"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool DateCouranteADateDuJour {
            get {
                return ((bool)(this["DateCouranteADateDuJour"]));
            }
            set {
                this["DateCouranteADateDuJour"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string EmplacementFichiersClient {
            get {
                return ((string)(this["EmplacementFichiersClient"]));
            }
            set {
                this["EmplacementFichiersClient"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string EmplacementModeles {
            get {
                return ((string)(this["EmplacementModeles"]));
            }
            set {
                this["EmplacementModeles"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string EmplacementFichiersGeneres {
            get {
                return ((string)(this["EmplacementFichiersGeneres"]));
            }
            set {
                this["EmplacementFichiersGeneres"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool EnregistrerFichiersGoogleDrive {
            get {
                return ((bool)(this["EnregistrerFichiersGoogleDrive"]));
            }
            set {
                this["EnregistrerFichiersGoogleDrive"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool EnregistrerFichiersLocal {
            get {
                return ((bool)(this["EnregistrerFichiersLocal"]));
            }
            set {
                this["EnregistrerFichiersLocal"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=lcbd.database.windows.net;Initial Catalog=LCBD;Persist Security Info=" +
            "True;User ID=lcbd")]
        public string LCBDConnectionString {
            get {
                return ((string)(this["LCBDConnectionString"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string BDDNomUtilisateur {
            get {
                return ((string)(this["BDDNomUtilisateur"]));
            }
            set {
                this["BDDNomUtilisateur"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string BDDMotDePasse {
            get {
                return ((string)(this["BDDMotDePasse"]));
            }
            set {
                this["BDDMotDePasse"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string BDDNomHote {
            get {
                return ((string)(this["BDDNomHote"]));
            }
            set {
                this["BDDNomHote"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string BDDNom {
            get {
                return ((string)(this["BDDNom"]));
            }
            set {
                this["BDDNom"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfString xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <string>EI</string>
  <string>EIRL</string>
  <string>EURL</string>
  <string>SA</string>
  <string>SARL</string>
  <string>SAS</string>
  <string>SASU</string>
  <string>SC</string>
  <string>SCA</string>
  <string>SCIC</string>
  <string>SCOP</string>
  <string>SNC</string>
</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection FormesJuridiques {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["FormesJuridiques"]));
            }
            set {
                this["FormesJuridiques"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("{{")]
        public string DelimiteurDebutVariable {
            get {
                return ((string)(this["DelimiteurDebutVariable"]));
            }
            set {
                this["DelimiteurDebutVariable"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("}}")]
        public string DelimiteurFinVariable {
            get {
                return ((string)(this["DelimiteurFinVariable"]));
            }
            set {
                this["DelimiteurFinVariable"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string PathFINACOOP {
            get {
                return ((string)(this["PathFINACOOP"]));
            }
            set {
                this["PathFINACOOP"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("smtp.gmail.com")]
        public string SMTP {
            get {
                return ((string)(this["SMTP"]));
            }
            set {
                this["SMTP"] = value;
            }
        }
    }
}
