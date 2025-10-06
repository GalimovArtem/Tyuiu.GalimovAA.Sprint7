using System.Resources;
namespace Tyuiu.GalimovAA.Sprint7.Project.V7
{
    partial class FormAbout_GAA
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            labelTitle_GAA = new Label();
            labelVersion_GAA = new Label();
            labelAuthor_GAA = new Label();
            labelDescription_GAA = new Label();
            buttonOk_GAA = new Button();
            pictureBoxIcon_GAA = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIcon_GAA).BeginInit();
            SuspendLayout();
            // 
            // labelTitle_GAA
            // 
            labelTitle_GAA.AutoSize = true;
            labelTitle_GAA.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            labelTitle_GAA.Location = new Point(159, 9);
            labelTitle_GAA.Name = "labelTitle_GAA";
            labelTitle_GAA.Size = new Size(179, 24);
            labelTitle_GAA.TabIndex = 0;
            labelTitle_GAA.Text = "Домоуправление";
            // 
            // labelVersion_GAA
            // 
            labelVersion_GAA.AutoSize = true;
            labelVersion_GAA.Location = new Point(159, 56);
            labelVersion_GAA.Name = "labelVersion_GAA";
            labelVersion_GAA.Size = new Size(49, 15);
            labelVersion_GAA.TabIndex = 1;
            labelVersion_GAA.Text = "Версия:";
            // 
            // labelAuthor_GAA
            // 
            labelAuthor_GAA.AutoSize = true;
            labelAuthor_GAA.Location = new Point(159, 80);
            labelAuthor_GAA.Name = "labelAuthor_GAA";
            labelAuthor_GAA.Size = new Size(43, 15);
            labelAuthor_GAA.TabIndex = 2;
            labelAuthor_GAA.Text = "Автор:";
            labelAuthor_GAA.Click += labelAuthor_GAA_Click;
            // 
            // labelDescription_GAA
            // 
            labelDescription_GAA.Location = new Point(159, 112);
            labelDescription_GAA.Name = "labelDescription_GAA";
            labelDescription_GAA.Size = new Size(326, 95);
            labelDescription_GAA.TabIndex = 3;
            labelDescription_GAA.Text = "Приложение для управления данными о квартирах...";
            // 
            // buttonOk_GAA
            // 
            buttonOk_GAA.Location = new Point(443, 177);
            buttonOk_GAA.Name = "buttonOk_GAA";
            buttonOk_GAA.Size = new Size(80, 30);
            buttonOk_GAA.TabIndex = 4;
            buttonOk_GAA.Text = "OK";
            buttonOk_GAA.Click += buttonOk_GAA_Click;
            // 
            // pictureBoxIcon_GAA
            // 
            pictureBoxIcon_GAA.Image = Properties.Resources.author_photo;
            pictureBoxIcon_GAA.Location = new Point(-6, 12);
            pictureBoxIcon_GAA.Name = "pictureBoxIcon_GAA";
            pictureBoxIcon_GAA.Size = new Size(159, 160);
            pictureBoxIcon_GAA.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxIcon_GAA.TabIndex = 5;
            pictureBoxIcon_GAA.TabStop = false;
            // 
            // FormAbout_GAA
            // 
            ClientSize = new Size(535, 225);
            Controls.Add(pictureBoxIcon_GAA);
            Controls.Add(buttonOk_GAA);
            Controls.Add(labelDescription_GAA);
            Controls.Add(labelAuthor_GAA);
            Controls.Add(labelVersion_GAA);
            Controls.Add(labelTitle_GAA);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout_GAA";
            Text = "О программе - Галимов А.А. ПКТб-24-1";
            ((System.ComponentModel.ISupportInitialize)pictureBoxIcon_GAA).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle_GAA;
        private System.Windows.Forms.Label labelVersion_GAA;
        private System.Windows.Forms.Label labelAuthor_GAA;
        private System.Windows.Forms.Label labelDescription_GAA;
        private System.Windows.Forms.Button buttonOk_GAA;
        private System.Windows.Forms.PictureBox pictureBoxIcon_GAA;
    }
}