using System.Resources;
namespace Tyuiu.GalimovAA.Sprint7.Project.V7
{
    partial class FormChart_GAA
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
            buttonClose_GAA = new Button();
            panelChart_GAA = new Panel();
            SuspendLayout();
            // 
            // buttonClose_GAA
            // 
            buttonClose_GAA.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonClose_GAA.Location = new Point(617, 457);
            buttonClose_GAA.Name = "buttonClose_GAA";
            buttonClose_GAA.Size = new Size(90, 30);
            buttonClose_GAA.TabIndex = 1;
            buttonClose_GAA.Text = "Закрыть";
            buttonClose_GAA.Click += buttonClose_GAA_Click;
            // 
            // panelChart_GAA
            // 
            panelChart_GAA.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelChart_GAA.BackColor = Color.White;
            panelChart_GAA.BorderStyle = BorderStyle.FixedSingle;
            panelChart_GAA.Location = new Point(12, 12);
            panelChart_GAA.Name = "panelChart_GAA";
            panelChart_GAA.Size = new Size(697, 439);
            panelChart_GAA.TabIndex = 2;
            panelChart_GAA.Resize += panelChart_GAA_Resize;
            // 
            // FormChart_GAA
            // 
            ClientSize = new Size(721, 498);
            Controls.Add(panelChart_GAA);
            Controls.Add(buttonClose_GAA);
            MinimumSize = new Size(640, 500);
            Name = "FormChart_GAA";
            Text = "Статистика - Галимов А.А.";
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonClose_GAA;
        private System.Windows.Forms.Panel panelChart_GAA;
    }
}