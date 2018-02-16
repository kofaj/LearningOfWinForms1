namespace Description_Maker
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
            this.CreateProjectButton = new System.Windows.Forms.Button();
            this.newProjectNameLabel = new System.Windows.Forms.Label();
            this.projectNameBox = new System.Windows.Forms.TextBox();
            this.ListOfGeneratedDescriptions = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PDFSaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CreateProjectButton
            // 
            this.CreateProjectButton.Location = new System.Drawing.Point(421, 273);
            this.CreateProjectButton.Name = "CreateProjectButton";
            this.CreateProjectButton.Size = new System.Drawing.Size(107, 23);
            this.CreateProjectButton.TabIndex = 22;
            this.CreateProjectButton.Text = "Next";
            this.CreateProjectButton.UseVisualStyleBackColor = true;
            this.CreateProjectButton.Click += new System.EventHandler(this.CreateProjectButton_Click);
            // 
            // newProjectNameLabel
            // 
            this.newProjectNameLabel.AutoSize = true;
            this.newProjectNameLabel.Location = new System.Drawing.Point(321, 56);
            this.newProjectNameLabel.Name = "newProjectNameLabel";
            this.newProjectNameLabel.Size = new System.Drawing.Size(81, 13);
            this.newProjectNameLabel.TabIndex = 21;
            this.newProjectNameLabel.Text = "Nazwa projektu";
            // 
            // projectNameBox
            // 
            this.projectNameBox.Location = new System.Drawing.Point(408, 56);
            this.projectNameBox.Name = "projectNameBox";
            this.projectNameBox.Size = new System.Drawing.Size(120, 20);
            this.projectNameBox.TabIndex = 20;
            // 
            // ListOfGeneratedDescriptions
            // 
            this.ListOfGeneratedDescriptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ListOfGeneratedDescriptions.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ListOfGeneratedDescriptions.FormattingEnabled = true;
            this.ListOfGeneratedDescriptions.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.ListOfGeneratedDescriptions.Location = new System.Drawing.Point(129, 53);
            this.ListOfGeneratedDescriptions.Name = "ListOfGeneratedDescriptions";
            this.ListOfGeneratedDescriptions.Size = new System.Drawing.Size(121, 23);
            this.ListOfGeneratedDescriptions.Sorted = true;
            this.ListOfGeneratedDescriptions.TabIndex = 19;
            this.ListOfGeneratedDescriptions.SelectedIndexChanged += new System.EventHandler(this.ListOfGeneratedDescriptions_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Ilość wierszy z opisami";
            // 
            // PDFSaveButton
            // 
            this.PDFSaveButton.Location = new System.Drawing.Point(421, 231);
            this.PDFSaveButton.Name = "PDFSaveButton";
            this.PDFSaveButton.Size = new System.Drawing.Size(107, 23);
            this.PDFSaveButton.TabIndex = 17;
            this.PDFSaveButton.Text = "Save to PDF";
            this.PDFSaveButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 317);
            this.Controls.Add(this.CreateProjectButton);
            this.Controls.Add(this.newProjectNameLabel);
            this.Controls.Add(this.projectNameBox);
            this.Controls.Add(this.ListOfGeneratedDescriptions);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PDFSaveButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateProjectButton;
        private System.Windows.Forms.Label newProjectNameLabel;
        private System.Windows.Forms.TextBox projectNameBox;
        private System.Windows.Forms.ComboBox ListOfGeneratedDescriptions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button PDFSaveButton;
    }
}

