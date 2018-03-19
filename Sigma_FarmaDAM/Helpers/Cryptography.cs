using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Cryptography
{
    // see https://tekeye.uk/visual_studio/encrypt-decrypt-c-sharp-string

    public class Cryptography
    {
        /// <summary>
        /// Usa el strKey para generar un hash con el que encrypta strToEncrypt
        /// </summary>
        /// <param name="strToEncrypt">texto a encriptar</param>
        /// <param name="strKey">texto que se usara como llave para encriptar strToEncrypt</param>
        /// <returns>Texto encryptado</returns>
        public static string Encrypt(string strToEncrypt, string strKey)
        {
            try
            {
                TripleDESCryptoServiceProvider objDESCrypto = new TripleDESCryptoServiceProvider();
                MD5CryptoServiceProvider objHashMD5 = new MD5CryptoServiceProvider();
                byte[] byteHash, byteBuff;
                string strTempKey = strKey;
                byteHash = objHashMD5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(strTempKey));
                objHashMD5 = null;
                objDESCrypto.Key = byteHash;
                objDESCrypto.Mode = CipherMode.ECB; //CBC, CFB
                byteBuff = ASCIIEncoding.ASCII.GetBytes(strToEncrypt);
                return Convert.ToBase64String(objDESCrypto.CreateEncryptor().
                    TransformFinalBlock(byteBuff, 0, byteBuff.Length));
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}