using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace InstancePreventer
{
    public partial class frmMultipleProgramInstancePreventer : Form
    {
        public frmMultipleProgramInstancePreventer()
        {
            InitializeComponent();
        }

        string namespaceName;
        string appName;
        string formName;

        private void btnInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by DefyTheRush\n\nWhat does this program do? This allows you to add in a new Program.cs file in your project folder if you do not want your program to run more than one time (if necessary)", "Information");
        }

        private void btnAddFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            folder.ShowNewFolderButton = false;
            DialogResult dlgFolder = folder.ShowDialog();

            if (dlgFolder == DialogResult.OK)
            {
                txtAddFolder.Text = folder.SelectedPath;
                Environment.SpecialFolder root = folder.RootFolder;
            }
        }

        private void btnCreateFile_Click(object sender, EventArgs e)
        {
            if (txtAddFolder.Text.Equals("") && txtNamespaceInput.Text.Equals("") && txtAppNameInput.Text.Equals("") && txtFormName.Text.Equals(""))
            {
                MessageBox.Show("Put something in the directory and namespace!", "No input received");
            }

            else if (txtNamespaceInput.Text.Equals("") || txtAddFolder.Text.Equals("") || txtAppNameInput.Text.Equals("") || txtFormName.Text.Equals(""))
            {
                MessageBox.Show("You need to do all entries!", "No input received in one or more boxes");
            }

            else
            {
                string FolderDirectory = txtAddFolder.Text;
                namespaceName = txtNamespaceInput.Text;
                appName = txtAppNameInput.Text;
                formName = txtFormName.Text;

                string[] lines = { "using System;\nusing System.Collections.Generic;\nusing System.Linq;\nusing System.Threading.Tasks;\nusing System.Windows.Forms;\nusing System.Threading;\n",
                    "namespace " + namespaceName, "{", "   static class Program","   {","       [STATThread]","       static void Main()","       {","           const string appName = " +"\"" + appName + "\";","           bool createdNew;",
                "\n           Mutex mutex = new Mutex(true, appName, out createdNew);", "\n           if (!createdNew)", "           {", "             MessageBox.Show(\"You cannot have more than one instance of this program running\", \"Already running\");",
                "             return;", "           }", "\n           Application.EnableVisualStyles();","           Application.SetCompatibleTextRenderingDefault(false);","           Application.Run(new " + formName + "());","       }", "    }","}"};


                using (StreamWriter outputFile = new StreamWriter(Path.Combine(FolderDirectory, "Program_new.cs")))
                {
                    foreach (string line in lines)
                        outputFile.WriteLine(line);
                }

                MessageBox.Show("The file has been created!\n\nWhen everything between the new and old file is all good, delete the old file and rename the new one 'Program.cs'", "File created successfully");
            }
        }

        private void btnRemoveFolder_Click(object sender, EventArgs e)
        {
            txtAddFolder.Text = "";
        }
    }
}
