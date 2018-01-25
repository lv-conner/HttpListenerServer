using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using System.Net.Http;
using System.Net;

namespace TestConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpListener httpListener = new HttpListener();
            httpListener.Prefixes.Add("http://localhost:12450/Test/");
            httpListener.Start();
            while(true)
            {
                HttpListenerContext httpListenerContext = httpListener.GetContext();
                byte[] repsonse = System.Text.UnicodeEncoding.Unicode.GetBytes("Hello");
                httpListenerContext.Response.StatusCode = 200;
                httpListenerContext.Response.ContentType = "text/html";
                httpListenerContext.Response.OutputStream.Write(repsonse, 0, repsonse.Length);
                httpListenerContext.Response.Close();
                //Console.WriteLine(httpListenerContext.Request.QueryString);

            }


        }


        
    }
}
