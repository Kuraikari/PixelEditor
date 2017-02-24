using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pixeleditor_core
{
    public partial class ColorList : Component
    {
        public ColorList()
        {
            InitializeComponent();
        }

        public ColorList(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
