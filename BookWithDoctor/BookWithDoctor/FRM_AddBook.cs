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
    public partial class FRM_AddBook : Form
    {
        public FRM_Main FRM_Main;
        public FRM_AddBook()
        {
            InitializeComponent();
        }
        public string Mode = "toAdd";
        private void btnSign_Click(object sender, EventArgs e)
        {
            if (txtDate.Text == "" || txtID.Text == "" || txtName.Text == "" || txtNotes.Text == "")
                MessageBox.Show("يرجى ملئ جميع الحقول", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                CLS_List.Add(txtID.Text, txtName.Text, txtDate.Text, txtNotes.Text);
                MessageBox.Show("تمت إضافة الحجز بنجاح", "إضافة حجز", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }
        public string ID;
        private void FRM_Books_Load(object sender, EventArgs e)
        {
            if (Mode == "toShow")
            {
                txtDate.Enabled = false;
                txtID.Enabled = false;
                txtName.Enabled = false;
                txtNotes.Enabled = false;
                btnAdd.Enabled = false;
            }
        }
    }
}
