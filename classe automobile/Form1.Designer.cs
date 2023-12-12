namespace classe_automobile
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.accendi = new System.Windows.Forms.Button();
            this.acelera = new System.Windows.Forms.Button();
            this.freno = new System.Windows.Forms.Button();
            this.marciasu = new System.Windows.Forms.Button();
            this.marciagiù = new System.Windows.Forms.Button();
            this.retromarcia = new System.Windows.Forms.Button();
            this.spegni = new System.Windows.Forms.Button();
            this.velocità = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // accendi
            // 
            this.accendi.Location = new System.Drawing.Point(22, 30);
            this.accendi.Name = "accendi";
            this.accendi.Size = new System.Drawing.Size(145, 43);
            this.accendi.TabIndex = 0;
            this.accendi.Text = "accensione";
            this.accendi.UseVisualStyleBackColor = true;
            this.accendi.Click += new System.EventHandler(this.accendi_Click);
            // 
            // acelera
            // 
            this.acelera.Location = new System.Drawing.Point(22, 88);
            this.acelera.Name = "acelera";
            this.acelera.Size = new System.Drawing.Size(145, 50);
            this.acelera.TabIndex = 1;
            this.acelera.Text = "accelera";
            this.acelera.UseVisualStyleBackColor = true;
            this.acelera.Click += new System.EventHandler(this.acelera_Click);
            // 
            // freno
            // 
            this.freno.Location = new System.Drawing.Point(22, 144);
            this.freno.Name = "freno";
            this.freno.Size = new System.Drawing.Size(145, 46);
            this.freno.TabIndex = 2;
            this.freno.Text = "freno";
            this.freno.UseVisualStyleBackColor = true;
            this.freno.Click += new System.EventHandler(this.freno_Click);
            // 
            // marciasu
            // 
            this.marciasu.Location = new System.Drawing.Point(22, 224);
            this.marciasu.Name = "marciasu";
            this.marciasu.Size = new System.Drawing.Size(129, 52);
            this.marciasu.TabIndex = 3;
            this.marciasu.Text = "aumenta marcia";
            this.marciasu.UseVisualStyleBackColor = true;
            this.marciasu.Click += new System.EventHandler(this.marciasu_Click);
            // 
            // marciagiù
            // 
            this.marciagiù.Location = new System.Drawing.Point(157, 224);
            this.marciagiù.Name = "marciagiù";
            this.marciagiù.Size = new System.Drawing.Size(141, 52);
            this.marciagiù.TabIndex = 4;
            this.marciagiù.Text = "diminuisci marcia";
            this.marciagiù.UseVisualStyleBackColor = true;
            this.marciagiù.Click += new System.EventHandler(this.marciagiù_Click);
            // 
            // retromarcia
            // 
            this.retromarcia.Location = new System.Drawing.Point(22, 282);
            this.retromarcia.Name = "retromarcia";
            this.retromarcia.Size = new System.Drawing.Size(129, 50);
            this.retromarcia.TabIndex = 5;
            this.retromarcia.Text = "retromarcia";
            this.retromarcia.UseVisualStyleBackColor = true;
            this.retromarcia.Click += new System.EventHandler(this.retromarcia_Click);
            // 
            // spegni
            // 
            this.spegni.Location = new System.Drawing.Point(193, 30);
            this.spegni.Name = "spegni";
            this.spegni.Size = new System.Drawing.Size(145, 43);
            this.spegni.TabIndex = 6;
            this.spegni.Text = "spegnimento";
            this.spegni.UseVisualStyleBackColor = true;
            this.spegni.Click += new System.EventHandler(this.spegni_Click);
            // 
            // velocità
            // 
            this.velocità.Location = new System.Drawing.Point(228, 128);
            this.velocità.Name = "velocità";
            this.velocità.Size = new System.Drawing.Size(170, 20);
            this.velocità.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "velocità:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.velocità);
            this.Controls.Add(this.spegni);
            this.Controls.Add(this.retromarcia);
            this.Controls.Add(this.marciagiù);
            this.Controls.Add(this.marciasu);
            this.Controls.Add(this.freno);
            this.Controls.Add(this.acelera);
            this.Controls.Add(this.accendi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button accendi;
        private System.Windows.Forms.Button acelera;
        private System.Windows.Forms.Button freno;
        private System.Windows.Forms.Button marciasu;
        private System.Windows.Forms.Button marciagiù;
        private System.Windows.Forms.Button retromarcia;
        private System.Windows.Forms.Button spegni;
        private System.Windows.Forms.TextBox velocità;
        private System.Windows.Forms.Label label1;
    }
}

