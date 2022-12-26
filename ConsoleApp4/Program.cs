using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using mSimplePrintLabel;
using RestSharp;
using RestSharp.Authenticators;

namespace ConsoleApp4
{
    internal class Program
    {
        public static async Task<string> IndexAsync()
        {
            var url = "https://reqres.in/api/users?page=2";
            var client = new RestClient(url);
            var request = new RestRequest(url, Method.Get);
            RestResponse response = await client.ExecuteAsync(request);
            var Output = response.Content;
            Console.WriteLine(Output.ToString());
            return Output;
        }

        static void Main(string[] args)
        {
            string filePath = @"D:\test.lab";
            if (File.Exists(filePath))
            {
                //Console.WriteLine(DateTime.Now);

                // Open a file connection.
                string result = Codesoft.OpenSampleFile(filePath);
                //Console.WriteLine(result + " : " + DateTime.Now);
                /*
                LabelManager2.Document doc = Codesoft.doc;
                doc.Variables.Item("Var0").Value = "AAAA";
                doc.Variables.Item("Var1").Value = "BBBB";
                doc.Variables.Item("Var2").Value = "CCCC";
                doc.Variables.Item("Var3").Value = "DDDD";
                doc.Variables.Item("Var4").Value = "EEEE";
                doc.Variables.Item("Var5").Value = "FFFF";
                doc.PrintDocument();
                */
                
                //doc.Save();

                //Console.WriteLine(doc.Variables.Count + doc.Name);



                //doc.Variables.Item("Var0").Value = "BBBB";
                //doc.PrintDocument();
                //Console.WriteLine(doc.Printer.Name);
                // SATO CL4NX Plus 203dpi
                //doc.PrintLabel(1);





                // Close a file connection.
                result = Codesoft.CloseSampleFile();
                //Console.WriteLine(result + " : " + DateTime.Now);
            }

            //IndexAsync();
            
            /*
            Dictionary<string, string> variables = new Dictionary<string, string>();
            variables.Add("Var0","SATO Printer");
            string re = SATOPrinterAPI.Utils.CommandDataReplace(@"D:\test.lab", variables);*/

        }
    }
}
