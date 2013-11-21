using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Newtonsoft.Json;
using System.IO;

namespace jsonTypescriptConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //OpenFileDialog fd = new OpenFileDialog();
            //fd.FileName = "Ext.toolbar.Paging.json";
            //if (fd.ShowDialog() == DialogResult.OK)
            //{
            //    ConvertFile(fd.FileName);
            //}
        }






        private void dump(XmlAttribute x)
        {
        }

        private void processDirectoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string startupPath = Application.StartupPath;
                using (FolderBrowserDialog dialog = new FolderBrowserDialog())
                {
                    dialog.Description = "Open a folder which contains the JSDuck JSON output";
                    dialog.ShowNewFolderButton = false;
                    //dialog.RootFolder = Environment.SpecialFolder.MyComputer;
                    //dialog.RootFolder = startupPath;
                    dialog.SelectedPath = @"D:\AECB\Projects\zzProject.JsDuckToCSharpAndTypeScript\jsondocs";
                    if (dialog.ShowDialog() == DialogResult.OK) {
                        DirectoryInfo directorySource = new DirectoryInfo(Path.GetFullPath(dialog.SelectedPath));

                        //{
                        //    DirectoryInfo directoryDestiny = new DirectoryInfo(Path.Combine(directorySource.FullName, "TypeScript"));

                        //    Parser.Parse(directorySource,
                        //        directoryDestiny,
                        //        new ExtJSToTypeScript.ExtJSParser(),
                        //        (progress) => {
                        //            progressBar1.Value = progress.Current;
                        //            progressBar1.Maximum = progress.Total;
                        //            lblFile.Text = progress.FileName;
                        //            lblProgress.Text = string.Format("TypeScript progress: {0} of {1}", progress.Current, progress.Total);
                        //            this.Update();
                        //        });
                        //}

                        {
                            DirectoryInfo directoryDestiny = new DirectoryInfo(Path.Combine(directorySource.FullName, "CSharp"));

                            Parser.Parse(directorySource,
                                directoryDestiny,
                                new zzProject.ExtJSToCSharp.ExtJSParser(),
                                (progress) => {
                                    progressBar1.Value = progress.Current;
                                    progressBar1.Maximum = progress.Total;
                                    lblFile.Text = progress.FileName;
                                    lblProgress.Text = string.Format("CSharp progress: {0} of {1}", progress.Current, progress.Total);
                                    this.Update();
                                });
                        }

                        lblFile.Text = "Done!";
                    }
                }
                //using (OpenFileDialog dialog = new OpenFileDialog())
                //{
                //    dialog.Filter = "xml files (*.xml)|*.xml";
                //    dialog.Multiselect = false;
                //    dialog.InitialDirectory = ".";
                //    dialog.Title = "Select file (only in XML format)";
                //    if (dialog.ShowDialog() == DialogResult.OK)
                //    {
                //        SQLGenerator.GenerateSQLTransactions(Application.StartupPath + Settings.Default.xmlFile);
                //    }
                //}
            }
            catch (Exception exc)
            {
                MessageBox.Show("Import failed because " + exc.Message + " , please try again later.");
            }
        }

        private void btnProcessDirectory_Click(object sender, EventArgs e)
        {
            processDirectoryToolStripMenuItem_Click(null, null);
        }
    }
}
