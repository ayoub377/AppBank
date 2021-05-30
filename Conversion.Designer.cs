
namespace AppBank
{
    partial class Conversion
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
            this.usd = new System.Windows.Forms.TextBox();
            this.Mad = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.choix1 = new System.Windows.Forms.ComboBox();
            this.choix2 = new System.Windows.Forms.ComboBox();
            this.retour = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usd
            // 
            this.usd.Location = new System.Drawing.Point(185, 90);
            this.usd.Name = "usd";
            this.usd.Size = new System.Drawing.Size(100, 26);
            this.usd.TabIndex = 1;
            this.usd.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Mad
            // 
            this.Mad.Location = new System.Drawing.Point(185, 151);
            this.Mad.Name = "Mad";
            this.Mad.Size = new System.Drawing.Size(100, 26);
            this.Mad.TabIndex = 3;
            this.Mad.TextChanged += new System.EventHandler(this.Mad_TextChanged);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(98, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 30);
            this.button1.TabIndex = 8;
            this.button1.Text = "Convertir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // choix1
            // 
            this.choix1.FormattingEnabled = true;
            this.choix1.Items.AddRange(new object[] {
            "USD",
            "EURO",
            "MAD"});
            this.choix1.Location = new System.Drawing.Point(33, 88);
            this.choix1.Name = "choix1";
            this.choix1.Size = new System.Drawing.Size(121, 28);
            this.choix1.TabIndex = 9;
            // 
            // choix2
            // 
            this.choix2.FormattingEnabled = true;
            this.choix2.Items.AddRange(new object[] {
            "USD",
            "EURO",
            "MAD"});
            this.choix2.Location = new System.Drawing.Point(33, 149);
            this.choix2.Name = "choix2";
            this.choix2.Size = new System.Drawing.Size(121, 28);
            this.choix2.TabIndex = 10;
            // 
            // retour
            // 
            this.retour.AutoSize = true;
            this.retour.Location = new System.Drawing.Point(354, 261);
            this.retour.Name = "retour";
            this.retour.Size = new System.Drawing.Size(145, 30);
            this.retour.TabIndex = 11;
            this.retour.Text = "Retour vers Menu";
            this.retour.UseVisualStyleBackColor = true;
            this.retour.Click += new System.EventHandler(this.retour_Click);
            // 
            // Conversion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.retour);
            this.Controls.Add(this.choix2);
            this.Controls.Add(this.choix1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Mad);
            this.Controls.Add(this.usd);
            this.Name = "Conversion";
            this.Text = "Conversion";
            this.Load += new System.EventHandler(this.Conversion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox usd;
        private System.Windows.Forms.TextBox Mad;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox choix1;
        private System.Windows.Forms.ComboBox choix2;
        private System.Windows.Forms.Button retour;
    }
}