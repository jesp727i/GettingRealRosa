using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;

namespace GettingRealRosa
{
    public class DataSetHandler
    {
        DataSet Data;

        public DataSetHandler()
        {
            Data = new DataSet();
            DataTable GarnTable = Data.Tables.Add("garn");
            DataColumn pkVareNr =
            GarnTable.Columns.Add("VareNr", typeof(Int64));
            GarnTable.Columns.Add("Name", typeof(String));
            GarnTable.Columns.Add("Color", typeof(String));
            GarnTable.Columns.Add("Type", typeof(String));
            GarnTable.Columns.Add("Amount", typeof(Int64));
            GarnTable.Columns.Add("Price", typeof(Double));
            GarnTable.PrimaryKey = new DataColumn[] { pkVareNr };
            DataRow datarow = Data.Tables["garn"].NewRow();
            datarow["VareNr"] = 1;
            datarow["Name"] = "kage";
            datarow["Color"] = "blå";
            datarow["Type"] = "garn";
            datarow["Amount"] = 2;
            datarow["Price"] = 1.20;
            Data.Tables["garn"].Rows.Add(datarow);
            datarow = Data.Tables["garn"].NewRow();
            datarow["VareNr"] = 2;
            datarow["Name"] = "kagew";
            datarow["Color"] = "blåw";
            datarow["Type"] = "garnw";
            datarow["Amount"] = 2;
            datarow["Price"] = 1.20;
            Data.Tables["garn"].Rows.Add(datarow);



        }
        public void SaveToXmlFile()
        {
            DateTime date = DateTime.Today;
            string filePath = "../database/" + date.ToString("yyyyMMdd") + "data.xml";
            Data.WriteXml(filePath);
        }


    }
}
