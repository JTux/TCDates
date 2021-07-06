using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            VerifyXmlExists();
        }

        private void bigRedButton_Click(object sender, EventArgs e)
        {
            InsertDate();
        }

        private void VerifyXmlExists()
        {
            if (!File.Exists("data.xml"))
            {
                XmlTextWriter textWriter = new("data.xml", null);
                textWriter.WriteStartElement("ClickEvents");
                textWriter.WriteEndElement();
                textWriter.Close();
            }
        }

        private void InsertDate()
        {
            XDocument doc = XDocument.Load("data.xml");
            XElement clickEvents = doc.Element("ClickEvents");
            clickEvents.Add(new XElement("Date", DateTime.Now.ToString("O")));
            doc.Save("data.xml");
        }
    }
}
