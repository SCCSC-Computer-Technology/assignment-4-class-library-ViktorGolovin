namespace Viktor_Golovin_CPT_206_ClassLibrary
{

    //Class for error message methods, call in main program for when the user inputs the wrong type (int, string, etc)
    public class Errors
    {
        public static void numError()
        {
            MessageBox.Show("Error, Please enter a number, not text");
        }

        public static void stringError()
        {
            MessageBox.Show("Error, Please enter a string, not a number");
        }

        public static void otherError()
        {
            MessageBox.Show("Error, Please enter a valid input, or restart application.");
        }
    }
}
