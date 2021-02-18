using layer_1;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace layer_2
{
    public class p_crypto
    {
        public readonly static Random random = new Random();
        public static byte[] convert(object obj)
        {
            var str = JsonConvert.SerializeObject(obj);
            return Encoding.UTF8.GetBytes(str);
        }
        public static T convert<T>(byte[] data, Type type = null)
        {
            var str = Encoding.UTF8.GetString(data);
            if (type == null)
                return JsonConvert.DeserializeObject<T>(str);
            else
                return (T)JsonConvert.DeserializeObject(str, type);
        }
        public static (byte[] publickey, byte[] privatekey) create_asymmetrical_keys()
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            var publickey = rsa.ExportCspBlob(false);
            var privatekey = rsa.ExportCspBlob(true);
            return (publickey, privatekey);
        }
        public static m_key create_symmetrical_keys()
        {
            byte[] key32 = new byte[32];
            byte[] iv16 = new byte[16];
            random.NextBytes(key32);
            random.NextBytes(iv16);
            return new m_key() { key32 = key32, iv16 = iv16 };
        }
        public static byte[] Encrypt(byte[] data, byte[] publickey)
        {
            byte[] encryptedData;
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            rsa.ImportCspBlob(publickey);
            encryptedData = rsa.Encrypt(data, true);
            rsa.Dispose();
            return encryptedData;
        }
        public static byte[] Decrypt(byte[] data, byte[] privatekey)
        {
            byte[] decryptedData;
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            rsa.ImportCspBlob(privatekey);
            decryptedData = rsa.Decrypt(data, true);
            rsa.Dispose();
            return decryptedData;
        }
        public static byte[] Encrypt(byte[] data, m_key keys)
        {
            MemoryStream memoryStream;
            CryptoStream cryptoStream;
            Rijndael rijndael = Rijndael.Create();
            rijndael.Key = keys.key32;
            rijndael.IV = keys.iv16;
            memoryStream = new MemoryStream();
            cryptoStream = new CryptoStream(memoryStream, rijndael.CreateEncryptor(), CryptoStreamMode.Write);
            cryptoStream.Write(data, 0, data.Length);
            cryptoStream.Close();
            return memoryStream.ToArray();
        }
        public static byte[] Decrypt(byte[] data, m_key keys)
        {
            MemoryStream memoryStream;
            CryptoStream cryptoStream;
            Rijndael rijndael = Rijndael.Create();
            rijndael.Key = keys.key32;
            rijndael.IV = keys.iv16;
            memoryStream = new MemoryStream();
            cryptoStream = new CryptoStream(memoryStream, rijndael.CreateDecryptor(), CryptoStreamMode.Write);
            cryptoStream.Write(data, 0, data.Length);
            cryptoStream.Close();
            return memoryStream.ToArray();
        }
        public static byte[] combine(params byte[][] arrays)
        {
            byte[] rv = new byte[arrays.Sum(a => a.Length)];
            int offset = 0;
            foreach (byte[] array in arrays)
            {
                Buffer.BlockCopy(array, 0, rv, offset, array.Length);
                offset += array.Length;
            }
            return rv;
        }
        public static byte[] split(byte[] val, int offset, int length)
        {
            byte[] dv = new byte[length];
            Buffer.BlockCopy(val, offset, dv, 0, length);
            return dv;
        }
        public static void filekeys(Environment.SpecialFolder folder)
        {
            var dv = create_asymmetrical_keys();
            write(folder, "public_key", dv.publickey);
            write(folder, "private_key", dv.privatekey);
        }

        private static void write(Environment.SpecialFolder folder, string filename, byte[] data)
        {
            string str =
            @"public class $class
            {
                public static byte[] data = new byte[]
                {
$data
                };
            }";
            string dv = "";
            for (int i = 0; i < data.Length; i++)
            {
                byte val = data[i];
                dv += val + ",";
                if ((i + 1) % 11 == 0)
                    dv += "\n";
            }
            str = str.Replace("$class", filename);
            str = str.Replace("$data", dv);
            File.WriteAllText(Environment.GetFolderPath(folder) + @"\" + filename + ".cs", str);
        }
    }
}