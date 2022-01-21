using System.Linq;

namespace LeetCode.Password
{
    public class PasswordChecker
    {
        public string PasswordValidation(string input)
        {

            var passord = string.Empty;


            if (input.Length >= 6 && input.Length <= 20)
            {
                if(input.Any(char.IsUpper) || input.Any(char.IsLower) || input.Any(char.IsDigit))
                {
                    char x = '1';
                    for (int i = 0; i < input.Length; i++)
                    {
                        x = input[i];
                    }
                }
            }
            return "asdf";
        }
    }
}
