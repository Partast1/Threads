﻿using System;
using System.IO;
using System.Net;
using System.Net.Http;

namespace Webside
{
    class Program
    {
        //private static readonly HttpClient client = new HttpClient();
        static void Main(string[] args)
        {
            // Create a request for the URL.   
            WebRequest request = WebRequest.Create(
              "https://www.google.com");
            // If required by the server, set the credentials.  
            request.Credentials = CredentialCache.DefaultCredentials;

            // Get the response.  
            WebResponse response = request.GetResponse();
            // Display the status.
            Console.WriteLine(((HttpWebResponse)response).StatusDescription);

            // Get the stream containing content returned by the server. 
            // The using block ensures the stream is automatically closed. 
            using (Stream dataStream = response.GetResponseStream())
            {
                // Open the stream using a StreamReader for easy access.  
                StreamReader reader = new StreamReader(dataStream);
                // Read the content.  
                string responseFromServer = reader.ReadToEnd();
                // Display the content.  
                Console.WriteLine(responseFromServer);
            }

            // Close the response.  
            response.Close();
        }
    }
}
