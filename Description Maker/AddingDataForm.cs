using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Description_Maker
{
    public partial class AddingDataForm : Form
    {
        private string[] DataFromForm = null;

        public AddingDataForm(string[] test)
        {
            InitializeComponent();
            DataFromForm = test;
            CreateDataForRows();
            DataGridOperations.DefaultSelectedCell(ref myGridView);
        }

        private void AddingNewTableToDB()
        {
            string SQLCommand = GenerateStringToCreateNewTable();
            string ConString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kofaj_000\Documents\Visual Studio 2017\Projects\Description Maker\Description Maker\ProjectDatabase.mdf;Integrated Security=True";

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

        private string GenerateStringToCreateNewTable()
        {
            string[] myTemporaryList = DataFromForm;
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

        private void CreateDataForRows()
        {
            BindingSource bind = new BindingSource();
            bind.DataSource = TakeDataFromForm();
            myGridView.DataSource = bind;
            myGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private DataTable TakeDataFromForm()
        {
            dt.Columns.Add(DataGridOperations.AddFirstColumn());
            dt.Rows.Add(DataGridOperations.AddNewRow(ref dt));

            for (int i = 1; i < DataFromForm.Length; i++)
            {
                dt.Columns.Add(new DataColumn(DataFromForm[i], typeof(String)));
            }
            return dt;
        }

        private void AddRowsButton_Click(object sender, EventArgs e)
        {
            if (CheckUserInput.IsInputAnumber(noOfAddingRows) == true && CheckUserInput.IsNumberTooLarge(GrabNumberFromInput()) == true)
            {
                int no = GrabNumberFromInput();
                for (int i = 0; i < no; i++)
                {
                    dt.Rows.Add(DataGridOperations.AddNewRow(ref dt));
                }
            }
            DataGridOperations.DefaultSelectedCell(ref myGridView);
        }

        private int GrabNumberFromInput()
        {
            return Convert.ToInt32(noOfAddingRows.Text);
        }

         DataTable dt = new DataTable
        {
            Locale = System.Globalization.CultureInfo.CurrentCulture
        };

        private void PasteData_Click(object sender, EventArgs e)
        {
            DataGridOperations.PasteInData(ref myGridView);
        }

        private void AddingDataForm_KeyDown(object sender, KeyEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            if (e.Control && e.KeyCode == Keys.V)
            {
                DataGridOperations.PasteInData(ref myGridView);
            }
                this.Cursor = Cursors.Default;
        }

        private void GenButton_Click(object sender, EventArgs e)
        {

        }
    }
}
