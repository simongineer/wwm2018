namespace WerWirdMillionär
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBoxGeld = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // groupBoxGeld
            // 
            this.groupBoxGeld.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxGeld.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBoxGeld.BackgroundImage")));
            this.groupBoxGeld.ForeColor = System.Drawing.Color.White;
            this.groupBoxGeld.Location = new System.Drawing.Point(444, -6);
            this.groupBoxGeld.Name = "groupBoxGeld";
            this.groupBoxGeld.Size = new System.Drawing.Size(260, 444);
            this.groupBoxGeld.TabIndex = 1;
            this.groupBoxGeld.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(704, 561);
            this.Controls.Add(this.groupBoxGeld);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form1";
            this.Text = "Wer Wird Millionär - JZ, KT, SP, CS, SR";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxGeld;
    }
}

