namespace Description_Maker
{
    partial class AddingDataForm
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
            this.myGridView = new System.Windows.Forms.DataGridView();
            this.GenButton = new System.Windows.Forms.Button();
            this.addRowsButton = new System.Windows.Forms.Button();
            this.noOfAddingRows = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.myGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // myGridView
            // 
            this.myGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.myGridView.Location = new System.Drawing.Point(12, 12);
            this.myGridView.Name = "myGridView";
            this.myGridView.Size = new System.Drawing.Size(527, 380);
            this.myGridView.TabIndex = 0;
            // 
            // GenButton
            // 
            this.GenButton.Location = new System.Drawing.Point(555, 369);
            this.GenButton.Name = "GenButton";
            this.GenButton.Size = new System.Drawing.Size(107, 23);
            this.GenButton.TabIndex = 23;
            this.GenButton.Text = "Generate labels";
            this.GenButton.UseVisualStyleBackColor = true;
            // 
            // addRowsButton
            // 
            this.addRowsButton.Location = new System.Drawing.Point(545, 138);
            this.addRowsButton.Name = "addRowsButton";
            this.addRowsButton.Size = new System.Drawing.Size(107, 23);
            this.addRowsButton.TabIndex = 24;
            this.addRowsButton.Text = "Add rows";
            this.addRowsButton.UseVisualStyleBackColor = true;
            this.addRowsButton.Click += new System.EventHandler(this.AddRowsButton_Click);
            // 
            // noOfAddingRows
            // 
            this.noOfAddingRows.Location = new System.Drawing.Point(545, 121);
            this.noOfAddingRows.Name = "noOfAddingRows";
            this.noOfAddingRows.Size = new System.Drawing.Size(107, 20);
            this.noOfAddingRows.TabIndex = 25;
            // 
            // AddingDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 404);
            this.Controls.Add(this.noOfAddingRows);
            this.Controls.Add(this.addRowsButton);
            this.Controls.Add(this.GenButton);
            this.Controls.Add(this.myGridView);
            this.Name = "AddingDataForm";
            this.Text = "AddingDataForm";
            ((System.ComponentModel.ISupportInitialize)(this.myGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView myGridView;
        private System.Windows.Forms.Button GenButton;
        private System.Windows.Forms.Button addRowsButton;
        private System.Windows.Forms.TextBox noOfAddingRows;
    }
}