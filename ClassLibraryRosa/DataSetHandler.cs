﻿using System;
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
            for (int i = 1; i <= 5; i++)
            {
                DataRow datarow = Data.Tables["garn"].NewRow();
                datarow["VareNr"] = i;
                datarow["Name"] = "kage";
                datarow["Color"] = "blå";
                datarow["Type"] = "garn";
                datarow["Amount"] = 2;
                datarow["Price"] = 1.20;
                Data.Tables["garn"].Rows.Add(datarow);
            }
            ItemCount = 5;



        }
        public void SaveToXmlFile(List<Garn> garnlist)
        {
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
