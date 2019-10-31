using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileSystemManager
{
    public partial class Form1 : Form
    {
        List<List<INode>> nodes;
        Directory root;
        public Form1()
        {
            InitializeComponent();
            
            treeView1.BeginUpdate();
            TreeNode node = new TreeNode();
            NameProxy n = new NameProxy(File.FileType.Directory);
            n.SetName("root");
            node.Tag = n;
            node.Text = n.GetName();
            treeView1.Nodes.Add(node);
            treeView1.SelectedNode = node;
            treeView1.EndUpdate();
        }

        private void AddFileButton_Click(object sender, EventArgs e)
        {

            INFO.Text = "";
            treeView1.BeginUpdate();

            TreeNode node = new TreeNode();
            NameProxy n = new NameProxy(File.FileType.File);
            bool state = n.SetName(nodeNameInputBox.Text);
            if (!state)
            {
                INFO.Text = "Incorrect name";
                treeView1.EndUpdate();
                return;
            }
            node.Tag = n;
            node.Text = "_" + n.GetName();
            
            //Add new node to tree
            treeView1.SelectedNode.Nodes.Add(node);

            treeView1.EndUpdate();
            nodeNameInputBox.Text = "";
        }

        private void TreeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            pathTextBox.Text = treeView1.SelectedNode.FullPath;
            if (((NameProxy)treeView1.SelectedNode.Tag).GetNodeType() == File.FileType.File)
            {
                addFileButton.Enabled = false;
                addDirectoryButton.Enabled = false;
            }
            else
            {
                addFileButton.Enabled = true;
                addDirectoryButton.Enabled = true;
            }
                
        }

        private void AddDirectoryButton_Click(object sender, EventArgs e)
        {

            INFO.Text = "";
            treeView1.BeginUpdate();

            TreeNode node = new TreeNode();
            NameProxy n = new NameProxy(File.FileType.Directory);
            bool state = n.SetName(nodeNameInputBox.Text);
            if (!state)
            {
                INFO.Text = "Incorrect name";
                treeView1.EndUpdate();
                return;
            }
            node.Tag = n;
            node.Text = n.GetName();
            //Add new node to tree
            treeView1.SelectedNode.Nodes.Add(node);

            treeView1.EndUpdate();
            nodeNameInputBox.Text = "";
        }

        private void NodeNameInputBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
