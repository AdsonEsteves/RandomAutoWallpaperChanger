
namespace AutoBGchanger
{
    partial class telaSelecaoBG
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telaSelecaoBG));
            this.buttonRun = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownTimer = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.buttonRun1 = new System.Windows.Forms.Button();
            this.labelImageHub = new System.Windows.Forms.Label();
            this.comboBoxHub = new System.Windows.Forms.ComboBox();
            this.panelHub = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimer)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRun
            // 
            this.buttonRun.Location = new System.Drawing.Point(43, 249);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(75, 23);
            this.buttonRun.TabIndex = 0;
            this.buttonRun.Text = "Run";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.acaoRun);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Timer";
            // 
            // numericUpDownTimer
            // 
            this.numericUpDownTimer.Location = new System.Drawing.Point(55, 207);
            this.numericUpDownTimer.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.numericUpDownTimer.Name = "numericUpDownTimer";
            this.numericUpDownTimer.Size = new System.Drawing.Size(46, 23);
            this.numericUpDownTimer.TabIndex = 11;
            this.numericUpDownTimer.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(107, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Seconds";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // buttonRun1
            // 
            this.buttonRun1.Location = new System.Drawing.Point(174, 249);
            this.buttonRun1.Name = "buttonRun1";
            this.buttonRun1.Size = new System.Drawing.Size(75, 23);
            this.buttonRun1.TabIndex = 13;
            this.buttonRun1.Text = "Run 1 time";
            this.buttonRun1.UseVisualStyleBackColor = true;
            this.buttonRun1.Click += new System.EventHandler(this.acaoRun1);
            // 
            // labelImageHub
            // 
            this.labelImageHub.AutoSize = true;
            this.labelImageHub.Location = new System.Drawing.Point(12, 16);
            this.labelImageHub.Name = "labelImageHub";
            this.labelImageHub.Size = new System.Drawing.Size(63, 15);
            this.labelImageHub.TabIndex = 14;
            this.labelImageHub.Text = "ImageHub";
            // 
            // comboBoxHub
            // 
            this.comboBoxHub.FormattingEnabled = true;
            this.comboBoxHub.Location = new System.Drawing.Point(93, 13);
            this.comboBoxHub.Name = "comboBoxHub";
            this.comboBoxHub.Size = new System.Drawing.Size(199, 23);
            this.comboBoxHub.TabIndex = 15;
            this.comboBoxHub.SelectedIndexChanged += new System.EventHandler(this.acaoChangeHub);
            // 
            // panelHub
            // 
            this.panelHub.Location = new System.Drawing.Point(12, 42);
            this.panelHub.Name = "panelHub";
            this.panelHub.Size = new System.Drawing.Size(280, 160);
            this.panelHub.TabIndex = 16;
            // 
            // telaSelecaoBG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 290);
            this.Controls.Add(this.panelHub);
            this.Controls.Add(this.comboBoxHub);
            this.Controls.Add(this.labelImageHub);
            this.Controls.Add(this.buttonRun1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numericUpDownTimer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonRun);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "telaSelecaoBG";
            this.Text = "AutoBackground";
            this.SizeChanged += new System.EventHandler(this.telaSelecaoBG_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownTimer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button buttonRun1;
        private System.Windows.Forms.Label labelImageHub;
        private System.Windows.Forms.ComboBox comboBoxHub;
        private System.Windows.Forms.Panel panelHub;
        public System.Windows.Forms.Button buttonRun;
    }
}

