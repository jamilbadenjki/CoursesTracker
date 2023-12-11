using BookWithDoctor.Publics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookWithDoctor
{
    public partial class FRM_Books : Form
    {
        public FRM_Books()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            lstBooks.Items.RemoveAt(lstBooks.SelectedIndex);
        }

        private void FRM_Books_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < CLS_List.LsSize(); i++)
            {
                lstBooks.Items.Add(CLS_List.Show(i.ToString()));
            }
        }
    }
}
