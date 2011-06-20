using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace RegularExpressionsTesterEngine
{
    public partial class Form1 : Form
    {
        public Form1( )
        {
            InitializeComponent( );
        }

        private void toolStripButton1_Click( object sender, EventArgs e )
        {
            match();
        }

        private void match()
        {

            Regex r = new Regex(textBox2.Text);

            treeView1.Nodes.Clear();

            Match m = r.Match(textBox1.Text);
            while (m.Success)
            {
                

                TreeNode node = treeView1.Nodes.Add(m.Value);

                foreach (Group g in m.Groups)
                {
                    node.Nodes.Add(r.GroupNameFromNumber(g.Index)).Nodes.Add(g.Value);
                }

                m = m.NextMatch();

            }

           textBox3.Text = r.Replace(textBox1.Text, textBox4.Text);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            splitContainer4.Panel2Collapsed = splitContainer3.Panel2Collapsed = !toolStripButton3.Checked;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(toolStripButton2.Checked)
                match();
        }
    }
}
