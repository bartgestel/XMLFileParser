using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XMLFileParser
{
    [XmlRoot(ElementName = "Parameters")]
    public class Parameters
    {

        [XmlElement(ElementName = "Parameter")]
        public List<Parameter> Parameter { get; set; }

        public override string ToString()
        {
            return $"{Parameter}";
        }
    }
}
