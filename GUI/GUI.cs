using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryRosa;

namespace GettingRealRosa
{
    public partial class GUI : Form
    {
        public string tempType;
        public string tempNavn;
        public string tempFarve;
        public int tempPris;
        public int tempMængde;
        public string tempName;
        public DataSetHandler Handler;

        /*static int Rowid { get; private set; }*/

        public GUI(DataSetHandler handler)
        {
            InitializeComponent();
            Handler = handler;

            GarnDataView.AutoGenerateColumns = true;
            GarnDataView.DataSource = Handler.read();
        }

        private void ænderGarnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ÆndreGarn().Show();
        }


        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            

            
        }



        private void opretGarnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            OpretGarn opret = new OpretGarn(Handler);
            opret.ShowDialog();
            GarnDataView.ClearSelection();
            GarnDataView.AutoGenerateColumns = true;
            GarnDataView.DataSource = Handler.read();
        }

        private void sletGarnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SletGarn().Show();
        }

        /*private void button1_Click(object sender, EventArgs e)
        {
            if (clickBool == true)
            {
                GarnDataView.Rows[rowid].Cells[0].Value = tempType;
                GarnDataView.Rows[rowid].Cells[1].Value = tempNavn;
                GarnDataView.Rows[rowid].Cells[2].Value = tempFarve;
                GarnDataView.Rows[rowid].Cells[3].Value = tempPris;
                GarnDataView.Rows[rowid].Cells[4].Value = tempMængde;
                rowid++;
                clickBool = false;
            }
            testLabel = DateTime.Now.ToString();
        }*/

        private void GUI_Load(object sender, EventArgs e)
        {
           
        }


    }
}
