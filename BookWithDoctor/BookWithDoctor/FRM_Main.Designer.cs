namespace BookWithDoctor
{
    partial class FRM_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBook = new System.Windows.Forms.Button();
            this.btnShowBooks = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBook
            // 
            this.btnBook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBook.FlatAppearance.BorderSize = 2;
            this.btnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBook.Font = new System.Drawing.Font("Dubai", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBook.ForeColor = System.Drawing.Color.Blue;
            this.btnBook.Location = new System.Drawing.Point(882, 286);
            this.btnBook.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(210, 53);
            this.btnBook.TabIndex = 15;
            this.btnBook.Text = "إضافة حجز جديد";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // btnShowBooks
            // 
            this.btnShowBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowBooks.FlatAppearance.BorderSize = 2;
            this.btnShowBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowBooks.Font = new System.Drawing.Font("Dubai", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowBooks.ForeColor = System.Drawing.Color.Blue;
            this.btnShowBooks.Location = new System.Drawing.Point(534, 601);
            this.btnShowBooks.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnShowBooks.Name = "btnShowBooks";
            this.btnShowBooks.Size = new System.Drawing.Size(210, 53);
            this.btnShowBooks.TabIndex = 16;
            this.btnShowBooks.Text = "عرض الحجوزات";
            this.btnShowBooks.UseVisualStyleBackColor = true;
            this.btnShowBooks.Click += new System.EventHandler(this.btnShowBooks_Click);
            // 
            // FRM_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BookWithDoctor.Properties.Resources.عيادة;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1349, 734);
            this.Controls.Add(this.btnShowBooks);
            this.Controls.Add(this.btnBook);
            this.DoubleBuffered = true;
            this.Name = "FRM_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الرئيسية";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FRM_Main_FormClosed);
            this.Load += new System.EventHandler(this.FRM_Main_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Button btnShowBooks;
    }
}