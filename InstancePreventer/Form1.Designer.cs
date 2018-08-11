namespace InstancePreventer
{
    partial class frmMultipleProgramInstancePreventer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMultipleProgramInstancePreventer));
            this.lblInsertFilePrompt = new System.Windows.Forms.Label();
            this.btnCreateFile = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.txtAddFolder = new System.Windows.Forms.TextBox();
            this.btnAddFolder = new System.Windows.Forms.Button();
            this.lblNamespacePrompt = new System.Windows.Forms.Label();
            this.txtNamespaceInput = new System.Windows.Forms.TextBox();
            this.btnRemoveFolder = new System.Windows.Forms.Button();
            this.txtAppNameInput = new System.Windows.Forms.TextBox();
            this.txtFormName = new System.Windows.Forms.TextBox();
            this.lblNamespace = new System.Windows.Forms.Label();
            this.lblAppNamePrompt = new System.Windows.Forms.Label();
            this.lblFormName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInsertFilePrompt
            // 
            this.lblInsertFilePrompt.Font = new System.Drawing.Font("Geneva", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInsertFilePrompt.Location = new System.Drawing.Point(12, 2);
            this.lblInsertFilePrompt.Name = "lblInsertFilePrompt";
            this.lblInsertFilePrompt.Size = new System.Drawing.Size(273, 34);
            this.lblInsertFilePrompt.TabIndex = 0;
            this.lblInsertFilePrompt.Text = "Multiple Program Instance Preventer";
            this.lblInsertFilePrompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCreateFile
            // 
            this.btnCreateFile.Location = new System.Drawing.Point(12, 158);
            this.btnCreateFile.Name = "btnCreateFile";
            this.btnCreateFile.Size = new System.Drawing.Size(133, 22);
            this.btnCreateFile.TabIndex = 1;
            this.btnCreateFile.Text = "Create File";
            this.btnCreateFile.UseVisualStyleBackColor = true;
            this.btnCreateFile.Click += new System.EventHandler(this.btnCreateFile_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(150, 158);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(133, 22);
            this.btnInfo.TabIndex = 2;
            this.btnInfo.Text = "Info";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // txtAddFolder
            // 
            this.txtAddFolder.Location = new System.Drawing.Point(12, 38);
            this.txtAddFolder.Name = "txtAddFolder";
            this.txtAddFolder.ReadOnly = true;
            this.txtAddFolder.Size = new System.Drawing.Size(140, 20);
            this.txtAddFolder.TabIndex = 3;
            // 
            // btnAddFolder
            // 
            this.btnAddFolder.Location = new System.Drawing.Point(160, 37);
            this.btnAddFolder.Name = "btnAddFolder";
            this.btnAddFolder.Size = new System.Drawing.Size(52, 22);
            this.btnAddFolder.TabIndex = 4;
            this.btnAddFolder.Text = "Add";
            this.btnAddFolder.UseVisualStyleBackColor = true;
            this.btnAddFolder.Click += new System.EventHandler(this.btnAddFolder_Click);
            // 
            // lblNamespacePrompt
            // 
            this.lblNamespacePrompt.AutoSize = true;
            this.lblNamespacePrompt.Location = new System.Drawing.Point(16, 79);
            this.lblNamespacePrompt.Name = "lblNamespacePrompt";
            this.lblNamespacePrompt.Size = new System.Drawing.Size(0, 13);
            this.lblNamespacePrompt.TabIndex = 5;
            // 
            // txtNamespaceInput
            // 
            this.txtNamespaceInput.Location = new System.Drawing.Point(12, 69);
            this.txtNamespaceInput.Name = "txtNamespaceInput";
            this.txtNamespaceInput.Size = new System.Drawing.Size(196, 20);
            this.txtNamespaceInput.TabIndex = 6;
            // 
            // btnRemoveFolder
            // 
            this.btnRemoveFolder.Location = new System.Drawing.Point(216, 37);
            this.btnRemoveFolder.Name = "btnRemoveFolder";
            this.btnRemoveFolder.Size = new System.Drawing.Size(66, 22);
            this.btnRemoveFolder.TabIndex = 8;
            this.btnRemoveFolder.Text = "Remove";
            this.btnRemoveFolder.UseVisualStyleBackColor = true;
            this.btnRemoveFolder.Click += new System.EventHandler(this.btnRemoveFolder_Click);
            // 
            // txtAppNameInput
            // 
            this.txtAppNameInput.Location = new System.Drawing.Point(12, 99);
            this.txtAppNameInput.Name = "txtAppNameInput";
            this.txtAppNameInput.Size = new System.Drawing.Size(196, 20);
            this.txtAppNameInput.TabIndex = 9;
            // 
            // txtFormName
            // 
            this.txtFormName.Location = new System.Drawing.Point(12, 129);
            this.txtFormName.Name = "txtFormName";
            this.txtFormName.Size = new System.Drawing.Size(196, 20);
            this.txtFormName.TabIndex = 11;
            // 
            // lblNamespace
            // 
            this.lblNamespace.Location = new System.Drawing.Point(219, 72);
            this.lblNamespace.Name = "lblNamespace";
            this.lblNamespace.Size = new System.Drawing.Size(64, 17);
            this.lblNamespace.TabIndex = 12;
            this.lblNamespace.Text = "Namespace";
            // 
            // lblAppNamePrompt
            // 
            this.lblAppNamePrompt.Location = new System.Drawing.Point(221, 102);
            this.lblAppNamePrompt.Name = "lblAppNamePrompt";
            this.lblAppNamePrompt.Size = new System.Drawing.Size(63, 14);
            this.lblAppNamePrompt.TabIndex = 13;
            this.lblAppNamePrompt.Text = "App Name";
            // 
            // lblFormName
            // 
            this.lblFormName.Location = new System.Drawing.Point(220, 132);
            this.lblFormName.Name = "lblFormName";
            this.lblFormName.Size = new System.Drawing.Size(63, 14);
            this.lblFormName.TabIndex = 14;
            this.lblFormName.Text = "Form Name";
            // 
            // frmMultipleProgramInstancePreventer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 188);
            this.Controls.Add(this.lblFormName);
            this.Controls.Add(this.lblAppNamePrompt);
            this.Controls.Add(this.lblNamespace);
            this.Controls.Add(this.txtFormName);
            this.Controls.Add(this.txtAppNameInput);
            this.Controls.Add(this.btnRemoveFolder);
            this.Controls.Add(this.txtNamespaceInput);
            this.Controls.Add(this.lblNamespacePrompt);
            this.Controls.Add(this.btnAddFolder);
            this.Controls.Add(this.txtAddFolder);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnCreateFile);
            this.Controls.Add(this.lblInsertFilePrompt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMultipleProgramInstancePreventer";
            this.Text = " Instance Preventer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInsertFilePrompt;
        private System.Windows.Forms.Button btnCreateFile;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.TextBox txtAddFolder;
        private System.Windows.Forms.Button btnAddFolder;
        private System.Windows.Forms.Label lblNamespacePrompt;
        private System.Windows.Forms.TextBox txtNamespaceInput;
        private System.Windows.Forms.Button btnRemoveFolder;
        private System.Windows.Forms.TextBox txtAppNameInput;
        private System.Windows.Forms.TextBox txtFormName;
        private System.Windows.Forms.Label lblNamespace;
        private System.Windows.Forms.Label lblAppNamePrompt;
        private System.Windows.Forms.Label lblFormName;
    }
}

