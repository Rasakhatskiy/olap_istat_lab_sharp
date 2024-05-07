namespace olap_c_sharp
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button_save_to_db = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage_crime_case = new System.Windows.Forms.TabPage();
            this.tabPage_crime_case_person = new System.Windows.Forms.TabPage();
            this.tabPage_crime_type = new System.Windows.Forms.TabPage();
            this.tabPage_detective = new System.Windows.Forms.TabPage();
            this.tabPage_location = new System.Windows.Forms.TabPage();
            this.tabPage_person = new System.Windows.Forms.TabPage();
            this.tabPage_police_department = new System.Windows.Forms.TabPage();
            this.tabPage_policeman = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button_vault = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView_slices = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton_chart_6 = new System.Windows.Forms.RadioButton();
            this.radioButton_chart_5 = new System.Windows.Forms.RadioButton();
            this.radioButton_chart_4 = new System.Windows.Forms.RadioButton();
            this.radioButton_chart_3 = new System.Windows.Forms.RadioButton();
            this.radioButton_chart_2 = new System.Windows.Forms.RadioButton();
            this.radioButton_chart_1 = new System.Windows.Forms.RadioButton();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_slices)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_save_to_db
            // 
            this.button_save_to_db.Location = new System.Drawing.Point(6, 6);
            this.button_save_to_db.Name = "button_save_to_db";
            this.button_save_to_db.Size = new System.Drawing.Size(75, 23);
            this.button_save_to_db.TabIndex = 2;
            this.button_save_to_db.Text = "Save";
            this.button_save_to_db.UseVisualStyleBackColor = true;
            this.button_save_to_db.Click += new System.EventHandler(this.button_save_to_db_Click);
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPage_crime_case);
            this.tabControl.Controls.Add(this.tabPage_crime_case_person);
            this.tabControl.Controls.Add(this.tabPage_crime_type);
            this.tabControl.Controls.Add(this.tabPage_detective);
            this.tabControl.Controls.Add(this.tabPage_location);
            this.tabControl.Controls.Add(this.tabPage_person);
            this.tabControl.Controls.Add(this.tabPage_police_department);
            this.tabControl.Controls.Add(this.tabPage_policeman);
            this.tabControl.Location = new System.Drawing.Point(8, 35);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1100, 556);
            this.tabControl.TabIndex = 1;
            // 
            // tabPage_crime_case
            // 
            this.tabPage_crime_case.Location = new System.Drawing.Point(4, 22);
            this.tabPage_crime_case.Name = "tabPage_crime_case";
            this.tabPage_crime_case.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_crime_case.Size = new System.Drawing.Size(1092, 530);
            this.tabPage_crime_case.TabIndex = 0;
            this.tabPage_crime_case.Text = "crime_case";
            this.tabPage_crime_case.UseVisualStyleBackColor = true;
            // 
            // tabPage_crime_case_person
            // 
            this.tabPage_crime_case_person.Location = new System.Drawing.Point(4, 22);
            this.tabPage_crime_case_person.Name = "tabPage_crime_case_person";
            this.tabPage_crime_case_person.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_crime_case_person.Size = new System.Drawing.Size(1092, 530);
            this.tabPage_crime_case_person.TabIndex = 1;
            this.tabPage_crime_case_person.Text = "crime_case_person";
            this.tabPage_crime_case_person.UseVisualStyleBackColor = true;
            // 
            // tabPage_crime_type
            // 
            this.tabPage_crime_type.Location = new System.Drawing.Point(4, 22);
            this.tabPage_crime_type.Name = "tabPage_crime_type";
            this.tabPage_crime_type.Size = new System.Drawing.Size(1092, 530);
            this.tabPage_crime_type.TabIndex = 2;
            this.tabPage_crime_type.Text = "crime_type";
            this.tabPage_crime_type.UseVisualStyleBackColor = true;
            // 
            // tabPage_detective
            // 
            this.tabPage_detective.Location = new System.Drawing.Point(4, 22);
            this.tabPage_detective.Name = "tabPage_detective";
            this.tabPage_detective.Size = new System.Drawing.Size(1092, 530);
            this.tabPage_detective.TabIndex = 3;
            this.tabPage_detective.Text = "detective";
            this.tabPage_detective.UseVisualStyleBackColor = true;
            // 
            // tabPage_location
            // 
            this.tabPage_location.Location = new System.Drawing.Point(4, 22);
            this.tabPage_location.Name = "tabPage_location";
            this.tabPage_location.Size = new System.Drawing.Size(1092, 530);
            this.tabPage_location.TabIndex = 4;
            this.tabPage_location.Text = "location";
            this.tabPage_location.UseVisualStyleBackColor = true;
            // 
            // tabPage_person
            // 
            this.tabPage_person.Location = new System.Drawing.Point(4, 22);
            this.tabPage_person.Name = "tabPage_person";
            this.tabPage_person.Size = new System.Drawing.Size(1092, 530);
            this.tabPage_person.TabIndex = 5;
            this.tabPage_person.Text = "person";
            this.tabPage_person.UseVisualStyleBackColor = true;
            // 
            // tabPage_police_department
            // 
            this.tabPage_police_department.Location = new System.Drawing.Point(4, 22);
            this.tabPage_police_department.Name = "tabPage_police_department";
            this.tabPage_police_department.Size = new System.Drawing.Size(1092, 530);
            this.tabPage_police_department.TabIndex = 6;
            this.tabPage_police_department.Text = "police_department";
            this.tabPage_police_department.UseVisualStyleBackColor = true;
            // 
            // tabPage_policeman
            // 
            this.tabPage_policeman.Location = new System.Drawing.Point(4, 22);
            this.tabPage_policeman.Name = "tabPage_policeman";
            this.tabPage_policeman.Size = new System.Drawing.Size(1092, 530);
            this.tabPage_policeman.TabIndex = 7;
            this.tabPage_policeman.Text = "policeman";
            this.tabPage_policeman.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1062, 611);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tabControl);
            this.tabPage1.Controls.Add(this.button_save_to_db);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1054, 585);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "View/Edit";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button_vault);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1054, 585);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Vault";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button_vault
            // 
            this.button_vault.Location = new System.Drawing.Point(6, 6);
            this.button_vault.Name = "button_vault";
            this.button_vault.Size = new System.Drawing.Size(75, 23);
            this.button_vault.TabIndex = 0;
            this.button_vault.Text = "Save";
            this.button_vault.UseVisualStyleBackColor = true;
            this.button_vault.Click += new System.EventHandler(this.button_vault_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView_slices);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1054, 585);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Slices";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView_slices
            // 
            this.dataGridView_slices.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_slices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_slices.Location = new System.Drawing.Point(4, 152);
            this.dataGridView_slices.Name = "dataGridView_slices";
            this.dataGridView_slices.Size = new System.Drawing.Size(575, 192);
            this.dataGridView_slices.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(575, 142);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Get";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(6, 89);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(274, 17);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Справи, в яких той хто викликав є підозрюваним";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 65);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(350, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Кількість розкритих та нерозкритих справ за кожним злочином";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 42);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(239, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Скільки злочинів розкрив кожен детектив";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(389, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Де більше всього відбулось особливо тяжких злочинів за перші півроку";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox2);
            this.tabPage4.Controls.Add(this.chart1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1054, 585);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Diagrams";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.radioButton_chart_6);
            this.groupBox2.Controls.Add(this.radioButton_chart_5);
            this.groupBox2.Controls.Add(this.radioButton_chart_4);
            this.groupBox2.Controls.Add(this.radioButton_chart_3);
            this.groupBox2.Controls.Add(this.radioButton_chart_2);
            this.groupBox2.Controls.Add(this.radioButton_chart_1);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1048, 92);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Оберіть діаграму";
            // 
            // radioButton_chart_6
            // 
            this.radioButton_chart_6.AutoSize = true;
            this.radioButton_chart_6.Location = new System.Drawing.Point(312, 65);
            this.radioButton_chart_6.Name = "radioButton_chart_6";
            this.radioButton_chart_6.Size = new System.Drawing.Size(85, 17);
            this.radioButton_chart_6.TabIndex = 5;
            this.radioButton_chart_6.TabStop = true;
            this.radioButton_chart_6.Text = "radioButton9";
            this.radioButton_chart_6.CheckedChanged += new System.EventHandler(this.radioButton_chart_CheckedChanged);
            // 
            // radioButton_chart_5
            // 
            this.radioButton_chart_5.AutoSize = true;
            this.radioButton_chart_5.Location = new System.Drawing.Point(312, 42);
            this.radioButton_chart_5.Name = "radioButton_chart_5";
            this.radioButton_chart_5.Size = new System.Drawing.Size(85, 17);
            this.radioButton_chart_5.TabIndex = 4;
            this.radioButton_chart_5.TabStop = true;
            this.radioButton_chart_5.Text = "radioButton8";
            this.radioButton_chart_5.UseVisualStyleBackColor = true;
            this.radioButton_chart_5.CheckedChanged += new System.EventHandler(this.radioButton_chart_CheckedChanged);
            // 
            // radioButton_chart_4
            // 
            this.radioButton_chart_4.AutoSize = true;
            this.radioButton_chart_4.Location = new System.Drawing.Point(312, 19);
            this.radioButton_chart_4.Name = "radioButton_chart_4";
            this.radioButton_chart_4.Size = new System.Drawing.Size(85, 17);
            this.radioButton_chart_4.TabIndex = 3;
            this.radioButton_chart_4.TabStop = true;
            this.radioButton_chart_4.Text = "radioButton7";
            this.radioButton_chart_4.UseVisualStyleBackColor = true;
            this.radioButton_chart_4.CheckedChanged += new System.EventHandler(this.radioButton_chart_CheckedChanged);
            // 
            // radioButton_chart_3
            // 
            this.radioButton_chart_3.AutoSize = true;
            this.radioButton_chart_3.Location = new System.Drawing.Point(6, 65);
            this.radioButton_chart_3.Name = "radioButton_chart_3";
            this.radioButton_chart_3.Size = new System.Drawing.Size(85, 17);
            this.radioButton_chart_3.TabIndex = 2;
            this.radioButton_chart_3.TabStop = true;
            this.radioButton_chart_3.Text = "radioButton6";
            this.radioButton_chart_3.UseVisualStyleBackColor = true;
            this.radioButton_chart_3.CheckedChanged += new System.EventHandler(this.radioButton_chart_CheckedChanged);
            // 
            // radioButton_chart_2
            // 
            this.radioButton_chart_2.AutoSize = true;
            this.radioButton_chart_2.Location = new System.Drawing.Point(6, 42);
            this.radioButton_chart_2.Name = "radioButton_chart_2";
            this.radioButton_chart_2.Size = new System.Drawing.Size(85, 17);
            this.radioButton_chart_2.TabIndex = 1;
            this.radioButton_chart_2.TabStop = true;
            this.radioButton_chart_2.Text = "Кількість злочинів за важкістю";
            this.radioButton_chart_2.UseVisualStyleBackColor = true;
            this.radioButton_chart_2.CheckedChanged += new System.EventHandler(this.radioButton_chart_CheckedChanged);
            // 
            // radioButton_chart_1
            // 
            this.radioButton_chart_1.AutoSize = true;
            this.radioButton_chart_1.Location = new System.Drawing.Point(6, 19);
            this.radioButton_chart_1.Name = "radioButton_chart_1";
            this.radioButton_chart_1.Size = new System.Drawing.Size(85, 17);
            this.radioButton_chart_1.TabIndex = 0;
            this.radioButton_chart_1.TabStop = true;
            this.radioButton_chart_1.Text = "Кількість злочинів за тиждень в 2023";
            this.radioButton_chart_1.UseVisualStyleBackColor = true;
            this.radioButton_chart_1.CheckedChanged += new System.EventHandler(this.radioButton_chart_CheckedChanged);
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(3, 101);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(1048, 481);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chart1_MouseMove);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.richTextBox1);
            this.tabPage5.Controls.Add(this.pictureBox1);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1054, 585);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "About";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(210)))), ((int)(((byte)(202)))));
            this.richTextBox1.ForeColor = System.Drawing.Color.Black;
            this.richTextBox1.Location = new System.Drawing.Point(430, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(621, 579);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.BackgroundImage = global::olap_c_sharp.Properties.Resources.maxim_wanted_2;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(421, 579);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 635);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "OLAP :)";
            this.tabControl.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_slices)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage_crime_case;
        private System.Windows.Forms.TabPage tabPage_crime_case_person;
        private System.Windows.Forms.TabPage tabPage_crime_type;
        private System.Windows.Forms.TabPage tabPage_detective;
        private System.Windows.Forms.TabPage tabPage_location;
        private System.Windows.Forms.TabPage tabPage_person;
        private System.Windows.Forms.TabPage tabPage_police_department;
        private System.Windows.Forms.TabPage tabPage_policeman;
        private System.Windows.Forms.Button button_save_to_db;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button button_vault;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.DataGridView dataGridView_slices;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton_chart_6;
        private System.Windows.Forms.RadioButton radioButton_chart_5;
        private System.Windows.Forms.RadioButton radioButton_chart_4;
        private System.Windows.Forms.RadioButton radioButton_chart_3;
        private System.Windows.Forms.RadioButton radioButton_chart_2;
        private System.Windows.Forms.RadioButton radioButton_chart_1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}