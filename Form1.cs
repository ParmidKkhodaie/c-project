using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DXApplication15
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            HADAFEntities db = new HADAFEntities();
            
            tblMoshtari m1 = new tblMoshtari                 

            {
                FullName = "parmida",
                Famil = "khodaie",
                Address = "ahvaz",
                Jensiat = 1,
                Tell = "0916283887",
                
            };

            db.tblMoshtari.Add(m1);

            db.saveChanges();

            txtTedad.Text = "";
            txtTozihat.Text = "";
                    

            //MessageBox.Show("+m1.Name+""در پایگاه داده ذخیره شد")
        }

        //private void txtbtnSave_Click(object sender, eventArgs e)
        // {


        // }

        // private void textEdit1_EditValueChanged_1(object sender, EventArgs e)
        // {

    }




        private void Form1_Load(object sender, EventArgs e)
        {
            HadafEntities db = new HadafEntities();

            TblMoshtari m1 = new TblMoshtari()
            {

        //private void txtbtnSave_Click(object sender, EventArgs e)
        // {

        // }

        //  private void textEdet1_EditValuechanged_1(object sender, EventArgs e)
        // {

    }

        private void spinEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void memoEdit1_EditValueChanged(object sender, EventArgs e)
        {



        }

        private void spinEdit1_EditValueChanged_1(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }

        private void textEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
