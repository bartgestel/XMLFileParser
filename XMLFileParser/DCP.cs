using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XMLFileParser
{
    [Serializable]
    public class DCP
    {

        [XmlElement(ElementName = "Description")]
        public object Description { get; set; }

        [XmlElement(ElementName = "Event")]
        public List<Event> Event { get; set; }

        [XmlAttribute(AttributeName = "Id")]
        public string Id { get; set; }

        [XmlAttribute(AttributeName = "Name")]
        public string Name { get; set; }

        [XmlAttribute(AttributeName = "Persistent")]
        public string Persistent { get; set; }

        [XmlAttribute(AttributeName = "Interval")]
        public int Interval { get; set; }

        [XmlAttribute(AttributeName = "Defined")]
        public string Defined { get; set; }

        [XmlAttribute(AttributeName = "DefinedBy")]
        public string DefinedBy { get; set; }

        [XmlAttribute(AttributeName = "TimeDefined")]
        public DateTime TimeDefined { get; set; }
    }
}
