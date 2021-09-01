
namespace AutoBGchanger
{
    partial class KonaChanControl
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.boxTags = new System.Windows.Forms.TextBox();
            this.comboBoxRating = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.boxHeight = new System.Windows.Forms.TextBox();
            this.boxWidth = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // boxTags
            // 
            this.boxTags.Location = new System.Drawing.Point(69, 116);
            this.boxTags.Name = "boxTags";
            this.boxTags.Size = new System.Drawing.Size(198, 23);
            this.boxTags.TabIndex = 19;
            // 
            // comboBoxRating
            // 
            this.comboBoxRating.FormattingEnabled = true;
            this.comboBoxRating.Items.AddRange(new object[] {
            "Any",
            "Safe",
            "Safe-Questionable",
            "Questionable",
            "Questionable-Explicit",
            "Explicit"});
            this.comboBoxRating.Location = new System.Drawing.Point(69, 68);
            this.comboBoxRating.Name = "comboBoxRating";
            this.comboBoxRating.Size = new System.Drawing.Size(121, 23);
            this.comboBoxRating.TabIndex = 18;
            this.comboBoxRating.Text = "Safe";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(161, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "H";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "W";
            // 
            // boxHeight
            // 
            this.boxHeight.Location = new System.Drawing.Point(183, 18);
            this.boxHeight.Name = "boxHeight";
            this.boxHeight.Size = new System.Drawing.Size(84, 23);
            this.boxHeight.TabIndex = 15;
            this.boxHeight.Text = "1080";
            // 
            // boxWidth
            // 
            this.boxWidth.Location = new System.Drawing.Point(69, 18);
            this.boxWidth.Name = "boxWidth";
            this.boxWidth.Size = new System.Drawing.Size(84, 23);
            this.boxWidth.TabIndex = 14;
            this.boxWidth.Text = "1920";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Tags";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Rating";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Size";
            // 
            // KonaChanControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.boxTags);
            this.Controls.Add(this.comboBoxRating);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.boxHeight);
            this.Controls.Add(this.boxWidth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "KonaChanControl";
            this.Size = new System.Drawing.Size(280, 160);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox boxTags;
        private System.Windows.Forms.ComboBox comboBoxRating;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox boxHeight;
        private System.Windows.Forms.TextBox boxWidth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
