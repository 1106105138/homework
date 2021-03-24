using _1106105138.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1106105138.services
{
    public class ImportXmlService
    {
        public ImportXmlService() { }  
            public List<station> LoadFormFile(string filePath)
            {
                var str = System.IO.File.ReadAllText(filePath);

                var xDocument = System.Xml.Linq.XDocument.Parse(str);

                var targets = xDocument.Descendants("station");

                return targets
                    .Select(x =>
                    {
                        var item = new station();
                        item.startDate = x.Element("startDate").Value;
                        item.stationID = x.Element("stationID").Value;
                        item.stationAddress = x.Element("stationAddress").Value;
                        return item;
                    })
                    .ToList();
            }
    }
}
