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
    public partial class OpretGarn : Form
    {
        public string tempType;
        public string tempNavn;
        public string tempFarve;
        public double tempPris;
        public int tempMængde;
        public DataSetHandler Handler;
        /*private object testLabel;*/

        public OpretGarn(DataSetHandler handler)
        {
            InitializeComponent();
            Handler = handler;
        }
        
        public void NavnText_TextChanges (object sender, EventArgs e)
        {
            TextBox NavnText = (TextBox)sender;
            tempNavn = NavnText.Text;
        }
        public void TypeText_TextCanges(object sender, EventArgs e)
        {
            TextBox TypeText = (TextBox)sender;
            tempType = TypeText.Text;
        }
        public void FarveText_TextChanges(object sender, EventArgs e)
        {
            TextBox FarveText = (TextBox)sender;
            tempFarve = FarveText.Text;
        }
        public void Pris_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown pris = (NumericUpDown)sender;
            tempPris = Convert.ToDouble(pris.Value);
        }
       private void Mænde_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown Mængde = (NumericUpDown)sender;
            tempMængde = Convert.ToInt32(Mængde.Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Garn garn = new Garn(OpretGarnTextType.Text, OpretGarnTextNavn.Text, Convert.ToInt32(textBox10.Text), Convert.ToDouble(textBox9.Text) , OpretGarnTextType.Text);
            Handler.AddToDataSet(garn);
            this.Close();
        }

        /*private void BindingContext_Changes(object sender, EventArgs e)
        {
            Console.WriteLine("BindingContext Changed");
        
        }*/
        private void GarnTypeTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
