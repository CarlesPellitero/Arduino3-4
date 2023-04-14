using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreensProgram
{
    public class GenerateToken
    {
        //Crear un token para el usuario de dos min.
        public static byte[] GeneratedToken(byte[] data)
        {
            byte[] time = BitConverter.GetBytes(DateTime.UtcNow.ToBinary());
            byte[] key = Guid.NewGuid().ToByteArray();
            string token = Convert.ToBase64String(time.Concat(key).ToArray());
            data = Convert.FromBase64String(token);
            return data;
        }
    }
}
