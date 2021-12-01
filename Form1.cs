using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using iTextSharp;
using iTextSharp.text.pdf;

namespace Bates_Verifier
{
    public partial class Form1 : Form
    {
        private void InitializeMainListView()
        {        
            InitializeComponent();
            lstMain.Columns.Add("File Name");
            lstMain.Columns.Add("Starting Bates");
            lstMain.Columns.Add("Ending Bates");
            lstMain.View = View.Details;
            lstMain.Columns[0].Width = 975;
            lstMain.Columns[1].Width = 150;
            lstMain.Columns[2].Width = 150;
        }
        
        public Form1()
        {
            InitializeMainListView();
        }

        public void EnableAllElements()
        {
            btnBrowse.Enabled = true;
            btnExport.Enabled = true;
            btnVerify.Enabled = true;
            txtBatesPrefix.Enabled = true;
            txtFolder.Enabled = true;
        }

        public void DisableAllElements()
        {
            btnBrowse.Enabled = false;
            btnExport.Enabled = false;
            btnVerify.Enabled = false;
            txtBatesPrefix.Enabled = false;
            txtFolder.Enabled = false;
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(txtFolder.Text);

            DisableAllElements();
            string folderPath = txtFolder.Text;
            string fileName = "";
            string startingBates = "";
            string fileNameOnly = "";
            string batesPrefix = txtBatesPrefix.Text;
            string endingBates = "";

            if (folderPath[folderPath.Length - 1] != '\\' )
            {
                folderPath = folderPath + @"\";
            }

            if (!Directory.Exists(folderPath))
            {
                MessageBox.Show("Invalid Folder.");
                EnableAllElements();
                return;
            }
            if (txtBatesPrefix.Text.Length < 3)
            {
                MessageBox.Show("Invalid Bates Prefix");
                EnableAllElements();
                return;
            }
            lstMain.Items.Clear();

            string[] allPDFs = Directory.GetFiles(folderPath, "*.pdf", SearchOption.TopDirectoryOnly);

            for (int i = 0; i < allPDFs.Length; i++)
            {
                fileName = allPDFs[i];
                startingBates = "";

                var reader = new PdfReader(File.ReadAllBytes(fileName));
                var contentBytes = reader.GetPageContent(1);
                var tokenizer = new PRTokeniser(new RandomAccessFileOrArray(contentBytes));
                var stringsList = new List<string>();
                try
                {
                    while (tokenizer.NextToken())
                    {
                        if (tokenizer.TokenType == PRTokeniser.TokType.STRING)
                        {
                            //stringsList.Add(tokenizer.StringValue);
                            if (tokenizer.StringValue.Contains(batesPrefix))
                            {
                                startingBates = tokenizer.StringValue.Trim();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    startingBates = ex.Message;
                }
                


                //GET LAST BATES NUMBER
                var contentBytesLast = reader.GetPageContent(reader.NumberOfPages);
                var tokenizerLast = new PRTokeniser(new RandomAccessFileOrArray(contentBytesLast));
                var stringsListLast = new List<string>();
                try
                {
                    while (tokenizerLast.NextToken())
                    {
                        if (tokenizerLast.TokenType == PRTokeniser.TokType.STRING)
                        {
                            //stringsList.Add(tokenizer.StringValue);
                            if (tokenizerLast.StringValue.Contains(batesPrefix))
                            {
                                endingBates = tokenizerLast.StringValue.Trim();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    endingBates = ex.Message;
                }

                if (chkFileNameOnly.Checked)
                {
                    fileNameOnly = Path.GetFileName(fileName);
                    lstMain.Items.Add(new ListViewItem(new string[] { fileNameOnly, startingBates, endingBates }));
                }
                else
                {
                    lstMain.Items.Add(new ListViewItem(new string[] { fileName, startingBates, endingBates }));
                }
            }
            EnableAllElements();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            DisableAllElements();
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                    Workbook wb = app.Workbooks.Add(XlSheetType.xlWorksheet);
                    Worksheet ws = (Worksheet)app.ActiveSheet;
                    app.Visible = false;
                    ws.Cells[1, 1] = "File Name";
                    ws.Cells[1, 2] = "Starting Bates";
                    ws.Cells[1, 3] = "Ending Bates";
                    int i = 2;
                    foreach (ListViewItem item in lstMain.Items)
                    {
                        ws.Cells[i, 1] = item.SubItems[0].Text;
                        ws.Cells[i, 2] = item.SubItems[1].Text;
                        ws.Cells[i, 3] = item.SubItems[2].Text;
                        i++;
                    }
                    wb.SaveAs(sfd.FileName, XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, false, false, XlSaveAsAccessMode.xlNoChange, XlSaveConflictResolution.xlLocalSessionChanges, Type.Missing, Type.Missing);
                    app.Quit();
                    MessageBox.Show("Export Successful!");
                }                
            }
            EnableAllElements();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            DisableAllElements();
            if (fbd1.ShowDialog() == DialogResult.OK)
            {
                txtFolder.Text = fbd1.SelectedPath;
            }
            EnableAllElements();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
