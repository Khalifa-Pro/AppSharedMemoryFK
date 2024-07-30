namespace NotificationL3glGroupe2
{
    partial class ProjectInstaller
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.NotificationL3GL = new System.ServiceProcess.ServiceProcessInstaller();
            this.serviceInstaller1 = new System.ServiceProcess.ServiceInstaller();
            // 
            // NotificationL3GL
            // 
            this.NotificationL3GL.Account = System.ServiceProcess.ServiceAccount.LocalService;
            this.NotificationL3GL.Password = null;
            this.NotificationL3GL.Username = null;
            this.NotificationL3GL.AfterInstall += new System.Configuration.Install.InstallEventHandler(this.serviceProcessInstaller1_AfterInstall);
            // 
            // serviceInstaller1
            // 
            this.serviceInstaller1.ServiceName = "NotificationL3GL";
            // 
            // ProjectInstaller
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.NotificationL3GL,
            this.serviceInstaller1});

        }

        #endregion

        private System.ServiceProcess.ServiceProcessInstaller NotificationL3GL;
        private System.ServiceProcess.ServiceInstaller serviceInstaller1;
    }
}