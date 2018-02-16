using System.Windows.Forms;

namespace Description_Maker
{
    class GeneratedItem
    {
        public Label label { get; set; }
        public TextBox textBox { get; set; }
        public string desciption { get; set; }
    }

    static class CheckUserInput
    {
        //private static TextBox box = new TextBox();
        const int MaxNumberOfCopies = 400;

        public static bool IsInputAnumber(TextBox box)
        {
            bool input = int.TryParse(box.Text, out int result);
            return input;
        }
        
        public static bool IsNumberFine(int number)
        {
            if (number < MaxNumberOfCopies)
            {
                return true;
            }

            return false;
        }
    }
}
