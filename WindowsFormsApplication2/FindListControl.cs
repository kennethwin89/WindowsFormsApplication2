using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerDatabaseApplication
{
    public partial class FindListControl : UserControl
    {
        public FindListControl()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public ListView SearchList
        {
            get
            {
                return this.list;
            }
            set
            {
                this.list = value;
            }
        }

    }
}
