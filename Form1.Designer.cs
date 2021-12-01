
namespace Bates_Verifier
{
    partial class Form1
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
            this.txtFolder = new System.Windows.Forms.TextBox();
            this.btnVerify = new System.Windows.Forms.Button();
            this.lstMain = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.chkFileNameOnly = new System.Windows.Forms.CheckBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.fbd1 = new System.Windows.Forms.FolderBrowserDialog();
            this.lblBatesPrefix = new System.Windows.Forms.Label();
            this.txtBatesPrefix = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtFolder
            // 
            this.txtFolder.Location = new System.Drawing.Point(176, 42);
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.Size = new System.Drawing.Size(476, 20);
            this.txtFolder.TabIndex = 0;
            // 
            // btnVerify
            // 
            this.btnVerify.Location = new System.Drawing.Point(700, 24);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(114, 50);
            this.btnVerify.TabIndex = 1;
            this.btnVerify.Text = "Get Bates Numbers";
            this.btnVerify.UseVisualStyleBackColor = true;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // lstMain
            // 
            this.lstMain.HideSelection = false;
            this.lstMain.Location = new System.Drawing.Point(12, 94);
            this.lstMain.Name = "lstMain";
            this.lstMain.Size = new System.Drawing.Size(1279, 445);
            this.lstMain.TabIndex = 2;
            this.lstMain.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Folder:";
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(1134, 545);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(157, 50);
            this.btnExport.TabIndex = 4;
            this.btnExport.Text = "E&xport to Excel";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // chkFileNameOnly
            // 
            this.chkFileNameOnly.AutoSize = true;
            this.chkFileNameOnly.Location = new System.Drawing.Point(910, 42);
            this.chkFileNameOnly.Name = "chkFileNameOnly";
            this.chkFileNameOnly.Size = new System.Drawing.Size(97, 17);
            this.chkFileNameOnly.TabIndex = 5;
            this.chkFileNameOnly.Text = "File Name Only";
            this.chkFileNameOnly.UseVisualStyleBackColor = true;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(8, 24);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(117, 50);
            this.btnBrowse.TabIndex = 6;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // lblBatesPrefix
            // 
            this.lblBatesPrefix.AutoSize = true;
            this.lblBatesPrefix.Location = new System.Drawing.Point(1101, 46);
            this.lblBatesPrefix.Name = "lblBatesPrefix";
            this.lblBatesPrefix.Size = new System.Drawing.Size(63, 13);
            this.lblBatesPrefix.TabIndex = 7;
            this.lblBatesPrefix.Text = "Bates Prefix";
            // 
            // txtBatesPrefix
            // 
            this.txtBatesPrefix.Location = new System.Drawing.Point(1170, 43);
            this.txtBatesPrefix.Name = "txtBatesPrefix";
            this.txtBatesPrefix.Size = new System.Drawing.Size(123, 20);
            this.txtBatesPrefix.TabIndex = 8;
            this.txtBatesPrefix.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 607);
            this.Controls.Add(this.txtBatesPrefix);
            this.Controls.Add(this.lblBatesPrefix);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.chkFileNameOnly);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstMain);
            this.Controls.Add(this.btnVerify);
            this.Controls.Add(this.txtFolder);
            this.Name = "Form1";
            this.Text = "Bates Verifier";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFolder;
        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.ListView lstMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.CheckBox chkFileNameOnly;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.FolderBrowserDialog fbd1;
        private System.Windows.Forms.Label lblBatesPrefix;
        private System.Windows.Forms.TextBox txtBatesPrefix;
    }
}

