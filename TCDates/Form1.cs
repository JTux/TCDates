using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace TCDates
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bigRedButton_Click(object sender, EventArgs e)
        {
            WriteToXML();
        }

        private void WriteToXML()
        {
            XmlTextWriter textWriter = new("test.xml", null);
            textWriter.WriteStartDocument();
            textWriter.WriteComment("First comment");
            textWriter.WriteStartElement("Test");
            textWriter.WriteStartElement("Test2");
            textWriter.WriteEndElement();
            textWriter.WriteEndDocument();
            textWriter.Close();
        }
    }
}
