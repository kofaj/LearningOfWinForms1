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
            DateTime todayDate = DateTime.Now; //po co mi to?
            AddingNewTableToDB();
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

        private List<GeneratedItem> BoxesAndLabelsGeneratedbyMethod = new List<GeneratedItem>();

        private string GenerateStringToCreateNewTable()
        {
            string[] myTemporaryList = GetTextBoxStrings();
            string namesOfColumns = null;

            for (int i = 1; i < myTemporaryList.Length; i++)
            {
                namesOfColumns += "['" + myTemporaryList[i] + "'] [varchar](max) NOT NULL,";
            }

            string con = String.Format("CREATE TABLE [dbo].[{0}]("
                                + "[ID] [int] IDENTITY(1,1) NOT NULL,"
                                + "[DateTime] [date] NOT NULL,"
                                + "[{1}] [varchar](max) NOT NULL,"
                                + "[{2}] [varchar](max) NOT NULL,"
                                + "CONSTRAINT [pk_{0}] PRIMARY KEY CLUSTERED "
                                + "("
                                + "[ID] ASC"
                                + ")WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]"
                                + ") ON [PRIMARY]", myTemporaryList[0], myTemporaryList[1], myTemporaryList[2]);


            return con;
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

        private void AddingNewTableToDB()
        {
            string SQLCommand = GenerateStringToCreateNewTable();
            string ConString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kofaj_000\Documents\Visual Studio 2017\Projects\Description Generator\Description Generator\ProjectDatabase.mdf;Integrated Security=True";

            try
            {
                using (SqlCommand cmd = new SqlCommand(SQLCommand, new SqlConnection(ConString)))
                {
                    cmd.Connection.Open();
                    cmd.ExecuteNonQuery();
                    cmd.Connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
