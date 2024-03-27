using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XMLFileParser
{
    [XmlRoot(ElementName = "Event")]
    public class Event
    {

        [XmlElement(ElementName = "Parameters")]
        public Parameters Parameters { get; set; }

        [XmlAttribute(AttributeName = "Id")]
        public string Id { get; set; }

        [XmlAttribute(AttributeName = "SourceId")]
        public string SourceId { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, SourceId: {SourceId}";
        }
    }
}
