using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Reflection;

namespace LearningLine.Practice
{
   
    [XmlRoot("order")]
    public class SalesOrder
    {
        public string Customer { get; set; }
        [XmlElement("orderid", Order = 1)]
        public int Number { get; set; }
        [XmlIgnore]
        public string Notes { get; set; }
        [XmlAttribute("version")]
        public string Version
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
            set
            {
                // ignore
            }
        }
    }
}
