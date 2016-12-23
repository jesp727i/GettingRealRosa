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
        //int ItemCount;

        public DataSetHandler(ProductReposetory GarnListe)
        {
            Data = new DataSet();

            Data.ReadXml("../database/data.Xml", XmlReadMode.InferSchema);
            foreach (DataTable table in Data.Tables)
            {

                foreach (var row in table.AsEnumerable())
                {
                    List<object> list = new List<object>();
                   
                    int VareNr = int.Parse("" + row[0]);
                    string name = "" + row[1];
                    string color = "" + row[2];
                    string type = "" + row[3];
                    int amount = int.Parse("" + row[4]);
                    double price = double.Parse("" + row[5]);

                    Garn garn = new Garn(VareNr, type, name, amount, price, color);
                    GarnListe.AddProduct(garn);
                }
            }

            //DataTable GarnTable = Data.Tables.Add("garn");
            //DataColumn pkVareNr =
            //GarnTable.Columns.Add("VareNr", typeof(Int64));
            //GarnTable.Columns.Add("Name", typeof(String));
            //GarnTable.Columns.Add("Color", typeof(String));
            //GarnTable.Columns.Add("Type", typeof(String));
            //GarnTable.Columns.Add("Amount", typeof(Int64));
            //GarnTable.Columns.Add("Price", typeof(Double));
            //GarnTable.PrimaryKey = new DataColumn[] { pkVareNr };



        }
        public void SaveToXmlFile(List<Garn> garnlist)
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
            string filePath = "../database/data.xml";
            //FileInfo file = new FileInfo(filePath);
            //" + date.ToString("yyyyMMdd") + "
            //file.Delete();
            //File.Delete(filePath);
            Data.WriteXml(filePath);
        }

        public DataTable read()
        {
            DataSet ds = Data;
            DataTable dtAll = ds.Tables[0].Copy();
            
            return dtAll;
        }
        public void LoadFromXmlFile()
        {

        }
        //public void AddToDataSet(Garn garn)
        //{
        //    ItemCount++;
        //    DataRow datarow = Data.Tables["garn"].NewRow();
        //    datarow["VareNr"] = ItemCount;
        //    datarow["Name"] = garn.Name;
        //    datarow["Color"] = garn.Color;
        //    datarow["Type"] = garn.Type;
        //    datarow["Amount"] = garn.Amount;
        //    datarow["Price"] = garn.Price;
        //    Data.Tables["garn"].Rows.Add(datarow);
        //}

    }
}
