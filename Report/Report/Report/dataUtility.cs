using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using System.IO;

namespace Report
{
    public class dataUtility: IDisposable
    {
        private string _dataPath;
        private string _dataFileXML;
        private DataTable _data;



        public bool LoadData()
        {
            bool result = false;

            _data = LoadDataXML();

            if (_data.Rows.Count > 0) {
                result = true;
            }
            
            return result;
        }

        private DataTable LoadDataXML()
        {
            // Create a new DataSet and read sales data file 
            //    data.xml into the first DataTable.
            DataSet dataSet = new DataSet();

            string _reportPath = Path.Combine(_dataPath, _dataFileXML);
            dataSet.ReadXml(_reportPath);

            return dataSet.Tables[0];
        }

        public string DataPath
        {
            get
            {
                return _dataPath;
            }

            set
            {
                _dataPath = value;
            }
        }

        public string DataFileXML
        {
            get
            {
                return _dataFileXML;
            }

            set
            {
                _dataFileXML = value;
            }
        }

        public DataTable Data
        {
            get
            {
                return _data;
            }

            set
            {
                _data = value;
            }
        }

        public void Dispose()
        {
            if (Data != null)
            {

                Data = null;
            }

            throw new NotImplementedException();
        }
    }
}