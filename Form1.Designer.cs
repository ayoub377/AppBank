
namespace AppBank
{
    partial class Form1
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionCompteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterCompteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateCompteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeviseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(351, 268);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(150, 100);
            this.splitContainer1.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionClientToolStripMenuItem,
            this.gestionCompteToolStripMenuItem,
            this.gestionDeviseToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(73, 29);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // gestionClientToolStripMenuItem
            // 
            this.gestionClientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.updateToolStripMenuItem});
            this.gestionClientToolStripMenuItem.Name = "gestionClientToolStripMenuItem";
            this.gestionClientToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.gestionClientToolStripMenuItem.Text = "Gestion Client";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(172, 34);
            this.addToolStripMenuItem.Text = "Add ";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(172, 34);
            this.updateToolStripMenuItem.Text = "Update";
            // 
            // gestionCompteToolStripMenuItem
            // 
            this.gestionCompteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterCompteToolStripMenuItem,
            this.updateCompteToolStripMenuItem});
            this.gestionCompteToolStripMenuItem.Name = "gestionCompteToolStripMenuItem";
            this.gestionCompteToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.gestionCompteToolStripMenuItem.Text = "Gestion Compte";
            // 
            // ajouterCompteToolStripMenuItem
            // 
            this.ajouterCompteToolStripMenuItem.Name = "ajouterCompteToolStripMenuItem";
            this.ajouterCompteToolStripMenuItem.Size = new System.Drawing.Size(238, 34);
            this.ajouterCompteToolStripMenuItem.Text = "Ajouter compte";
            // 
            // updateCompteToolStripMenuItem
            // 
            this.updateCompteToolStripMenuItem.Name = "updateCompteToolStripMenuItem";
            this.updateCompteToolStripMenuItem.Size = new System.Drawing.Size(238, 34);
            this.updateCompteToolStripMenuItem.Text = "Update compte";
            // 
            // gestionDeviseToolStripMenuItem
            // 
            this.gestionDeviseToolStripMenuItem.Name = "gestionDeviseToolStripMenuItem";
            this.gestionDeviseToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.gestionDeviseToolStripMenuItem.Text = "Gestion Devise";
            this.gestionDeviseToolStripMenuItem.Click += new System.EventHandler(this.gestionDeviseToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "AppBank";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionCompteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeviseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterCompteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateCompteToolStripMenuItem;
    }
}

