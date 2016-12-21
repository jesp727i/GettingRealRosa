using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;

namespace ClassLibraryRosa
{
    public class DataSetHandler
    {
        DataSet Data;
        int ItemCount;

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



        }
        public void SaveToXmlFile(List<Garn> garnlist)
        {
            foreach (Garn Item in garnlist)
            {
                DataRow datarow = Data.Tables["garn"].NewRow();
                datarow["VareNr"] = Item.VareNr;
                datarow["Name"] = Item.Name;
                datarow["Color"] = Item.Color;
                datarow["Type"] = Item.Type;
                datarow["Amount"] = Item.Amount;
                datarow["Price"] = Item.Price;
                Data.Tables["garn"].Rows.Add(datarow);
            }
            DateTime date = DateTime.Today;
            string filePath = "../database/" + date.ToString("yyyyMMdd") + "data.xml";
            Data.WriteXml(filePath);
        }

        public DataTable read()
        {
            DataSet ds = Data;
            DataTable dtAll = ds.Tables[0].Copy();
            
            return dtAll;
        }
        public void AddToDataSet(Garn garn)
        {
            ItemCount++;
            DataRow datarow = Data.Tables["garn"].NewRow();
            datarow["VareNr"] = ItemCount;
            datarow["Name"] = garn.Name;
            datarow["Color"] = garn.Color;
            datarow["Type"] = garn.Type;
            datarow["Amount"] = garn.Amount;
            datarow["Price"] = garn.Price;
            Data.Tables["garn"].Rows.Add(datarow);
        }

    }
}
