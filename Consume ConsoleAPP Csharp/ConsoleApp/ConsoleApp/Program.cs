using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net; //importar biblioteca Client
using System.IO;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //Testando Console Basico
            Console.WriteLine("Testando C# - EducaCiencia FastCode");
            Console.ReadLine();
            */

           
            //DeleteAPI_Java
            DeleteAPI_Java();
            Console.ReadKey();
            

        }

       
        //Delete API Java SpringBoot - WebRequest
        public static void DeleteAPI_Java()
        {
            string endpointDelete = "http://localhost:8080/api/JPA/clientes/delete/";
            string id = "1";
            WebRequest request = WebRequest.Create(endpointDelete + id);
            request.Method = "DELETE";
            var response = (HttpWebResponse)request.GetResponse();

            if (((HttpWebResponse)response).StatusCode == HttpStatusCode.NoContent && (int)response.StatusCode == 204)
            {
                if ((int)response.StatusCode == 204)
                    Console.WriteLine("Deletado id " + id + " => OK ");
            }
            else
            {
                Console.WriteLine("Falha metodo Delete");
            }

        }
    }
}
