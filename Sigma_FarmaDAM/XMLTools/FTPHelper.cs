using System;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace XMLTools
{
    public class FTPHelper
    {
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
                request.ContentLength = fileContents.Length;
                Stream requestStream = request.GetRequestStream();
                requestStream.Write(fileContents, 0, fileContents.Length);
                requestStream.Close();
                FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                response.Close();
                MessageBox.Show("Archivo subido al FTP correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
