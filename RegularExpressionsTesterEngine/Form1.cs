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
            Match m = r.Match(textBox1.Text);
        }
    }
}
