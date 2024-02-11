using System;
using System.Net.Http.Json;
using System.Text.Json.Serialization;


namespace ConsoleApp3

{
    internal class Program
    {
        static void Main(string[] args)
        {
            string json = "{\"Name\":\"Semen\",\"Surename\":\"Semenov\",\"ID\":1,\"DEPT\":\"Teacher\"}";

            var jsonObj = JsonConvert.DeserializeObject(json) as JObject;

            XDocument xmlDoc = new XDocument(new XElement("Root", jsonObj.Properties().Select(p => new XElement(p.Name, p.Value))));
            xmlDoc.Save("output.xml");
        }


    }
}