using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Description_Maker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ListOfGeneratedDescriptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = Convert.ToInt32(ListOfGeneratedDescriptions.Text);

            if (selectedIndex < BoxesAndLabelsGeneratedbyMethod.Count)
            {
                foreach (var item in BoxesAndLabelsGeneratedbyMethod)
                {
                    item.label.Dispose();
                    item.textBox.Dispose();
                }
                BoxesAndLabelsGeneratedbyMethod.RemoveRange(selectedIndex - 1, BoxesAndLabelsGeneratedbyMethod.Count - selectedIndex);
            }

            for (int i = 0; i < selectedIndex; i++)
            {
                BoxesAndLabelsGeneratedbyMethod.Add(new GeneratedItem { textBox = CreateNewBoxWithDescription(i), label = CreateLabelsForEachNewBox(i) });
            }
        }

        private void CreateProjectButton_Click(object sender, EventArgs e)
        {
            if (BoxesAndLabelsGeneratedbyMethod.Count > 0)
            {
               // GetTextBoxStrings();
            }
            OpenNewForm();
        }
        
        private void OpenNewForm()
        {
            string[] fake = { "Projekt Nazwa", "Description 1", "Description 2" };
            AddingDataForm secondForm = new AddingDataForm(fake); //zmieniony konstruktor + GetTextBoxStrings()
            secondForm.Show();
            this.Hide();
        }

        private Label CreateLabelsForEachNewBox(int i)
        {
            Label label = new Label();
            label.Location = new Point(250, 100 + i * 25);
            label.Name = "GeneratedLabel" + i;
            label.Text = "Oznaczenie " + (i + 1);
            this.Controls.Add(label);

            return label;
        }

        private TextBox CreateNewBoxWithDescription(int v)
        {
            TextBox textBox = new TextBox();
            textBox.Location = new Point(160, 100 + v * 25);
            textBox.Size = new Size(80, 20);
            textBox.Name = "DescriptionTextBox " + v;
            this.Controls.Add(textBox);

            return textBox;
        }

        private String[] GetTextBoxStrings()
        {
            List<String> list = new List<String>();
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                    list.Add(((TextBox)c).Text);
            }
            return list.ToArray();
        }

        private List<GeneratedItem> BoxesAndLabelsGeneratedbyMethod = new List<GeneratedItem>();
    }
}
