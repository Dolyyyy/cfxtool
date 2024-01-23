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
            this.SuspendLayout();
            // 
            // RedmToAzerty
            // 
            resources.ApplyResources(this.RedmToAzerty, "RedmToAzerty");
            this.RedmToAzerty.Name = "RedmToAzerty";
            this.RedmToAzerty.UseVisualStyleBackColor = true;
            this.RedmToAzerty.Click += new System.EventHandler(this.RedmToAzerty_Click);
            // 
            // ClearCacheRedm
            // 
            resources.ApplyResources(this.ClearCacheRedm, "ClearCacheRedm");
            this.ClearCacheRedm.Name = "ClearCacheRedm";
            this.ClearCacheRedm.UseVisualStyleBackColor = true;
            this.ClearCacheRedm.Click += new System.EventHandler(this.ClearCacheRedm_Click);
            // 
            // ClearCacheFivem
            // 
            resources.ApplyResources(this.ClearCacheFivem, "ClearCacheFivem");
            this.ClearCacheFivem.Name = "ClearCacheFivem";
            this.ClearCacheFivem.UseVisualStyleBackColor = true;
            this.ClearCacheFivem.Click += new System.EventHandler(this.ClearCacheFivem_Click);
            // 
            // maskedTextBox1
            // 
            resources.ApplyResources(this.maskedTextBox1, "maskedTextBox1");
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.ReadOnly = true;
            // 
            // maskedTextBox2
            // 
            resources.ApplyResources(this.maskedTextBox2, "maskedTextBox2");
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.ReadOnly = true;
            // 
            // LaunchFivem
            // 
            resources.ApplyResources(this.LaunchFivem, "LaunchFivem");
            this.LaunchFivem.Name = "LaunchFivem";
            this.LaunchFivem.UseVisualStyleBackColor = true;
            this.LaunchFivem.Click += new System.EventHandler(this.LaunchFivem_Click);
            // 
            // LaunchRedm
            // 
            resources.ApplyResources(this.LaunchRedm, "LaunchRedm");
            this.LaunchRedm.Name = "LaunchRedm";
            this.LaunchRedm.UseVisualStyleBackColor = true;
            this.LaunchRedm.Click += new System.EventHandler(this.LaunchRedm_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LaunchRedm);
            this.Controls.Add(this.LaunchFivem);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.ClearCacheFivem);
            this.Controls.Add(this.ClearCacheRedm);
            this.Controls.Add(this.RedmToAzerty);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
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
    }
}

