using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pixeleditor_core
{
    public partial class frmPixelEditor : Form
    {
        

        ToolBoxForm tbf = new ToolBoxForm();
        Paper paper = new Paper();
        Bitmap picture;

        public frmPixelEditor()
        {
            InitializeComponent();
        }

        private void frmPixelEditor_Load(object sender, EventArgs e)
        {
            tbf.Activate();
            tbf.Visible = true;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Save pixeled Picture";
            saveFileDialog1.InitialDirectory = "C:/user/public/pictures";
            saveFileDialog1.AddExtension = true;
            saveFileDialog1.ShowDialog();
        }
    }
}
