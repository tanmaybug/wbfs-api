using System.Text;

namespace WbfsApi.Helpers
{
    public class PasswordGenerator
    {
        private static readonly char[] chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        private static readonly char[] number = "1234567890".ToCharArray();
        private static readonly char[] symbol = "@#$&".ToCharArray();


        public string GenerateRandomPassword()
        {
            int Charlength = 4;
            int Numlength = 3;
            int symlength = 2;
            StringBuilder password = new();
            Random random = new();

            for (int i = 0; i < Charlength; i++)
            {
                int index = random.Next(chars.Length);
                password.Append(chars[index]);
            }
            for (int i = 0; i < symlength; i++)
            {
                int index = random.Next(symbol.Length);
                password.Append(symbol[index]);
            }
            for (int i = 0; i < Numlength; i++)
            {
                int index = random.Next(number.Length);
                password.Append(number[index]);
            }

            return password.ToString();
        }
    }
}
