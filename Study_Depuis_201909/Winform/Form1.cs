using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 2019.10.15
        /// <summary>
        /// Tag 예제 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_TagEx_Click(object sender, EventArgs e)
        {
            pn_ExArea.Controls.Add(new TagExUC());
        }
    }
}
