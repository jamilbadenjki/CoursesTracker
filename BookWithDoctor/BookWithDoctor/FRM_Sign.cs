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
    public partial class FRM_Sign : Form
    {
        public FRM_Sign()
        {
            InitializeComponent();
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            if(txtName.Text == "" || txtPassword.Text == "")
                MessageBox.Show("يرجى ملئ جميع الحقول","خطأ",MessageBoxButtons.OK,MessageBoxIcon.Error);
            else
            {
                MessageBox.Show("تم تسجيل الدخول بنجاح", "تسجيل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Hide();
                FRM_Main fRM_Main = new FRM_Main();
                fRM_Main.Show();
            }

        }
    }
}
