using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Lab04_Demo
{
    public partial class frmPicture : Form
    {
        Point p = new Point();
       

        public frmPicture()
        {
            InitializeComponent();
        }

        public frmPicture(string name)  
        {
            InitializeComponent();
            this.pbHinh.ImageLocation = name;
            this.toolStripStatusLabel1.Text = name;
        }

        private void frmPicture_Load(object sender, EventArgs e)
        {
            p = this.pbHinh.Location;
        }


        private void reLoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dlg = this.openFileDlg.ShowDialog();
            string title = "";
            if (dlg == DialogResult.OK)
                {
                title = this.Text.Substring(0, this.Text.LastIndexOf('-'))
                + openFileDlg.FileName;
                this.Text = title;
                this.pbHinh.ImageLocation = openFileDlg.FileName;
                }
        }

        public void zoomOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.pbHinh.Width += 50;
            this.pbHinh.Height += 50;
        }

        public void zoomInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.pbHinh.Width -= 50;
            this.pbHinh.Height -= 50;
        }

        private void vScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            this.pbHinh.Location = new Point(p.X, p.Y - e.NewValue);
        }

        private void hScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            this.pbHinh.Location = new Point(p.X - e.NewValue, p.Y);
        }

        public void menuItemEdit_Click(object sender, EventArgs e)
        {
            Process.Start("mspaint", pbHinh.ImageLocation);
        }
    }
}
