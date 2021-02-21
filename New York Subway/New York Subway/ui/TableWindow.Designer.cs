
namespace New_York_Subway
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.table = new System.Windows.Forms.DataGridView();
            this.Division = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Line = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Latitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Longitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vending = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Staffing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoadFileButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.searchLongitudeButton = new System.Windows.Forms.Button();
            this.searchLatitudeButton = new System.Windows.Forms.Button();
            this.searchNameButton = new System.Windows.Forms.Button();
            this.searchLineButton = new System.Windows.Forms.Button();
            this.staffingComboBox = new System.Windows.Forms.ComboBox();
            this.vendingComboBox = new System.Windows.Forms.ComboBox();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.longMaxTextBox = new System.Windows.Forms.TextBox();
            this.longMinTextBox = new System.Windows.Forms.TextBox();
            this.latMaxTextBox = new System.Windows.Forms.TextBox();
            this.latMinTextBox = new System.Windows.Forms.TextBox();
            this.nameStationTextBox = new System.Windows.Forms.TextBox();
            this.lineTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.loadMapButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.resetTableButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // table
            // 
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Division,
            this.Line,
            this.StationName,
            this.Latitude,
            this.Longitude,
            this.Type,
            this.Vending,
            this.Staffing});
            this.table.Location = new System.Drawing.Point(24, 12);
            this.table.Name = "table";
            this.table.Size = new System.Drawing.Size(845, 196);
            this.table.TabIndex = 0;
            // 
            // Division
            // 
            this.Division.HeaderText = "Division";
            this.Division.Name = "Division";
            // 
            // Line
            // 
            this.Line.HeaderText = "Line";
            this.Line.Name = "Line";
            // 
            // StationName
            // 
            this.StationName.HeaderText = "Station Name";
            this.StationName.Name = "StationName";
            // 
            // Latitude
            // 
            this.Latitude.HeaderText = "Entrance Latitude";
            this.Latitude.Name = "Latitude";
            // 
            // Longitude
            // 
            this.Longitude.HeaderText = "Entrance Longitude";
            this.Longitude.Name = "Longitude";
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            // 
            // Vending
            // 
            this.Vending.HeaderText = "Vending";
            this.Vending.Name = "Vending";
            // 
            // Staffing
            // 
            this.Staffing.HeaderText = "Staffing";
            this.Staffing.Name = "Staffing";
            // 
            // LoadFileButton
            // 
            this.LoadFileButton.Location = new System.Drawing.Point(791, 236);
            this.LoadFileButton.Name = "LoadFileButton";
            this.LoadFileButton.Size = new System.Drawing.Size(96, 28);
            this.LoadFileButton.TabIndex = 2;
            this.LoadFileButton.Text = "Load file...";
            this.LoadFileButton.UseVisualStyleBackColor = true;
            this.LoadFileButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(24, 214);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(765, 276);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.searchLongitudeButton);
            this.tabPage1.Controls.Add(this.searchLatitudeButton);
            this.tabPage1.Controls.Add(this.searchNameButton);
            this.tabPage1.Controls.Add(this.searchLineButton);
            this.tabPage1.Controls.Add(this.staffingComboBox);
            this.tabPage1.Controls.Add(this.vendingComboBox);
            this.tabPage1.Controls.Add(this.typeComboBox);
            this.tabPage1.Controls.Add(this.longMaxTextBox);
            this.tabPage1.Controls.Add(this.longMinTextBox);
            this.tabPage1.Controls.Add(this.latMaxTextBox);
            this.tabPage1.Controls.Add(this.latMinTextBox);
            this.tabPage1.Controls.Add(this.nameStationTextBox);
            this.tabPage1.Controls.Add(this.lineTextBox);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(757, 250);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Filters";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Division:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(430, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Entrance Type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(464, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Staffing:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(461, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Vending:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // searchLongitudeButton
            // 
            this.searchLongitudeButton.Enabled = false;
            this.searchLongitudeButton.Location = new System.Drawing.Point(321, 196);
            this.searchLongitudeButton.Name = "searchLongitudeButton";
            this.searchLongitudeButton.Size = new System.Drawing.Size(99, 23);
            this.searchLongitudeButton.TabIndex = 13;
            this.searchLongitudeButton.Text = "search Longitude";
            this.searchLongitudeButton.UseVisualStyleBackColor = true;
            this.searchLongitudeButton.Click += new System.EventHandler(this.searchLongitudeButton_Click);
            // 
            // searchLatitudeButton
            // 
            this.searchLatitudeButton.Enabled = false;
            this.searchLatitudeButton.Location = new System.Drawing.Point(321, 155);
            this.searchLatitudeButton.Name = "searchLatitudeButton";
            this.searchLatitudeButton.Size = new System.Drawing.Size(99, 23);
            this.searchLatitudeButton.TabIndex = 12;
            this.searchLatitudeButton.Text = "search Latitude";
            this.searchLatitudeButton.UseVisualStyleBackColor = true;
            this.searchLatitudeButton.Click += new System.EventHandler(this.searchLatitudeButton_Click);
            // 
            // searchNameButton
            // 
            this.searchNameButton.Enabled = false;
            this.searchNameButton.Location = new System.Drawing.Point(165, 114);
            this.searchNameButton.Name = "searchNameButton";
            this.searchNameButton.Size = new System.Drawing.Size(121, 23);
            this.searchNameButton.TabIndex = 11;
            this.searchNameButton.Text = "search name station";
            this.searchNameButton.UseVisualStyleBackColor = true;
            this.searchNameButton.Click += new System.EventHandler(this.searchNameButton_Click);
            // 
            // searchLineButton
            // 
            this.searchLineButton.Enabled = false;
            this.searchLineButton.Location = new System.Drawing.Point(165, 65);
            this.searchLineButton.Name = "searchLineButton";
            this.searchLineButton.Size = new System.Drawing.Size(75, 23);
            this.searchLineButton.TabIndex = 10;
            this.searchLineButton.Text = "search line";
            this.searchLineButton.UseVisualStyleBackColor = true;
            this.searchLineButton.Click += new System.EventHandler(this.searchLineButton_Click);
            // 
            // staffingComboBox
            // 
            this.staffingComboBox.Enabled = false;
            this.staffingComboBox.FormattingEnabled = true;
            this.staffingComboBox.Items.AddRange(new object[] {
            "Full",
            "None"});
            this.staffingComboBox.Location = new System.Drawing.Point(516, 114);
            this.staffingComboBox.Name = "staffingComboBox";
            this.staffingComboBox.Size = new System.Drawing.Size(121, 21);
            this.staffingComboBox.TabIndex = 9;
            this.staffingComboBox.Text = "Staffing";
            this.staffingComboBox.SelectedIndexChanged += new System.EventHandler(this.staffingComboBox_SelectedIndexChanged);
            // 
            // vendingComboBox
            // 
            this.vendingComboBox.Enabled = false;
            this.vendingComboBox.FormattingEnabled = true;
            this.vendingComboBox.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.vendingComboBox.Location = new System.Drawing.Point(516, 67);
            this.vendingComboBox.Name = "vendingComboBox";
            this.vendingComboBox.Size = new System.Drawing.Size(121, 21);
            this.vendingComboBox.TabIndex = 8;
            this.vendingComboBox.Text = "Vending";
            this.vendingComboBox.SelectedIndexChanged += new System.EventHandler(this.vendingComboBox_SelectedIndexChanged);
            // 
            // typeComboBox
            // 
            this.typeComboBox.Enabled = false;
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Items.AddRange(new object[] {
            "Stair",
            "Elevator",
            "Easement",
            "Escalator",
            "Door",
            "Ramp",
            "Walkway"});
            this.typeComboBox.Location = new System.Drawing.Point(516, 23);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(121, 21);
            this.typeComboBox.TabIndex = 7;
            this.typeComboBox.Text = "Entrance type";
            this.typeComboBox.SelectedIndexChanged += new System.EventHandler(this.typeComboBox_SelectedIndexChanged);
            // 
            // longMaxTextBox
            // 
            this.longMaxTextBox.Location = new System.Drawing.Point(165, 199);
            this.longMaxTextBox.Name = "longMaxTextBox";
            this.longMaxTextBox.Size = new System.Drawing.Size(121, 20);
            this.longMaxTextBox.TabIndex = 6;
            // 
            // longMinTextBox
            // 
            this.longMinTextBox.Location = new System.Drawing.Point(21, 199);
            this.longMinTextBox.Name = "longMinTextBox";
            this.longMinTextBox.Size = new System.Drawing.Size(121, 20);
            this.longMinTextBox.TabIndex = 5;
            // 
            // latMaxTextBox
            // 
            this.latMaxTextBox.Location = new System.Drawing.Point(165, 158);
            this.latMaxTextBox.Name = "latMaxTextBox";
            this.latMaxTextBox.Size = new System.Drawing.Size(121, 20);
            this.latMaxTextBox.TabIndex = 4;
            // 
            // latMinTextBox
            // 
            this.latMinTextBox.Location = new System.Drawing.Point(21, 158);
            this.latMinTextBox.Name = "latMinTextBox";
            this.latMinTextBox.Size = new System.Drawing.Size(121, 20);
            this.latMinTextBox.TabIndex = 3;
            // 
            // nameStationTextBox
            // 
            this.nameStationTextBox.Location = new System.Drawing.Point(21, 114);
            this.nameStationTextBox.Name = "nameStationTextBox";
            this.nameStationTextBox.Size = new System.Drawing.Size(121, 20);
            this.nameStationTextBox.TabIndex = 2;
            // 
            // lineTextBox
            // 
            this.lineTextBox.Location = new System.Drawing.Point(21, 67);
            this.lineTextBox.Name = "lineTextBox";
            this.lineTextBox.Size = new System.Drawing.Size(121, 20);
            this.lineTextBox.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "BMT",
            "IND",
            "IRT"});
            this.comboBox1.Location = new System.Drawing.Point(21, 23);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "Division";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chart3);
            this.tabPage2.Controls.Add(this.chart2);
            this.tabPage2.Controls.Add(this.chart1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(757, 250);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Graphs";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chart3
            // 
            chartArea7.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.chart3.Legends.Add(legend7);
            this.chart3.Location = new System.Drawing.Point(498, 24);
            this.chart3.Name = "chart3";
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            this.chart3.Series.Add(series7);
            this.chart3.Size = new System.Drawing.Size(242, 187);
            this.chart3.TabIndex = 2;
            this.chart3.Text = "chart3";
            // 
            // chart2
            // 
            chartArea8.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.chart2.Legends.Add(legend8);
            this.chart2.Location = new System.Drawing.Point(254, 24);
            this.chart2.Name = "chart2";
            series8.ChartArea = "ChartArea1";
            series8.Legend = "Legend1";
            series8.Name = "Series1";
            this.chart2.Series.Add(series8);
            this.chart2.Size = new System.Drawing.Size(242, 187);
            this.chart2.TabIndex = 1;
            this.chart2.Text = "chart2";
            // 
            // chart1
            // 
            chartArea9.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea9);
            legend9.Name = "Legend1";
            this.chart1.Legends.Add(legend9);
            this.chart1.Location = new System.Drawing.Point(6, 24);
            this.chart1.Name = "chart1";
            series9.ChartArea = "ChartArea1";
            series9.Legend = "Legend1";
            series9.Name = "Series1";
            this.chart1.Series.Add(series9);
            this.chart1.Size = new System.Drawing.Size(242, 187);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // loadMapButton
            // 
            this.loadMapButton.Enabled = false;
            this.loadMapButton.Location = new System.Drawing.Point(790, 463);
            this.loadMapButton.Name = "loadMapButton";
            this.loadMapButton.Size = new System.Drawing.Size(97, 23);
            this.loadMapButton.TabIndex = 7;
            this.loadMapButton.Text = "Load Map";
            this.loadMapButton.UseVisualStyleBackColor = true;
            this.loadMapButton.Click += new System.EventHandler(this.loadMapButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // resetTableButton
            // 
            this.resetTableButton.Enabled = false;
            this.resetTableButton.Location = new System.Drawing.Point(791, 267);
            this.resetTableButton.Name = "resetTableButton";
            this.resetTableButton.Size = new System.Drawing.Size(96, 28);
            this.resetTableButton.TabIndex = 8;
            this.resetTableButton.Text = "Reset table";
            this.resetTableButton.UseVisualStyleBackColor = true;
            this.resetTableButton.Click += new System.EventHandler(this.resetTableButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "min:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(165, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "max:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "min:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(165, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "max:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 502);
            this.Controls.Add(this.resetTableButton);
            this.Controls.Add(this.loadMapButton);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.LoadFileButton);
            this.Controls.Add(this.table);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.DataGridViewTextBoxColumn Division;
        private System.Windows.Forms.DataGridViewTextBoxColumn Line;
        private System.Windows.Forms.DataGridViewTextBoxColumn StationName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Latitude;
        private System.Windows.Forms.DataGridViewTextBoxColumn Longitude;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vending;
        private System.Windows.Forms.DataGridViewTextBoxColumn Staffing;
        private System.Windows.Forms.Button LoadFileButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ComboBox staffingComboBox;
        private System.Windows.Forms.ComboBox vendingComboBox;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.TextBox longMaxTextBox;
        private System.Windows.Forms.TextBox longMinTextBox;
        private System.Windows.Forms.TextBox latMaxTextBox;
        private System.Windows.Forms.TextBox latMinTextBox;
        private System.Windows.Forms.TextBox nameStationTextBox;
        private System.Windows.Forms.TextBox lineTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button searchLongitudeButton;
        private System.Windows.Forms.Button searchLatitudeButton;
        private System.Windows.Forms.Button searchNameButton;
        private System.Windows.Forms.Button searchLineButton;
        private System.Windows.Forms.Button loadMapButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button resetTableButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}

