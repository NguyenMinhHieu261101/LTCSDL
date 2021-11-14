using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baitap2_Lab04
{
    public partial class frmExplorer : Form
    {
        public frmExplorer()
        {
            InitializeComponent();
        }

        private string ImageKeyDriver(DriveInfo drive)
        {
            string type = "";

            switch (drive.DriveType)
            {
                case DriveType.Removable:
                    type = "Removable";
                    break;
                case DriveType.Fixed:
                    type = "HDD";
                    break;
                case DriveType.Network:
                    type = "Network";
                    break;
                case DriveType.CDRom:
                    type = "CD";
                    break;
                default:
                    type = "HDD";
                    break;
            }

            return type;
        }

        private void LoadDrive(TreeNode tn)
        {
            TreeNode tnode = new TreeNode();

            foreach (DriveInfo dr in DriveInfo.GetDrives())
            {
                tnode = new TreeNode();
                tnode.Text = dr.Name;
                tnode.Tag = dr.ToString();
                tnode.ImageKey = ImageKeyDriver(dr);
                tnode.ImageKey = ImageKeyDriver(dr);
                tn.Nodes.Add(tnode);
            }
        }

        private void InsertFolder(TreeNode tnParent)
        {
            try
            {
                DirectoryInfo dir = new DirectoryInfo(tnParent.Tag.ToString());
                foreach (DirectoryInfo dircur in dir.GetDirectories())
                {
                    TreeNode tnChild = new TreeNode(dircur.Name, 6, 6);
                    tnChild.Tag = dircur.FullName;
                    tnParent.Nodes.Add(tnChild);
                }
            }
            catch
            { }
        }

        private void InserFile(TreeNode tnParent)
        {
            try
            {
                DirectoryInfo dir = new DirectoryInfo(tnParent.Tag.ToString());
                this.listViewFile.Items.Clear();
                foreach (FileInfo filecur in dir.GetFiles())
                {
                    ListViewItem lvitem = new ListViewItem(filecur.Name);
                    lvitem.SubItems.Add(filecur.LastWriteTime.ToShortDateString());
                    lvitem.SubItems.Add(filecur.Extension);
                    lvitem.SubItems.Add((filecur.Length / 1024).ToString());
                    this.listViewFile.Items.Add(lvitem);
                }
                this.toolStripStatusLabel1.Text = "Tổng số Files: " +
                this.listViewFile.Items.Count;
            }
            catch { }
        }

        private void InsertChildParent(TreeNode tnParent)
        {
            if (tnParent == null) return;

            if (tnParent.Level == 0)
            {
                TreeNode tnMyDocuments = new TreeNode("My Documents", 2, 2);
                tnMyDocuments.SelectedImageKey = "My Documents";
                tnMyDocuments.Tag = SpecialDirectories.MyDocuments;
                TreeNode tnMyComputer = new TreeNode("My Computer", 1, 1);
                tnMyComputer.Tag = "My Computer";
                tnparent.Nodes.Insert(0, tnMyDocuments);
                tnparent.Nodes.Insert(1, tnMyComputer);
            }
            else
            {
                if (tnParent.Nodes.Count == 0)
                {
                    if (tnParent.Text == "My Computer")
                    {
                        LoadDrive(tnParent);
                        return;
                    }
                    InsertFolder(tnParent);
                }
                InsertFileTreeView(tnParent);
            }
        }

        private void frmExplorer_Load(object sender, EventArgs e)
        {
            TreeNode tnode = new TreeNode();
            tnode.Text = "Desktop";
            tnode.Tag = SpecialDirectories.Desktop;
            tnode.ImageKey = "Desktop";
            tnode.SelectedImageKey = "Desktop";
            int root = this.treeViewFolder.Nodes.Add(tnode);
            string name = Application.StartupPath;
            name = name.Substring(0, name.LastIndexOf('\\'));
            name = name.Substring(0, name.LastIndexOf('\\'));
        }

        private void treeViewFolder_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode tnParent = e.Node;
            InsertChildParent(tnParent);
        }
    }
}

