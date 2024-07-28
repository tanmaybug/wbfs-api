using BCrypt.Net;

namespace WbfsApi.Helpers
{
    public class CustomHashing
    {
        public string CreateHash(String data)
        {
            var HashValue = BCrypt.Net.BCrypt.EnhancedHashPassword(data, workFactor: 11, HashType.SHA512);
            return HashValue;
        }

        public bool VerifyHash(String data, String HashData)
        {
            var verifyStatus = BCrypt.Net.BCrypt.EnhancedVerify(data, HashData, HashType.SHA512);
            return verifyStatus;
        }
    }
}
