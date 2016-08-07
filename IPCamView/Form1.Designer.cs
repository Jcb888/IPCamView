namespace IPCamView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.axVLCPlugin21 = new AxAXVLC.AxVLCPlugin2();
            this.axVLCPlugin22 = new AxAXVLC.AxVLCPlugin2();
            ((System.ComponentModel.ISupportInitialize)(this.axVLCPlugin21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axVLCPlugin22)).BeginInit();
            this.SuspendLayout();
            // 
            // axVLCPlugin21
            // 
            this.axVLCPlugin21.Enabled = true;
            this.axVLCPlugin21.Location = new System.Drawing.Point(22, 12);
            this.axVLCPlugin21.Name = "axVLCPlugin21";
            this.axVLCPlugin21.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axVLCPlugin21.OcxState")));
            this.axVLCPlugin21.Size = new System.Drawing.Size(320, 240);
            this.axVLCPlugin21.TabIndex = 0;
            this.axVLCPlugin21.Enter += new System.EventHandler(this.axVLCPlugin21_Enter);
            // 
            // axVLCPlugin22
            // 
            this.axVLCPlugin22.Enabled = true;
            this.axVLCPlugin22.Location = new System.Drawing.Point(22, 271);
            this.axVLCPlugin22.Name = "axVLCPlugin22";
            this.axVLCPlugin22.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axVLCPlugin22.OcxState")));
            this.axVLCPlugin22.Size = new System.Drawing.Size(320, 240);
            this.axVLCPlugin22.TabIndex = 1;
            this.axVLCPlugin22.Enter += new System.EventHandler(this.axVLCPlugin22_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 540);
            this.Controls.Add(this.axVLCPlugin22);
            this.Controls.Add(this.axVLCPlugin21);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.axVLCPlugin21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axVLCPlugin22)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxAXVLC.AxVLCPlugin2 axVLCPlugin21;
        private AxAXVLC.AxVLCPlugin2 axVLCPlugin22;
    }
}

