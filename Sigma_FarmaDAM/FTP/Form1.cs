using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.IO;
using System.Net;
using System.Text;

namespace FTP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

                // Get the object used to communicate with the server.
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(
                "172.17.6.0"
                );
                request.Method = WebRequestMethods.Ftp.UploadFile;
                // This example assumes the FTP site uses anonymous logon.
                request.Credentials =
                new
                NetworkCredential(
                "grupo1"
                ,
                "12345aA"
                );
                // Copy the contents of the file to the request stream.
                StreamReader sourceStream =
                new
                StreamReader(
                "testfile.txt"
                );
                byte
                [] fileContents = Encoding.UTF8.GetBytes(sourceStream.ReadToEnd());
                sourceStream.Close();
                request.ContentLength = fileContents.Length;
                Stream requestStream = request.GetRequestStream();
                requestStream.Write(fileContents, 0, fileContents.Length);
                requestStream.Close();
                FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                Console.WriteLine(
                "Upload File Complete, status {0}"
                , response.StatusDescription);
                response.Close();
        }
     }
 }


