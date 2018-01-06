namespace Login_Form_Design_Example
{
    partial class StockControlForm
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
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnChooseFile = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.lblFileName = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 97);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(575, 126);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblFileName);
            this.tabPage1.Controls.Add(this.btnChooseFile);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(567, 100);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Choose File";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.materialLabel1);
            this.tabPage2.Controls.Add(this.materialSingleLineTextField1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(567, 100);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Link Url";
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.Depth = 0;
            this.btnChooseFile.Location = new System.Drawing.Point(6, 21);
            this.btnChooseFile.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Primary = true;
            this.btnChooseFile.Size = new System.Drawing.Size(124, 45);
            this.btnChooseFile.TabIndex = 1;
            this.btnChooseFile.Text = "Choose File";
            this.btnChooseFile.UseVisualStyleBackColor = true;
            this.btnChooseFile.Click += new System.EventHandler(this.btnChooseFile_Click);
            // 
            // materialSingleLineTextField1
            // 
            this.materialSingleLineTextField1.Depth = 0;
            this.materialSingleLineTextField1.Hint = "";
            this.materialSingleLineTextField1.Location = new System.Drawing.Point(88, 36);
            this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
            this.materialSingleLineTextField1.PasswordChar = '\0';
            this.materialSingleLineTextField1.SelectedText = "";
            this.materialSingleLineTextField1.SelectionLength = 0;
            this.materialSingleLineTextField1.SelectionStart = 0;
            this.materialSingleLineTextField1.Size = new System.Drawing.Size(309, 23);
            this.materialSingleLineTextField1.TabIndex = 0;
            this.materialSingleLineTextField1.UseSystemPasswordChar = false;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 62);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(802, 38);
            this.materialTabSelector1.TabIndex = 1;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Depth = 0;
            this.lblFileName.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblFileName.ForeColor = System.Drawing.Color.DarkRed;
            this.lblFileName.Location = new System.Drawing.Point(145, 33);
            this.lblFileName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(0, 19);
            this.lblFileName.TabIndex = 2;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(6, 36);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(64, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Link Url:";
            // 
            // StockControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 599);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialTabControl1);
            this.Name = "StockControlForm";
            this.Text = "Stock Control Form";
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private MaterialSkin.Controls.MaterialRaisedButton btnChooseFile;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private MaterialSkin.Controls.MaterialLabel lblFileName;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}