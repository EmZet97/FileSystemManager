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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.nodeNameInputBox = new System.Windows.Forms.TextBox();
            this.INFO = new System.Windows.Forms.Label();
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addDirectoryButton
            // 
            this.addDirectoryButton.Location = new System.Drawing.Point(269, 400);
            this.addDirectoryButton.Name = "addDirectoryButton";
            this.addDirectoryButton.Size = new System.Drawing.Size(115, 23);
            this.addDirectoryButton.TabIndex = 0;
            this.addDirectoryButton.Text = "Add Directory";
            this.addDirectoryButton.UseVisualStyleBackColor = true;
            this.addDirectoryButton.Click += new System.EventHandler(this.AddDirectoryButton_Click);
            // 
            // addFileButton
            // 
            this.addFileButton.Location = new System.Drawing.Point(413, 400);
            this.addFileButton.Name = "addFileButton";
            this.addFileButton.Size = new System.Drawing.Size(115, 23);
            this.addFileButton.TabIndex = 1;
            this.addFileButton.Text = "Add file";
            this.addFileButton.UseVisualStyleBackColor = true;
            this.addFileButton.Click += new System.EventHandler(this.AddFileButton_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(171, 11);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(459, 327);
            this.treeView1.TabIndex = 2;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeView1_AfterSelect);
            // 
            // nodeNameInputBox
            // 
            this.nodeNameInputBox.Location = new System.Drawing.Point(171, 361);
            this.nodeNameInputBox.Name = "nodeNameInputBox";
            this.nodeNameInputBox.Size = new System.Drawing.Size(459, 20);
            this.nodeNameInputBox.TabIndex = 3;
            this.nodeNameInputBox.TextChanged += new System.EventHandler(this.NodeNameInputBox_TextChanged);
            // 
            // INFO
            // 
            this.INFO.AutoSize = true;
            this.INFO.ForeColor = System.Drawing.Color.Red;
            this.INFO.Location = new System.Drawing.Point(361, 345);
            this.INFO.Name = "INFO";
            this.INFO.Size = new System.Drawing.Size(0, 13);
            this.INFO.TabIndex = 4;
            // 
            // pathTextBox
            // 
            this.pathTextBox.Enabled = false;
            this.pathTextBox.Location = new System.Drawing.Point(171, 317);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.Size = new System.Drawing.Size(459, 20);
            this.pathTextBox.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pathTextBox);
            this.Controls.Add(this.INFO);
            this.Controls.Add(this.nodeNameInputBox);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.addFileButton);
            this.Controls.Add(this.addDirectoryButton);
            this.Name = "Form1";
            this.Text = "File Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addDirectoryButton;
        private System.Windows.Forms.Button addFileButton;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TextBox nodeNameInputBox;
        private System.Windows.Forms.Label INFO;
        private System.Windows.Forms.TextBox pathTextBox;
    }
}

