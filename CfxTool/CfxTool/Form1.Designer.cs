namespace CfxTool
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.RedmToAzerty = new System.Windows.Forms.Button();
            this.ClearCacheRedm = new System.Windows.Forms.Button();
            this.ClearCacheFivem = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.LaunchFivem = new System.Windows.Forms.Button();
            this.LaunchRedm = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.propriétésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cheminDeRedMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurerLeCheminDeRedMToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.voirLeCheminActuelDeRedMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.remettreLeCheminDeRedMParDéfautToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cheminDeFiveMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurerLeCheminDeFiveMToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.voirLeCheminActuelDeFiveMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.réinitialiserLeCheminDeFiveMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ouvrirLeDossierRedMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ouvrirLeDossierFiveMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.codeSourceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ouvrirLeFichierRedMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ouvrirLeFichierFiveMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RedmToAzerty
            // 
            this.RedmToAzerty.BackColor = System.Drawing.Color.LightPink;
            this.RedmToAzerty.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.RedmToAzerty, "RedmToAzerty");
            this.RedmToAzerty.Name = "RedmToAzerty";
            this.RedmToAzerty.UseVisualStyleBackColor = false;
            this.RedmToAzerty.Click += new System.EventHandler(this.RedmToAzerty_Click);
            // 
            // ClearCacheRedm
            // 
            this.ClearCacheRedm.BackColor = System.Drawing.Color.LightPink;
            resources.ApplyResources(this.ClearCacheRedm, "ClearCacheRedm");
            this.ClearCacheRedm.Name = "ClearCacheRedm";
            this.ClearCacheRedm.UseVisualStyleBackColor = false;
            this.ClearCacheRedm.Click += new System.EventHandler(this.ClearCacheRedm_Click);
            // 
            // ClearCacheFivem
            // 
            this.ClearCacheFivem.BackColor = System.Drawing.Color.Plum;
            this.ClearCacheFivem.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.ClearCacheFivem, "ClearCacheFivem");
            this.ClearCacheFivem.Name = "ClearCacheFivem";
            this.ClearCacheFivem.UseVisualStyleBackColor = false;
            this.ClearCacheFivem.Click += new System.EventHandler(this.ClearCacheFivem_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.BackColor = System.Drawing.Color.Pink;
            this.maskedTextBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            resources.ApplyResources(this.maskedTextBox1, "maskedTextBox1");
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.ReadOnly = true;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.BackColor = System.Drawing.Color.Violet;
            this.maskedTextBox2.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.maskedTextBox2, "maskedTextBox2");
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.ReadOnly = true;
            // 
            // LaunchFivem
            // 
            this.LaunchFivem.BackColor = System.Drawing.Color.Plum;
            this.LaunchFivem.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.LaunchFivem, "LaunchFivem");
            this.LaunchFivem.Name = "LaunchFivem";
            this.LaunchFivem.UseVisualStyleBackColor = false;
            this.LaunchFivem.Click += new System.EventHandler(this.LaunchFivem_Click);
            // 
            // LaunchRedm
            // 
            this.LaunchRedm.BackColor = System.Drawing.Color.LightPink;
            this.LaunchRedm.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.LaunchRedm, "LaunchRedm");
            this.LaunchRedm.Name = "LaunchRedm";
            this.LaunchRedm.UseVisualStyleBackColor = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.propriétésToolStripMenuItem,
            this.aProposToolStripMenuItem,
            this.codeSourceToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // propriétésToolStripMenuItem
            // 
            this.propriétésToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cheminDeRedMToolStripMenuItem,
            this.cheminDeFiveMToolStripMenuItem,
            this.ouvrirLeDossierRedMToolStripMenuItem,
            this.ouvrirLeDossierFiveMToolStripMenuItem});
            this.propriétésToolStripMenuItem.Name = "propriétésToolStripMenuItem";
            resources.ApplyResources(this.propriétésToolStripMenuItem, "propriétésToolStripMenuItem");
            // 
            // cheminDeRedMToolStripMenuItem
            // 
            this.cheminDeRedMToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configurerLeCheminDeRedMToolStripMenuItem2,
            this.voirLeCheminActuelDeRedMToolStripMenuItem,
            this.remettreLeCheminDeRedMParDéfautToolStripMenuItem});
            this.cheminDeRedMToolStripMenuItem.Name = "cheminDeRedMToolStripMenuItem";
            resources.ApplyResources(this.cheminDeRedMToolStripMenuItem, "cheminDeRedMToolStripMenuItem");
            // 
            // configurerLeCheminDeRedMToolStripMenuItem2
            // 
            this.configurerLeCheminDeRedMToolStripMenuItem2.Name = "configurerLeCheminDeRedMToolStripMenuItem2";
            resources.ApplyResources(this.configurerLeCheminDeRedMToolStripMenuItem2, "configurerLeCheminDeRedMToolStripMenuItem2");
            this.configurerLeCheminDeRedMToolStripMenuItem2.Click += new System.EventHandler(this.configurerLeCheminDeRedMToolStripMenuItem2_Click);
            // 
            // voirLeCheminActuelDeRedMToolStripMenuItem
            // 
            this.voirLeCheminActuelDeRedMToolStripMenuItem.Name = "voirLeCheminActuelDeRedMToolStripMenuItem";
            resources.ApplyResources(this.voirLeCheminActuelDeRedMToolStripMenuItem, "voirLeCheminActuelDeRedMToolStripMenuItem");
            this.voirLeCheminActuelDeRedMToolStripMenuItem.Click += new System.EventHandler(this.voirLeCheminActuelDeRedMToolStripMenuItem_Click);
            // 
            // remettreLeCheminDeRedMParDéfautToolStripMenuItem
            // 
            this.remettreLeCheminDeRedMParDéfautToolStripMenuItem.Name = "remettreLeCheminDeRedMParDéfautToolStripMenuItem";
            resources.ApplyResources(this.remettreLeCheminDeRedMParDéfautToolStripMenuItem, "remettreLeCheminDeRedMParDéfautToolStripMenuItem");
            this.remettreLeCheminDeRedMParDéfautToolStripMenuItem.Click += new System.EventHandler(this.remettreLeCheminDeRedMParDéfautToolStripMenuItem_Click);
            // 
            // cheminDeFiveMToolStripMenuItem
            // 
            this.cheminDeFiveMToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configurerLeCheminDeFiveMToolStripMenuItem1,
            this.voirLeCheminActuelDeFiveMToolStripMenuItem,
            this.réinitialiserLeCheminDeFiveMToolStripMenuItem});
            this.cheminDeFiveMToolStripMenuItem.Name = "cheminDeFiveMToolStripMenuItem";
            resources.ApplyResources(this.cheminDeFiveMToolStripMenuItem, "cheminDeFiveMToolStripMenuItem");
            // 
            // configurerLeCheminDeFiveMToolStripMenuItem1
            // 
            this.configurerLeCheminDeFiveMToolStripMenuItem1.Name = "configurerLeCheminDeFiveMToolStripMenuItem1";
            resources.ApplyResources(this.configurerLeCheminDeFiveMToolStripMenuItem1, "configurerLeCheminDeFiveMToolStripMenuItem1");
            this.configurerLeCheminDeFiveMToolStripMenuItem1.Click += new System.EventHandler(this.configurerLeCheminDeFiveMToolStripMenuItem1_Click);
            // 
            // voirLeCheminActuelDeFiveMToolStripMenuItem
            // 
            this.voirLeCheminActuelDeFiveMToolStripMenuItem.Name = "voirLeCheminActuelDeFiveMToolStripMenuItem";
            resources.ApplyResources(this.voirLeCheminActuelDeFiveMToolStripMenuItem, "voirLeCheminActuelDeFiveMToolStripMenuItem");
            this.voirLeCheminActuelDeFiveMToolStripMenuItem.Click += new System.EventHandler(this.voirLeCheminActuelDeFiveMToolStripMenuItem_Click);
            // 
            // réinitialiserLeCheminDeFiveMToolStripMenuItem
            // 
            this.réinitialiserLeCheminDeFiveMToolStripMenuItem.Name = "réinitialiserLeCheminDeFiveMToolStripMenuItem";
            resources.ApplyResources(this.réinitialiserLeCheminDeFiveMToolStripMenuItem, "réinitialiserLeCheminDeFiveMToolStripMenuItem");
            this.réinitialiserLeCheminDeFiveMToolStripMenuItem.Click += new System.EventHandler(this.réinitialiserLeCheminDeFiveMToolStripMenuItem_Click);
            // 
            // ouvrirLeDossierRedMToolStripMenuItem
            // 
            this.ouvrirLeDossierRedMToolStripMenuItem.Name = "ouvrirLeDossierRedMToolStripMenuItem";
            resources.ApplyResources(this.ouvrirLeDossierRedMToolStripMenuItem, "ouvrirLeDossierRedMToolStripMenuItem");
            this.ouvrirLeDossierRedMToolStripMenuItem.Click += new System.EventHandler(this.ouvrirLeDossierRedMToolStripMenuItem_Click);
            // 
            // ouvrirLeDossierFiveMToolStripMenuItem
            // 
            this.ouvrirLeDossierFiveMToolStripMenuItem.Name = "ouvrirLeDossierFiveMToolStripMenuItem";
            resources.ApplyResources(this.ouvrirLeDossierFiveMToolStripMenuItem, "ouvrirLeDossierFiveMToolStripMenuItem");
            this.ouvrirLeDossierFiveMToolStripMenuItem.Click += new System.EventHandler(this.ouvrirLeDossierFiveMToolStripMenuItem_Click);
            // 
            // aProposToolStripMenuItem
            // 
            this.aProposToolStripMenuItem.Name = "aProposToolStripMenuItem";
            resources.ApplyResources(this.aProposToolStripMenuItem, "aProposToolStripMenuItem");
            this.aProposToolStripMenuItem.Click += new System.EventHandler(this.aProposToolStripMenuItem_Click);
            // 
            // codeSourceToolStripMenuItem
            // 
            this.codeSourceToolStripMenuItem.Name = "codeSourceToolStripMenuItem";
            resources.ApplyResources(this.codeSourceToolStripMenuItem, "codeSourceToolStripMenuItem");
            this.codeSourceToolStripMenuItem.Click += new System.EventHandler(this.codeSourceToolStripMenuItem_Click);
            // 
            // ouvrirLeFichierRedMToolStripMenuItem
            // 
            this.ouvrirLeFichierRedMToolStripMenuItem.Name = "ouvrirLeFichierRedMToolStripMenuItem";
            resources.ApplyResources(this.ouvrirLeFichierRedMToolStripMenuItem, "ouvrirLeFichierRedMToolStripMenuItem");
            // 
            // ouvrirLeFichierFiveMToolStripMenuItem
            // 
            this.ouvrirLeFichierFiveMToolStripMenuItem.Name = "ouvrirLeFichierFiveMToolStripMenuItem";
            resources.ApplyResources(this.ouvrirLeFichierFiveMToolStripMenuItem, "ouvrirLeFichierFiveMToolStripMenuItem");
            // 
            // progressBar
            // 
            resources.ApplyResources(this.progressBar, "progressBar");
            this.progressBar.Name = "progressBar";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.LaunchRedm);
            this.Controls.Add(this.LaunchFivem);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.ClearCacheFivem);
            this.Controls.Add(this.ClearCacheRedm);
            this.Controls.Add(this.RedmToAzerty);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RedmToAzerty;
        private System.Windows.Forms.Button ClearCacheRedm;
        private System.Windows.Forms.Button ClearCacheFivem;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.Button LaunchFivem;
        private System.Windows.Forms.Button LaunchRedm;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem propriétésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ouvrirLeFichierRedMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ouvrirLeFichierFiveMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ouvrirLeDossierRedMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ouvrirLeDossierFiveMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aProposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cheminDeRedMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurerLeCheminDeRedMToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem voirLeCheminActuelDeRedMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cheminDeFiveMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurerLeCheminDeFiveMToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem voirLeCheminActuelDeFiveMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem remettreLeCheminDeRedMParDéfautToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem réinitialiserLeCheminDeFiveMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem codeSourceToolStripMenuItem;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}

