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

namespace EventStudio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void createProjectMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result= saveProject.ShowDialog();
            if (result==DialogResult.OK)
            {
               
                FileInfo fileinfo=new FileInfo(saveProject.FileName);
                string projName = fileinfo.Name.Remove(fileinfo.Name.Length- fileinfo.Extension.Length);
                TreeNode projNode = new TreeNode(projName);
                
                treeViewProject.Nodes.Add(projNode);
                int ind = treeViewProject.Nodes.IndexOf(projNode);
                treeViewProject.Nodes[ind].Nodes.Add("Main");
            }
            
        }

        
    }
}
