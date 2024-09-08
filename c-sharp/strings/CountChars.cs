
namespace c_sharp.strings
{
    public class CountChars
    {
        //Write a program in C# Sharp to count the number of alphabets, digits and special characters in a string.
        public static void Count(string str)
        {
            //string alphabets = "abcdefghijklmnopqrstuvwxyz";
            // digits = "0987654321";
            //string characters = "!@#$%^&*()_+-={}[]:;'\"/?.>,< ";
            int alphaCounter = 0; 
            int digitCounter = 0;
            int charCounter = 0;
            foreach (char c in str)
            {
                //if (alphabets.Contains(c)) alphaCounter++;
                //else if(digits.Contains(c)) digitCounter++;
                if(char.IsLetter(c)) alphaCounter++;
                else if(char.IsDigit(c)) digitCounter++;
                else charCounter++;
            }

            Console.WriteLine("There are {0} total alphabets in the string.",alphaCounter);
            Console.WriteLine("There are {0} total digits in the string.",digitCounter);
            Console.WriteLine("There are {0} total char's in the string.",charCounter);
           
        }
    }
}
