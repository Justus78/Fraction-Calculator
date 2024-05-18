namespace FractionCalculator
{
    partial class frmFractionCalculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNumeratorX = new System.Windows.Forms.TextBox();
            this.txtNumeratorY = new System.Windows.Forms.TextBox();
            this.txtDenominatorX = new System.Windows.Forms.TextBox();
            this.txtDenominatorY = new System.Windows.Forms.TextBox();
            this.lblDiv1 = new System.Windows.Forms.Label();
            this.lblDiv2 = new System.Windows.Forms.Label();
            this.cmbSelection = new System.Windows.Forms.ComboBox();
            this.lblEquals = new System.Windows.Forms.Label();
            this.lblResults = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tstDecimal = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNumeratorX
            // 
            this.txtNumeratorX.Location = new System.Drawing.Point(13, 25);
            this.txtNumeratorX.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumeratorX.Name = "txtNumeratorX";
            this.txtNumeratorX.Size = new System.Drawing.Size(51, 34);
            this.txtNumeratorX.TabIndex = 0;
            // 
            // txtNumeratorY
            // 
            this.txtNumeratorY.Location = new System.Drawing.Point(126, 25);
            this.txtNumeratorY.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumeratorY.Name = "txtNumeratorY";
            this.txtNumeratorY.Size = new System.Drawing.Size(51, 34);
            this.txtNumeratorY.TabIndex = 1;
            // 
            // txtDenominatorX
            // 
            this.txtDenominatorX.Location = new System.Drawing.Point(14, 95);
            this.txtDenominatorX.Margin = new System.Windows.Forms.Padding(4);
            this.txtDenominatorX.Name = "txtDenominatorX";
            this.txtDenominatorX.Size = new System.Drawing.Size(51, 34);
            this.txtDenominatorX.TabIndex = 2;
            // 
            // txtDenominatorY
            // 
            this.txtDenominatorY.Location = new System.Drawing.Point(127, 95);
            this.txtDenominatorY.Margin = new System.Windows.Forms.Padding(4);
            this.txtDenominatorY.Name = "txtDenominatorY";
            this.txtDenominatorY.Size = new System.Drawing.Size(51, 34);
            this.txtDenominatorY.TabIndex = 3;
            // 
            // lblDiv1
            // 
            this.lblDiv1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDiv1.Location = new System.Drawing.Point(14, 80);
            this.lblDiv1.Name = "lblDiv1";
            this.lblDiv1.Size = new System.Drawing.Size(50, 2);
            this.lblDiv1.TabIndex = 4;
            // 
            // lblDiv2
            // 
            this.lblDiv2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDiv2.Location = new System.Drawing.Point(127, 80);
            this.lblDiv2.Name = "lblDiv2";
            this.lblDiv2.Size = new System.Drawing.Size(50, 2);
            this.lblDiv2.TabIndex = 5;
            // 
            // cmbSelection
            // 
            this.cmbSelection.FormattingEnabled = true;
            this.cmbSelection.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.cmbSelection.Location = new System.Drawing.Point(72, 59);
            this.cmbSelection.Name = "cmbSelection";
            this.cmbSelection.Size = new System.Drawing.Size(47, 36);
            this.cmbSelection.TabIndex = 6;
            // 
            // lblEquals
            // 
            this.lblEquals.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEquals.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblEquals.Location = new System.Drawing.Point(185, 13);
            this.lblEquals.Name = "lblEquals";
            this.lblEquals.Size = new System.Drawing.Size(57, 82);
            this.lblEquals.TabIndex = 7;
            this.lblEquals.Text = "=";
            this.lblEquals.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblResults
            // 
            this.lblResults.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResults.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblResults.Location = new System.Drawing.Point(248, 31);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(247, 98);
            this.lblResults.TabIndex = 8;
            this.lblResults.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(210, 158);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(132, 45);
            this.btnCalculate.TabIndex = 9;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(363, 158);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(132, 45);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstDecimal});
            this.statusStrip1.Location = new System.Drawing.Point(0, 219);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(525, 24);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tstDecimal
            // 
            this.tstDecimal.AutoSize = false;
            this.tstDecimal.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedOuter;
            this.tstDecimal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tstDecimal.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tstDecimal.Name = "tstDecimal";
            this.tstDecimal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tstDecimal.Size = new System.Drawing.Size(500, 18);
            // 
            // frmFractionCalculator
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 243);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.lblEquals);
            this.Controls.Add(this.cmbSelection);
            this.Controls.Add(this.lblDiv2);
            this.Controls.Add(this.lblDiv1);
            this.Controls.Add(this.txtDenominatorY);
            this.Controls.Add(this.txtDenominatorX);
            this.Controls.Add(this.txtNumeratorY);
            this.Controls.Add(this.txtNumeratorX);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmFractionCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fraction Calculator";
            this.Load += new System.EventHandler(this.frmFractionCalculator_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtNumeratorX;
        private TextBox txtNumeratorY;
        private TextBox txtDenominatorX;
        private TextBox txtDenominatorY;
        private Label lblDiv1;
        private Label lblDiv2;
        private ComboBox cmbSelection;
        private Label lblEquals;
        private Label lblResults;
        private Button btnCalculate;
        private Button btnClear;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel tstDecimal;
    }
}