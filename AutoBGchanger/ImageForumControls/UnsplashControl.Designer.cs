
namespace AutoBGchanger
{
    partial class UnsplashControl
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
            this.labelUser = new System.Windows.Forms.Label();
            this.labelCollectionID = new System.Windows.Forms.Label();
            this.boxTags = new System.Windows.Forms.TextBox();
            this.labelH = new System.Windows.Forms.Label();
            this.labelW = new System.Windows.Forms.Label();
            this.boxHeight = new System.Windows.Forms.TextBox();
            this.boxWidth = new System.Windows.Forms.TextBox();
            this.labelTags = new System.Windows.Forms.Label();
            this.labelSize = new System.Windows.Forms.Label();
            this.labelPhoto = new System.Windows.Forms.Label();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.textBoxPhoto = new System.Windows.Forms.TextBox();
            this.textBoxCollection = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(16, 57);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(30, 15);
            this.labelUser.TabIndex = 0;
            this.labelUser.Text = "User";
            // 
            // labelCollectionID
            // 
            this.labelCollectionID.AutoSize = true;
            this.labelCollectionID.Location = new System.Drawing.Point(16, 92);
            this.labelCollectionID.Name = "labelCollectionID";
            this.labelCollectionID.Size = new System.Drawing.Size(72, 15);
            this.labelCollectionID.TabIndex = 1;
            this.labelCollectionID.Text = "CollectionID";
            // 
            // boxTags
            // 
            this.boxTags.Location = new System.Drawing.Point(52, 123);
            this.boxTags.Name = "boxTags";
            this.boxTags.Size = new System.Drawing.Size(211, 23);
            this.boxTags.TabIndex = 26;
            // 
            // labelH
            // 
            this.labelH.AutoSize = true;
            this.labelH.Location = new System.Drawing.Point(167, 15);
            this.labelH.Name = "labelH";
            this.labelH.Size = new System.Drawing.Size(16, 15);
            this.labelH.TabIndex = 25;
            this.labelH.Text = "H";
            // 
            // labelW
            // 
            this.labelW.AutoSize = true;
            this.labelW.Location = new System.Drawing.Point(49, 15);
            this.labelW.Name = "labelW";
            this.labelW.Size = new System.Drawing.Size(18, 15);
            this.labelW.TabIndex = 24;
            this.labelW.Text = "W";
            // 
            // boxHeight
            // 
            this.boxHeight.Location = new System.Drawing.Point(189, 12);
            this.boxHeight.Name = "boxHeight";
            this.boxHeight.Size = new System.Drawing.Size(74, 23);
            this.boxHeight.TabIndex = 23;
            this.boxHeight.Text = "1080";
            // 
            // boxWidth
            // 
            this.boxWidth.Location = new System.Drawing.Point(73, 12);
            this.boxWidth.Name = "boxWidth";
            this.boxWidth.Size = new System.Drawing.Size(52, 23);
            this.boxWidth.TabIndex = 22;
            this.boxWidth.Text = "1920";
            // 
            // labelTags
            // 
            this.labelTags.AutoSize = true;
            this.labelTags.Location = new System.Drawing.Point(16, 126);
            this.labelTags.Name = "labelTags";
            this.labelTags.Size = new System.Drawing.Size(30, 15);
            this.labelTags.TabIndex = 21;
            this.labelTags.Text = "Tags";
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Location = new System.Drawing.Point(16, 15);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(27, 15);
            this.labelSize.TabIndex = 20;
            this.labelSize.Text = "Size";
            // 
            // labelPhoto
            // 
            this.labelPhoto.AutoSize = true;
            this.labelPhoto.Location = new System.Drawing.Point(133, 57);
            this.labelPhoto.Name = "labelPhoto";
            this.labelPhoto.Size = new System.Drawing.Size(50, 15);
            this.labelPhoto.TabIndex = 27;
            this.labelPhoto.Text = "PhotoID";
            // 
            // textBoxUser
            // 
            this.textBoxUser.Location = new System.Drawing.Point(53, 54);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(74, 23);
            this.textBoxUser.TabIndex = 28;
            // 
            // textBoxPhoto
            // 
            this.textBoxPhoto.Location = new System.Drawing.Point(189, 54);
            this.textBoxPhoto.Name = "textBoxPhoto";
            this.textBoxPhoto.Size = new System.Drawing.Size(74, 23);
            this.textBoxPhoto.TabIndex = 29;
            // 
            // textBoxCollection
            // 
            this.textBoxCollection.Location = new System.Drawing.Point(94, 89);
            this.textBoxCollection.Name = "textBoxCollection";
            this.textBoxCollection.Size = new System.Drawing.Size(169, 23);
            this.textBoxCollection.TabIndex = 30;
            // 
            // UnsplashControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxCollection);
            this.Controls.Add(this.textBoxPhoto);
            this.Controls.Add(this.textBoxUser);
            this.Controls.Add(this.labelPhoto);
            this.Controls.Add(this.boxTags);
            this.Controls.Add(this.labelH);
            this.Controls.Add(this.labelW);
            this.Controls.Add(this.boxHeight);
            this.Controls.Add(this.boxWidth);
            this.Controls.Add(this.labelTags);
            this.Controls.Add(this.labelSize);
            this.Controls.Add(this.labelCollectionID);
            this.Controls.Add(this.labelUser);
            this.Name = "UnsplashControl";
            this.Size = new System.Drawing.Size(280, 160);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelCollectionID;
        private System.Windows.Forms.TextBox boxTags;
        private System.Windows.Forms.Label labelH;
        private System.Windows.Forms.Label labelW;
        private System.Windows.Forms.TextBox boxHeight;
        private System.Windows.Forms.TextBox boxWidth;
        private System.Windows.Forms.Label labelTags;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.Label labelPhoto;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.TextBox textBoxPhoto;
        private System.Windows.Forms.TextBox textBoxCollection;
    }
}
