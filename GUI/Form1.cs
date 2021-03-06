using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vsite.Csharp.KvadartnaJednadzba.Gui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.functionPanel1.Function = this.resultDisplay1.CalculateY;
            this.resultDisplay1.coeficientsChanged += this.InvalidateAll;
        }

        private void InvalidateAll(object sender, EventArgs e)
        {
            this.functionPanel1.Invalidate();
        }
    }
}
