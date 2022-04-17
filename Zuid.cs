using System;

namespace Kodachi
{
    public class Zuid
    {
        public static string Compress(Guid guid)
        {
            return Convert.ToBase64String(
                    BitConverter.GetBytes(BitConverter.ToInt64(guid.ToByteArray())))
                .Replace("/", "-").Replace("+", "_")
                .Replace("=", "");
        }

        public static string Compress32(Guid guid)
        {
            return Convert.ToBase64String(
                    BitConverter.GetBytes(BitConverter.ToInt32(guid.ToByteArray())))
                .Replace("/", "-").Replace("+", "_")
                .Replace("=", "");
        }
    }
}
