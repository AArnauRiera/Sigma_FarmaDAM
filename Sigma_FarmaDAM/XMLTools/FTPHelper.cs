using System;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace XMLTools
{
    public class FTPHelper
    {
        /// <summary>
        /// Sube el archivo definido al servidor FTP
        /// </summary>
        /// <param name="path">Ruta completa del archivo a subir</param>
        public static void UploadFile(string path)
        {
            try
            {
                // Pasamos la ruta completa al FTP
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create("ftp://172.17.6.0/Grupo_1/1/" + path);
                request.Method = WebRequestMethods.Ftp.UploadFile;
                // Nos logeamos
                request.Credentials = new NetworkCredential("grupo1", "12345aA");
                // Copia los contenidos del archivo al stream
                StreamReader sourceStream = new StreamReader(path);
                byte[] fileContents = Encoding.UTF8.GetBytes(sourceStream.ReadToEnd());
                sourceStream.Close();
                sourceStream.Dispose();
                request.ContentLength = fileContents.Length;
                Stream requestStream = request.GetRequestStream();
                requestStream.Write(fileContents, 0, fileContents.Length);
                requestStream.Close();
                requestStream.Dispose();
                FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                response.Close();
                response.Dispose();
                MessageBox.Show("Archivo subido al FTP correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
