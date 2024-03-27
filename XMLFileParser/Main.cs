using System.Xml.Serialization;

namespace XMLFileParser
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            ofdXML.ShowDialog();
        }

        private void ofdXML_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            lbxEvents.Items.Clear();
            string filePath = ofdXML.FileName;
            XmlSerializer serializer = new XmlSerializer(typeof(DCP));
            DCP dcp;

            using (StreamReader reader = new StreamReader(filePath))
            {
                dcp = (DCP)serializer.Deserialize(reader);
            }

            lblId.Text = dcp.Id;
            lblName.Text = dcp.Name;
            foreach (Event ev in dcp.Event)
            {
                lbxEvents.Items.Add(ev);
            }
        }

        private void lbxEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = lbxEvents.SelectedIndex;
            lbxParameters.Items.Clear();
            foreach (Parameter param in ((Event)lbxEvents.Items[selectedIndex]).Parameters.Parameter)
            {
                lbxParameters.Items.Add(param);
            }
        }
    }
}
