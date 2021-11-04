
namespace Vsite.Csharp.KvadartnaJednadzba.Gui
{
    partial class ResultDisplay
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownA = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownB = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownC = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.Discriminant = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Roots = new System.Windows.Forms.GroupBox();
            this.TextBoxRoots1 = new System.Windows.Forms.TextBox();
            this.TextBoxRoots2 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownC)).BeginInit();
            this.Roots.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDownB);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numericUpDownA);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(33, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 158);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Coeficients";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "&a:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // numericUpDownA
            // 
            this.numericUpDownA.DecimalPlaces = 1;
            this.numericUpDownA.Location = new System.Drawing.Point(73, 22);
            this.numericUpDownA.Maximum = new decimal(new int[] {
            32000,
            0,
            0,
            0});
            this.numericUpDownA.Minimum = new decimal(new int[] {
            32000,
            0,
            0,
            -2147483648});
            this.numericUpDownA.Name = "numericUpDownA";
            this.numericUpDownA.Size = new System.Drawing.Size(150, 22);
            this.numericUpDownA.TabIndex = 1;
            this.numericUpDownA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numericUpDownB
            // 
            this.numericUpDownB.DecimalPlaces = 1;
            this.numericUpDownB.Location = new System.Drawing.Point(72, 53);
            this.numericUpDownB.Maximum = new decimal(new int[] {
            32000,
            0,
            0,
            0});
            this.numericUpDownB.Minimum = new decimal(new int[] {
            32000,
            0,
            0,
            -2147483648});
            this.numericUpDownB.Name = "numericUpDownB";
            this.numericUpDownB.Size = new System.Drawing.Size(151, 22);
            this.numericUpDownB.TabIndex = 3;
            this.numericUpDownB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "&b:";
            // 
            // numericUpDownC
            // 
            this.numericUpDownC.DecimalPlaces = 1;
            this.numericUpDownC.Location = new System.Drawing.Point(104, 118);
            this.numericUpDownC.Maximum = new decimal(new int[] {
            32000,
            0,
            0,
            0});
            this.numericUpDownC.Minimum = new decimal(new int[] {
            32000,
            0,
            0,
            -2147483648});
            this.numericUpDownC.Name = "numericUpDownC";
            this.numericUpDownC.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numericUpDownC.Size = new System.Drawing.Size(152, 22);
            this.numericUpDownC.TabIndex = 3;
            this.numericUpDownC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "&c:";
            // 
            // Discriminant
            // 
            this.Discriminant.Location = new System.Drawing.Point(193, 221);
            this.Discriminant.Name = "Discriminant";
            this.Discriminant.ReadOnly = true;
            this.Discriminant.Size = new System.Drawing.Size(231, 22);
            this.Discriminant.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(33, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "&Discriminant";
            // 
            // Roots
            // 
            this.Roots.Controls.Add(this.TextBoxRoots2);
            this.Roots.Controls.Add(this.TextBoxRoots1);
            this.Roots.Location = new System.Drawing.Point(33, 275);
            this.Roots.Name = "Roots";
            this.Roots.Size = new System.Drawing.Size(354, 167);
            this.Roots.TabIndex = 7;
            this.Roots.TabStop = false;
            this.Roots.Text = "&Roots";
            // 
            // TextBoxRoots1
            // 
            this.TextBoxRoots1.Location = new System.Drawing.Point(42, 39);
            this.TextBoxRoots1.Name = "TextBoxRoots1";
            this.TextBoxRoots1.ReadOnly = true;
            this.TextBoxRoots1.Size = new System.Drawing.Size(246, 22);
            this.TextBoxRoots1.TabIndex = 6;
            // 
            // TextBoxRoots2
            // 
            this.TextBoxRoots2.Location = new System.Drawing.Point(42, 91);
            this.TextBoxRoots2.Name = "TextBoxRoots2";
            this.TextBoxRoots2.ReadOnly = true;
            this.TextBoxRoots2.Size = new System.Drawing.Size(246, 22);
            this.TextBoxRoots2.TabIndex = 7;
            // 
            // ResultDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Roots);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Discriminant);
            this.Controls.Add(this.numericUpDownC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Name = "ResultDisplay";
            this.Size = new System.Drawing.Size(757, 489);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownC)).EndInit();
            this.Roots.ResumeLayout(false);
            this.Roots.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownA;
        private System.Windows.Forms.NumericUpDown numericUpDownC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Discriminant;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox Roots;
        private System.Windows.Forms.TextBox TextBoxRoots2;
        private System.Windows.Forms.TextBox TextBoxRoots1;
    }
}
