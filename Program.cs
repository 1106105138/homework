using _1106105138.services;
using System;

namespace _1106105138
{
    class Program
    {
        static void Main(string[] args)
        {
            var xmlService1 = new ImportXmlService();

            var datas = xmlService1.LoadFormFile(@"D:\Data\code\1106105138\docs\氣象站.xml");


            Console.WriteLine(string.Format("分析完成，共有{0}筆資料", datas.Count));
            datas.ForEach(x =>
            {
                Console.WriteLine(string.Format("編號 :{0} 描述:{1}",x.stationID,x.stationAddress));
            });

            Console.ReadKey();
        }
    }
}
