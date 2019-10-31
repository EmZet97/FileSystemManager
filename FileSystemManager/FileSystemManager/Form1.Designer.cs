namespace FileSystemManager
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.addDirectoryButton = new System.Windows.Forms.Button();
            this.addFileButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addDirectoryButton
            // 
            this.addDirectoryButton.Location = new System.Drawing.Point(229, 344);
            this.addDirectoryButton.Name = "addDirectoryButton";
            this.addDirectoryButton.Size = new System.Drawing.Size(115, 23);
            this.addDirectoryButton.TabIndex = 0;
            this.addDirectoryButton.Text = "Add Directory";
            this.addDirectoryButton.UseVisualStyleBackColor = true;
            // 
            // addFileButton
            // 
            this.addFileButton.Location = new System.Drawing.Point(373, 344);
            this.addFileButton.Name = "addFileButton";
            this.addFileButton.Size = new System.Drawing.Size(115, 23);
            this.addFileButton.TabIndex = 1;
            this.addFileButton.Text = "Add file";
            this.addFileButton.UseVisualStyleBackColor = true;
            this.addFileButton.Click += new System.EventHandler(this.AddFileButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addFileButton);
            this.Controls.Add(this.addDirectoryButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addDirectoryButton;
        private System.Windows.Forms.Button addFileButton;
    }
}

