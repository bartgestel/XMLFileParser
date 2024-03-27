namespace XMLFileParser
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnOpenFile = new Button();
            ofdXML = new OpenFileDialog();
            lblNameText = new Label();
            lblName = new Label();
            lblIdText = new Label();
            lblId = new Label();
            lbxEvents = new ListBox();
            lbxParameters = new ListBox();
            SuspendLayout();
            // 
            // btnOpenFile
            // 
            btnOpenFile.Location = new Point(12, 12);
            btnOpenFile.Name = "btnOpenFile";
            btnOpenFile.Size = new Size(129, 29);
            btnOpenFile.TabIndex = 0;
            btnOpenFile.Text = "Select XML File";
            btnOpenFile.UseVisualStyleBackColor = true;
            btnOpenFile.Click += btnOpenFile_Click;
            // 
            // ofdXML
            // 
            ofdXML.FileName = "openFileDialog1";
            ofdXML.FileOk += ofdXML_FileOk;
            // 
            // lblNameText
            // 
            lblNameText.AutoSize = true;
            lblNameText.Location = new Point(12, 79);
            lblNameText.Name = "lblNameText";
            lblNameText.Size = new Size(52, 20);
            lblNameText.TabIndex = 1;
            lblNameText.Text = "Name:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(70, 79);
            lblName.Name = "lblName";
            lblName.Size = new Size(18, 20);
            lblName.TabIndex = 1;
            lblName.Text = "...";
            // 
            // lblIdText
            // 
            lblIdText.AutoSize = true;
            lblIdText.Location = new Point(12, 59);
            lblIdText.Name = "lblIdText";
            lblIdText.Size = new Size(25, 20);
            lblIdText.TabIndex = 1;
            lblIdText.Text = "Id:";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(70, 59);
            lblId.Name = "lblId";
            lblId.Size = new Size(18, 20);
            lblId.TabIndex = 1;
            lblId.Text = "...";
            // 
            // lbxEvents
            // 
            lbxEvents.FormattingEnabled = true;
            lbxEvents.Location = new Point(12, 127);
            lbxEvents.Name = "lbxEvents";
            lbxEvents.Size = new Size(720, 184);
            lbxEvents.TabIndex = 2;
            lbxEvents.SelectedIndexChanged += lbxEvents_SelectedIndexChanged;
            // 
            // lbxParameters
            // 
            lbxParameters.FormattingEnabled = true;
            lbxParameters.Location = new Point(12, 317);
            lbxParameters.Name = "lbxParameters";
            lbxParameters.Size = new Size(720, 184);
            lbxParameters.TabIndex = 2;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(744, 508);
            Controls.Add(lbxParameters);
            Controls.Add(lbxEvents);
            Controls.Add(lblId);
            Controls.Add(lblName);
            Controls.Add(lblIdText);
            Controls.Add(lblNameText);
            Controls.Add(btnOpenFile);
            Name = "Main";
            Text = "XML Parser";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOpenFile;
        private OpenFileDialog ofdXML;
        private Label lblNameText;
        private Label lblName;
        private Label lblIdText;
        private Label lblId;
        private ListBox lbxEvents;
        private ListBox lbxParameters;
    }
}
