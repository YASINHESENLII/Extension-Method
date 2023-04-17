namespace Extention_method
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int myNumber = 5;
            bool isOdd = myNumber.IsOdd();
            bool isEven = myNumber.IsEven();

            string myText = "32!";
            bool hasDigit = myText.Hasdigit();
            string capitalizedText = myText.Capitalize();

            string myPassword = "pas";
            bool isValidPassword = myPassword.CheckPassword();

            Console.WriteLine(isOdd);
            Console.WriteLine(isEven);
            Console.WriteLine(  hasDigit);
            Console.WriteLine(capitalizedText);
            Console.WriteLine(isValidPassword);






        }

    }

}















