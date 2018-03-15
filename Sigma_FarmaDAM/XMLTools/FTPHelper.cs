﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace XMLTools
{
    public class FTPHelper
    {
        public static bool UploadFile(string path)
        {
            try
            {
                // Get the object used to communicate with the server.
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(
                "ftp://172.17.6.0/Grupo_1/1/" + path
                );
                request.Method = WebRequestMethods.Ftp.UploadFile;
                // Nos logeamos
                request.Credentials =
                new NetworkCredential("grupo1", "12345aA");
                // Copy the contents of the file to the request stream.
                StreamReader sourceStream = new StreamReader(path);
                byte[] fileContents = Encoding.UTF8.GetBytes(sourceStream.ReadToEnd());
                sourceStream.Close();
                request.ContentLength = fileContents.Length;
                Stream requestStream = request.GetRequestStream();
                requestStream.Write(fileContents, 0, fileContents.Length);
                requestStream.Close();
                FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                //("Upload File Complete, status {0}", response.StatusDescription);
                response.Close();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
