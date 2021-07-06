﻿using System;
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
            VerifyXmlExists();
            InitializeComponent();
        }

        private void bigRedButton_Click(object sender, EventArgs e)
        {
            InsertDate();
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            using (var saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "CSV|*.csv";
                saveDialog.Title = "Export data";
                saveDialog.FileName = $"DateExport({DateTime.Today.ToString("M-d-yy")})";

                DialogResult result = saveDialog.ShowDialog();

                if (result == DialogResult.OK && saveDialog.FileName != "")
                {
                    var filePath = saveDialog.FileName;
                    StreamWriter sw = new(filePath);

                    sw.WriteLine("\"Date\",\"Time\"");
                    foreach (var date in GetDatesFromXml())
                    {
                        sw.WriteLine("\"{0}\",\"{1}\"", date.ToShortDateString(), date.ToShortTimeString());
                    }
                    sw.Close();
                }
            }
        }

        /// <summary>
        /// Reads from the data.xml and returns an IEnumerable with all parsed DateTimes recorded
        /// </summary>
        /// <returns></returns>
        private IEnumerable<DateTime> GetDatesFromXml()
        {
            VerifyXmlExists();
            var nodes = XElement.Load("data.xml").Elements("Date");
            return nodes.Select(e => DateTime.Parse(e.Value));
        }

        /// <summary>
        /// Insert a new Date node with the current DateTime into the data.xml file.
        /// </summary>
        private void InsertDate()
        {
            VerifyXmlExists();
            XDocument doc = XDocument.Load("data.xml");
            XElement clickEvents = doc.Element("ClickEvents");
            clickEvents.Add(new XElement("Date", DateTime.Now.ToString("O")));
            doc.Save("data.xml");
        }

        /// <summary>
        /// Verifies the data.xml file exists and creates it if it does not.
        /// </summary>
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
    }
}
