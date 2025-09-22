using System.Resources;
using Tyuiu.GalimovAA.Sprint7.Project.V7.Properties;

namespace Tyuiu.GalimovAA.Sprint7.Project.V7
{
    partial class FormMain_GAA
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
            dataGridViewApartments_GAA = new DataGridView();
            panelControls_GAA = new Panel();
            buttonReset_GAA = new Button();
            buttonHelp_GAA = new Button();
            buttonAbout_GAA = new Button();
            buttonChart_GAA = new Button();
            buttonSort_GAA = new Button();
            comboBoxSort_GAA = new ComboBox();
            buttonFilterDebt_GAA = new Button();
            buttonSearch_GAA = new Button();
            textBoxSearch_GAA = new TextBox();
            buttonDelete_GAA = new Button();
            buttonEdit_GAA = new Button();
            buttonAdd_GAA = new Button();
            panelStats_GAA = new Panel();
            labelResidents_GAA = new Label();
            labelDebtCount_GAA = new Label();
            labelAverageArea_GAA = new Label();
            labelTotalArea_GAA = new Label();
            labelTotalApartments_GAA = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewApartments_GAA).BeginInit();
            panelControls_GAA.SuspendLayout();
            panelStats_GAA.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewApartments_GAA
            // 
            dataGridViewApartments_GAA.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewApartments_GAA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewApartments_GAA.Location = new Point(12, 120);
            dataGridViewApartments_GAA.Name = "dataGridViewApartments_GAA";
            dataGridViewApartments_GAA.Size = new Size(960, 400);
            dataGridViewApartments_GAA.TabIndex = 0;
            // 
            // panelControls_GAA
            // 
            panelControls_GAA.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelControls_GAA.BackColor = SystemColors.ControlLight;
            panelControls_GAA.Controls.Add(buttonReset_GAA);
            panelControls_GAA.Controls.Add(buttonHelp_GAA);
            panelControls_GAA.Controls.Add(buttonAbout_GAA);
            panelControls_GAA.Controls.Add(buttonChart_GAA);
            panelControls_GAA.Controls.Add(buttonSort_GAA);
            panelControls_GAA.Controls.Add(comboBoxSort_GAA);
            panelControls_GAA.Controls.Add(buttonFilterDebt_GAA);
            panelControls_GAA.Controls.Add(buttonSearch_GAA);
            panelControls_GAA.Controls.Add(textBoxSearch_GAA);
            panelControls_GAA.Controls.Add(buttonDelete_GAA);
            panelControls_GAA.Controls.Add(buttonEdit_GAA);
            panelControls_GAA.Controls.Add(buttonAdd_GAA);
            panelControls_GAA.Location = new Point(12, 12);
            panelControls_GAA.Name = "panelControls_GAA";
            panelControls_GAA.Size = new Size(960, 60);
            panelControls_GAA.TabIndex = 1;
            // 
            // buttonReset_GAA
            // 
            buttonReset_GAA.Image = Resources.icons8_refresh_24;
            buttonReset_GAA.Location = new Point(450, 15);
            buttonReset_GAA.Name = "buttonReset_GAA";
            buttonReset_GAA.Size = new Size(40, 30);
            buttonReset_GAA.TabIndex = 11;
            buttonReset_GAA.UseVisualStyleBackColor = true;
            buttonReset_GAA.Click += buttonReset_GAA_Click;
            // 
            // buttonHelp_GAA
            // 
            buttonHelp_GAA.Image = Resources.icons8_message_24;
            buttonHelp_GAA.Location = new Point(900, 15);
            buttonHelp_GAA.Name = "buttonHelp_GAA";
            buttonHelp_GAA.Size = new Size(40, 30);
            buttonHelp_GAA.TabIndex = 10;
            buttonHelp_GAA.UseVisualStyleBackColor = true;
            buttonHelp_GAA.Click += buttonHelp_GAA_Click;
            // 
            // buttonAbout_GAA
            // 
            buttonAbout_GAA.Image = Resources.icons8_info_24;
            buttonAbout_GAA.Location = new Point(850, 15);
            buttonAbout_GAA.Name = "buttonAbout_GAA";
            buttonAbout_GAA.Size = new Size(40, 30);
            buttonAbout_GAA.TabIndex = 9;
            buttonAbout_GAA.UseVisualStyleBackColor = true;
            buttonAbout_GAA.Click += buttonAbout_GAA_Click;
            // 
            // buttonChart_GAA
            // 
            buttonChart_GAA.Image = Resources.icons8_graph_24;
            buttonChart_GAA.Location = new Point(800, 15);
            buttonChart_GAA.Name = "buttonChart_GAA";
            buttonChart_GAA.Size = new Size(40, 30);
            buttonChart_GAA.TabIndex = 8;
            buttonChart_GAA.UseVisualStyleBackColor = true;
            buttonChart_GAA.Click += buttonChart_GAA_Click;
            // 
            // buttonSort_GAA
            // 
            buttonSort_GAA.Image = Resources.icons8_chart_bar_24;
            buttonSort_GAA.Location = new Point(700, 15);
            buttonSort_GAA.Name = "buttonSort_GAA";
            buttonSort_GAA.Size = new Size(40, 30);
            buttonSort_GAA.TabIndex = 7;
            buttonSort_GAA.UseVisualStyleBackColor = true;
            buttonSort_GAA.Click += buttonSort_GAA_Click;
            // 
            // comboBoxSort_GAA
            // 
            comboBoxSort_GAA.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSort_GAA.FormattingEnabled = true;
            comboBoxSort_GAA.Items.AddRange(new object[] { "Квартира", "Площадь", "Квартиросъёмщик" });
            comboBoxSort_GAA.Location = new Point(550, 20);
            comboBoxSort_GAA.Name = "comboBoxSort_GAA";
            comboBoxSort_GAA.Size = new Size(140, 23);
            comboBoxSort_GAA.TabIndex = 6;
            // 
            // buttonFilterDebt_GAA
            // 
            buttonFilterDebt_GAA.Image = Resources.icons8_filter_24;
            buttonFilterDebt_GAA.Location = new Point(500, 15);
            buttonFilterDebt_GAA.Name = "buttonFilterDebt_GAA";
            buttonFilterDebt_GAA.Size = new Size(40, 30);
            buttonFilterDebt_GAA.TabIndex = 5;
            buttonFilterDebt_GAA.UseVisualStyleBackColor = true;
            buttonFilterDebt_GAA.Click += buttonFilterDebt_GAA_Click;
            // 
            // buttonSearch_GAA
            // 
            buttonSearch_GAA.Image = Resources.icons8_search_24;
            buttonSearch_GAA.Location = new Point(400, 15);
            buttonSearch_GAA.Name = "buttonSearch_GAA";
            buttonSearch_GAA.Size = new Size(40, 30);
            buttonSearch_GAA.TabIndex = 4;
            buttonSearch_GAA.UseVisualStyleBackColor = true;
            buttonSearch_GAA.Click += buttonSearch_GAA_Click;
            // 
            // textBoxSearch_GAA
            // 
            textBoxSearch_GAA.Location = new Point(250, 20);
            textBoxSearch_GAA.Name = "textBoxSearch_GAA";
            textBoxSearch_GAA.Size = new Size(140, 23);
            textBoxSearch_GAA.TabIndex = 3;
            // 
            // buttonDelete_GAA
            // 
            buttonDelete_GAA.Image = Resources.icons8_trash_24;
            buttonDelete_GAA.Location = new Point(200, 15);
            buttonDelete_GAA.Name = "buttonDelete_GAA";
            buttonDelete_GAA.Size = new Size(40, 30);
            buttonDelete_GAA.TabIndex = 2;
            buttonDelete_GAA.UseVisualStyleBackColor = true;
            buttonDelete_GAA.Click += buttonDelete_GAA_Click;
            // 
            // buttonEdit_GAA
            // 
            buttonEdit_GAA.Image = Resources.edit;
            buttonEdit_GAA.Location = new Point(100, 15);
            buttonEdit_GAA.Name = "buttonEdit_GAA";
            buttonEdit_GAA.Size = new Size(40, 30);
            buttonEdit_GAA.TabIndex = 1;
            buttonEdit_GAA.UseVisualStyleBackColor = true;
            buttonEdit_GAA.Click += buttonEdit_GAA_Click;
            // 
            // buttonAdd_GAA
            // 
            buttonAdd_GAA.Image = Resources.icons8_plus_math_24;
            buttonAdd_GAA.Location = new Point(15, 15);
            buttonAdd_GAA.Name = "buttonAdd_GAA";
            buttonAdd_GAA.Size = new Size(40, 30);
            buttonAdd_GAA.TabIndex = 0;
            buttonAdd_GAA.UseVisualStyleBackColor = true;
            buttonAdd_GAA.Click += buttonAdd_GAA_Click;
            // 
            // panelStats_GAA
            // 
            panelStats_GAA.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelStats_GAA.BackColor = SystemColors.Info;
            panelStats_GAA.Controls.Add(labelResidents_GAA);
            panelStats_GAA.Controls.Add(labelDebtCount_GAA);
            panelStats_GAA.Controls.Add(labelAverageArea_GAA);
            panelStats_GAA.Controls.Add(labelTotalArea_GAA);
            panelStats_GAA.Controls.Add(labelTotalApartments_GAA);
            panelStats_GAA.Location = new Point(12, 78);
            panelStats_GAA.Name = "panelStats_GAA";
            panelStats_GAA.Size = new Size(960, 36);
            panelStats_GAA.TabIndex = 2;
            // 
            // labelResidents_GAA
            // 
            labelResidents_GAA.AutoSize = true;
            labelResidents_GAA.Location = new Point(750, 10);
            labelResidents_GAA.Name = "labelResidents_GAA";
            labelResidents_GAA.Size = new Size(62, 15);
            labelResidents_GAA.TabIndex = 4;
            labelResidents_GAA.Text = "Жителей: ";
            // 
            // labelDebtCount_GAA
            // 
            labelDebtCount_GAA.AutoSize = true;
            labelDebtCount_GAA.Location = new Point(550, 10);
            labelDebtCount_GAA.Name = "labelDebtCount_GAA";
            labelDebtCount_GAA.Size = new Size(62, 15);
            labelDebtCount_GAA.TabIndex = 3;
            labelDebtCount_GAA.Text = "С долгом:";
            // 
            // labelAverageArea_GAA
            // 
            labelAverageArea_GAA.AutoSize = true;
            labelAverageArea_GAA.Location = new Point(350, 10);
            labelAverageArea_GAA.Name = "labelAverageArea_GAA";
            labelAverageArea_GAA.Size = new Size(109, 15);
            labelAverageArea_GAA.TabIndex = 2;
            labelAverageArea_GAA.Text = "Средняя площадь:";
            // 
            // labelTotalArea_GAA
            // 
            labelTotalArea_GAA.AutoSize = true;
            labelTotalArea_GAA.Location = new Point(150, 10);
            labelTotalArea_GAA.Name = "labelTotalArea_GAA";
            labelTotalArea_GAA.Size = new Size(102, 15);
            labelTotalArea_GAA.TabIndex = 1;
            labelTotalArea_GAA.Text = "Общая площадь:";
            // 
            // labelTotalApartments_GAA
            // 
            labelTotalApartments_GAA.AutoSize = true;
            labelTotalApartments_GAA.Location = new Point(15, 10);
            labelTotalApartments_GAA.Name = "labelTotalApartments_GAA";
            labelTotalApartments_GAA.Size = new Size(88, 15);
            labelTotalApartments_GAA.TabIndex = 0;
            labelTotalApartments_GAA.Text = "Всего квартир:";
            // 
            // FormMain_GAA
            // 
            ClientSize = new Size(984, 561);
            Controls.Add(panelStats_GAA);
            Controls.Add(panelControls_GAA);
            Controls.Add(dataGridViewApartments_GAA);
            MinimumSize = new Size(1000, 600);
            Name = "FormMain_GAA";
            Text = "Домоуправление - Галимов А.А.";
            ((System.ComponentModel.ISupportInitialize)dataGridViewApartments_GAA).EndInit();
            panelControls_GAA.ResumeLayout(false);
            panelControls_GAA.PerformLayout();
            panelStats_GAA.ResumeLayout(false);
            panelStats_GAA.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewApartments_GAA;
        private System.Windows.Forms.Panel panelControls_GAA;
        private System.Windows.Forms.Button buttonAdd_GAA;
        private System.Windows.Forms.Button buttonEdit_GAA;
        private System.Windows.Forms.Button buttonDelete_GAA;
        private System.Windows.Forms.TextBox textBoxSearch_GAA;
        private System.Windows.Forms.Button buttonSearch_GAA;
        private System.Windows.Forms.Button buttonFilterDebt_GAA;
        private System.Windows.Forms.ComboBox comboBoxSort_GAA;
        private System.Windows.Forms.Button buttonSort_GAA;
        private System.Windows.Forms.Button buttonChart_GAA;
        private System.Windows.Forms.Button buttonAbout_GAA;
        private System.Windows.Forms.Button buttonHelp_GAA;
        private System.Windows.Forms.Panel panelStats_GAA;
        private System.Windows.Forms.Label labelTotalApartments_GAA;
        private System.Windows.Forms.Label labelTotalArea_GAA;
        private System.Windows.Forms.Label labelAverageArea_GAA;
        private System.Windows.Forms.Label labelDebtCount_GAA;
        private System.Windows.Forms.Label labelResidents_GAA;
        private System.Windows.Forms.Button buttonReset_GAA;
    }
}