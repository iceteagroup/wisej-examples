using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;

namespace WiseJ.DataGridViewSummaryRows.data
{
    public class dataPurchaseDataSet
    {
        private DataTable _dtHeader, _dtDetail;
        private DataSet _dsData;

        public DataSet DsData
        {
            get
            {
                return _dsData;
            }

            set
            {
                _dsData = value;
            }
        }

        public bool LoadData(string sPath, string sFileXML, string sTableName)
        {
            bool result;
            result = false;
            
            // Create a new DataSet and read sales data file 
            if (DsData == null)
            {
                DsData = new DataSet();
            }

            DataSet _dsDataXML = new DataSet();
            string _reportPath = Path.Combine(sPath, sFileXML);
            _dsDataXML.ReadXml(_reportPath);

            //Add table from readed XmlFile into DataSet
            DataTable dtData = new DataTable();
            
            dtData = _dsDataXML.Tables[0].Copy();
            dtData.TableName = sTableName;

            DsData.Tables.Add(dtData);
            
            result = true;
            return result;
        }

        public bool SetDataRelation(string RelationName,
                                    string tableParent, 
                                    string tableChild, 
                                    string tableParentID, 
                                    string tableChildID)
        {
            bool result = false;

            try
            {
                // Establish a relationship between the two tables.
                DataRelation relation = new DataRelation(RelationName,
                    DsData.Tables[tableParent].Columns[tableParentID],
                    DsData.Tables[tableChild].Columns[tableChildID]);
                DsData.Relations.Add(relation);

                result = true;
            }
            catch (Exception)
            {

                throw;
            }
            return result;
        }


        private bool LoadXmlFile(string XMLFIle, DataTable dt)
        {
            bool result;
            result = false;






            return result;
        }


    }
}