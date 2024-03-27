using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XMLFileParser
{
    [XmlRoot(ElementName = "Parameter")]
    public class Parameter
    {

        [XmlAttribute(AttributeName = "Name")]
        public string Name { get; set; }

        [XmlAttribute(AttributeName = "SourceId")]
        public string SourceId { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, SourceId: {SourceId}";
        }
    }
}
