using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

//using System;
using System.IO;
using System.Data;
using System.Text;
using System.Drawing.Imaging;
using System.Drawing.Printing;
//using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.Reporting.WebForms;
using System.Drawing;

namespace Report
{
    public class repoUtilityRDLC: IDisposable
    {
        //private int m_currentPageIndex;
        private IList<Stream> m_streams;
        private string _reportPath;
        private string _reportFile;
        private string _reportPathFileXML;
        private string _reportDataFileXML;


        private DataTable LoadSalesData()
        {
            // Create a new DataSet and read sales data file 
            //    data.xml into the first DataTable.
            DataSet dataSet = new DataSet();

            _reportPath = Path.Combine(_reportPathFileXML, _reportDataFileXML);
            dataSet.ReadXml(_reportPath);

            return dataSet.Tables[0];
        }

        // Routine to provide to the report renderer, in order to
        //    save an image for each page of the report.
        private Stream CreateStream(string name,
                                    string fileNameExtension, Encoding encoding,
                                    string mimeType, bool willSeek)
        {
            Stream stream = new MemoryStream();
            m_streams.Add(stream);
            return stream;
        }

        // Export the given report as an PDF (Portable Document Format) file.
        public   Stream ExportPDF()
        {

            const string reportType = "PDF";
            string encoding;
            string fileNameExtension;
            string mimeType;
            string[] streams;
            Warning[] warnings;
            

            _reportPath = Path.Combine(this._reportPath, this._reportFile);
            
            LocalReport report = new LocalReport();
            report.ReportPath = _reportPath;

            report.DataSources.Add(new ReportDataSource("Sales", LoadSalesData()));

            string deviceInfo =
              @"<DeviceInfo>
                <OutputFormat>EMF</OutputFormat>
                <PageWidth>8.5in</PageWidth>
                <PageHeight>11in</PageHeight>
                <MarginTop>0.25in</MarginTop>
                <MarginLeft>0.25in</MarginLeft>
                <MarginRight>0.25in</MarginRight>
                <MarginBottom>0.25in</MarginBottom>
            </DeviceInfo>";

            //Render the report

            byte[] bytes =
             report.Render(reportType,
                            deviceInfo,
                            out mimeType,
                            out encoding,
                            out fileNameExtension,
                            out streams,
                            out warnings);
            
            return  new MemoryStream(bytes); ;

        }

        
        public void Dispose()
        {
            if (m_streams != null)
            {
                foreach (Stream stream in m_streams)
                    stream.Close();
                m_streams = null;
            }
        }

        public string ReportPath
        {
            get
            {
                return _reportPath;
            }

            set
            {
                _reportPath = value;
            }
        }

        public string ReportFile
        {
            get
            {
                return _reportFile;
            }

            set
            {
                _reportFile = value;
            }
        }

        public string ReportDataFileXML
        {
            get
            {
                return _reportDataFileXML;
            }

            set
            {
                _reportDataFileXML = value;
            }
        }

        public string ReportPathFileXML
        {
            get
            {
                return _reportPathFileXML;
            }

            set
            {
                _reportPathFileXML = value;
            }
        }

        public static void Main(string[] args)
        {
           
        }


    }
}