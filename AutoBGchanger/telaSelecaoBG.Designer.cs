
using MaterialSkin.Controls;

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
            this.buttonRun = new MaterialSkin.Controls.MaterialFlatButton();
            this.label4 = new MaterialSkin.Controls.MaterialLabel();
            this.numericUpDownTimer = new System.Windows.Forms.NumericUpDown();
            this.label7 = new MaterialSkin.Controls.MaterialLabel();
            this.AutoBackground = new System.Windows.Forms.NotifyIcon(this.components);
            this.buttonRun1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.labelImageHub = new MaterialSkin.Controls.MaterialLabel();
            this.comboBoxHub = new System.Windows.Forms.ComboBox();
            this.panelHub = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimer)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRun
            // 
            this.buttonRun.AutoSize = true;
            this.buttonRun.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonRun.Depth = 0;
            this.buttonRun.Icon = null;
            this.buttonRun.Location = new System.Drawing.Point(60, 302);
            this.buttonRun.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonRun.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Primary = false;
            this.buttonRun.Size = new System.Drawing.Size(48, 36);
            this.buttonRun.TabIndex = 0;
            this.buttonRun.Text = "Run";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.acaoRun);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Depth = 0;
            this.label4.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(29, 272);
            this.label4.MouseState = MaterialSkin.MouseState.HOVER;
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Timer";
            // 
            // numericUpDownTimer
            // 
            this.numericUpDownTimer.Location = new System.Drawing.Point(84, 270);
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
            this.label7.Depth = 0;
            this.label7.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(137, 272);
            this.label7.MouseState = MaterialSkin.MouseState.HOVER;
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "Seconds";
            // 
            // AutoBackground
            // 
            this.AutoBackground.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.AutoBackground.Icon = ((System.Drawing.Icon)(resources.GetObject("AutoBackground.Icon")));
            this.AutoBackground.Text = "AutoBackground";
            this.AutoBackground.Visible = true;
            this.AutoBackground.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // buttonRun1
            // 
            this.buttonRun1.AutoSize = true;
            this.buttonRun1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonRun1.Depth = 0;
            this.buttonRun1.Icon = null;
            this.buttonRun1.Location = new System.Drawing.Point(191, 302);
            this.buttonRun1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonRun1.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonRun1.Name = "buttonRun1";
            this.buttonRun1.Primary = false;
            this.buttonRun1.Size = new System.Drawing.Size(95, 36);
            this.buttonRun1.TabIndex = 13;
            this.buttonRun1.Text = "Run 1 time";
            this.buttonRun1.UseVisualStyleBackColor = true;
            this.buttonRun1.Click += new System.EventHandler(this.acaoRun1);
            // 
            // labelImageHub
            // 
            this.labelImageHub.AutoSize = true;
            this.labelImageHub.Depth = 0;
            this.labelImageHub.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelImageHub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelImageHub.Location = new System.Drawing.Point(29, 79);
            this.labelImageHub.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelImageHub.Name = "labelImageHub";
            this.labelImageHub.Size = new System.Drawing.Size(77, 19);
            this.labelImageHub.TabIndex = 14;
            this.labelImageHub.Text = "ImageHub";
            // 
            // comboBoxHub
            // 
            this.comboBoxHub.FormattingEnabled = true;
            this.comboBoxHub.Location = new System.Drawing.Point(110, 76);
            this.comboBoxHub.Name = "comboBoxHub";
            this.comboBoxHub.Size = new System.Drawing.Size(199, 23);
            this.comboBoxHub.TabIndex = 15;
            this.comboBoxHub.SelectedIndexChanged += new System.EventHandler(this.acaoChangeHub);
            // 
            // panelHub
            // 
            this.panelHub.Location = new System.Drawing.Point(29, 105);
            this.panelHub.Name = "panelHub";
            this.panelHub.Size = new System.Drawing.Size(280, 160);
            this.panelHub.TabIndex = 16;
            // 
            // telaSelecaoBG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 347);
            this.Controls.Add(this.panelHub);
            this.Controls.Add(this.comboBoxHub);
            this.Controls.Add(this.labelImageHub);
            this.Controls.Add(this.buttonRun1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numericUpDownTimer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonRun);
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
        private System.Windows.Forms.NumericUpDown numericUpDownTimer;
        private System.Windows.Forms.NotifyIcon AutoBackground;
        private System.Windows.Forms.ComboBox comboBoxHub;
        private System.Windows.Forms.Panel panelHub;
        private MaterialLabel label4;
        private MaterialFlatButton buttonRun1;
        private MaterialLabel labelImageHub;
        public MaterialFlatButton buttonRun;
        private MaterialLabel label7;
    }
}

