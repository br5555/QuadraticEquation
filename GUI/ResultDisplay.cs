using QuadraticEquation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vsite.Csharp.KvadartnaJednadzba.Gui
{
    public partial class ResultDisplay : UserControl
    {
        public event EventHandler coeficientsChanged;
        private QuadraticEquation.QuadraticEquation quadraticEquation;
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public ResultDisplay()
        {
            quadraticEquation = new QuadraticEquation.QuadraticEquation();
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public double CalculateY(double x)
        {
            return this.quadraticEquation.Y(x);
        }

        private void FillResults()
        {
            quadraticEquation.A = (double) this.numericUpDownA.Value;
            log.Info($"A value is {quadraticEquation.A}");
            quadraticEquation.B = (double) this.numericUpDownB.Value;
            log.Info($"B value is {quadraticEquation.B}");
            quadraticEquation.C = (double) this.numericUpDownC.Value;
            log.Info($"C value is {quadraticEquation.C}");

            this.Discriminant.Text = quadraticEquation.Discriminant.ToString();
            log.Info($"Discriminant value is {this.Discriminant.Text}");
            var roots = quadraticEquation.RootsComplex;
            this.TextBoxRoots1.Text = roots[0].ToString();
            this.TextBoxRoots2.Text = roots[1].ToString();
            log.Info($"Root1 value is {roots[0]}");
            log.Info($"Root2 value is {roots[1]}");


        }

        private void EvaluateButton_Click(object sender, EventArgs e)
        {
            FillResults();
        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            FillResults();
            coeficientsChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
