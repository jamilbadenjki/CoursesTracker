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
    public partial class FRM_Main : Form
    {
        public FRM_Main()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FRM_AddBook fRM_Books = new FRM_AddBook();
            FRM_BackGround fRM_BackGround = new FRM_BackGround();
            fRM_BackGround.Show();
            fRM_Books.ShowDialog();
            fRM_BackGround.Close();

        }

        private void FRM_Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void btnBook_Click(object sender, EventArgs e)
        {
            FRM_AddBook fRM_AddBook = new FRM_AddBook();
            FRM_BackGround fRM = new FRM_BackGround();
            fRM.Show();
            fRM_AddBook.FRM_Main = this;
            fRM_AddBook.ShowDialog();
            fRM.Close();
        }

        private void btnShowBooks_Click(object sender, EventArgs e)
        {
            FRM_BackGround fRM = new FRM_BackGround();
            fRM.Show();
            FRM_Books fRM_Books = new FRM_Books();
            fRM_Books.ShowDialog();
            fRM.Close();
        }

        private void FRM_Main_Load(object sender, EventArgs e)
        {
        }
    }
}
