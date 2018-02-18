using System.Windows.Forms;

namespace Description_Maker
{
    class GeneratedItem
    {
        public Label Label { get; set; }
        public TextBox TextBox { get; set; }
        public string Desciption { get; set; }
    }

    static class CheckUserInput
    {
        const int MaxNumberOfCopies = 400;

        public static bool IsInputAnumber(TextBox box)
        {
            bool input = int.TryParse(box.Text, out int result);
            return input;
        }
        
        public static bool IsNumberTooLarge(int number)
        {
            if (number < MaxNumberOfCopies)
            {
                return true;
            }

            return false;
        }
    }
}
