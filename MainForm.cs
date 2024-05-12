using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace olap_c_sharp
{
    public partial class MainForm : Form
    {
        private NpgsqlConnection connection;

        public MainForm()
        {
            InitializeComponent();

            connection = new NpgsqlConnection("Server=192.168.110.136;Port=5432;User Id=postgres;Password=password;Database=postgres");
            connection.Open();

            LoadDataGrids();
            SetPersionalInfo();
            SetupChart();

            this.Size = new Size(Screen.PrimaryScreen.Bounds.Width * 3/4, Screen.PrimaryScreen.Bounds.Height * 3/4);

        }

        private void LoadDataGrids()
        {
            for (int i = 0; i < tabControl.TabPages.Count; i++)
            {
                var tab = tabControl.TabPages[i];

                NpgsqlDataAdapter da = new NpgsqlDataAdapter("SELECT * FROM " + tab.Text, connection);

                NpgsqlCommandBuilder cb = new NpgsqlCommandBuilder(da);

                DataTable dt = new DataTable();

                da.Fill(dt);

                DataGridView dg = new DataGridView();
                dg.Dock = DockStyle.Fill;
                dg.DataSource = dt;

                tab.Controls.Add(dg);

                if (tab.Text == "crime_case")
                {
                    DateTimePicker dtp1 = new DateTimePicker();
                    dtp1.Format = DateTimePickerFormat.Custom;
                    dtp1.CustomFormat = "yyyy-MM-dd";
                    dtp1.Value = DateTime.Now;
                    dtp1.Dock = DockStyle.Top;

                    DateTimePicker dtp2 = new DateTimePicker();
                    dtp2.Format = DateTimePickerFormat.Custom;
                    dtp2.CustomFormat = "yyyy-MM-dd";
                    dtp2.Value = DateTime.Now;
                    dtp2.Dock = DockStyle.Top;

                    var btn = new System.Windows.Forms.Button();
                    btn.Text = "Filter";
                    btn.Dock = DockStyle.Top;

                    btn.Click += (sender, e) =>
                    {
                        string query = "SELECT * FROM " + tab.Text + " WHERE date BETWEEN '" + dtp1.Value.ToString("yyyy-MM-dd") + "' AND '" + dtp2.Value.ToString("yyyy-MM-dd") + "'";
                        da = new NpgsqlDataAdapter(query, connection);
                        cb = new NpgsqlCommandBuilder(da);
                        dt = new DataTable();
                        da.Fill(dt);
                        dg.DataSource = dt;
                    };

                    tab.Controls.Add(btn);
                    tab.Controls.Add(dtp2);
                    tab.Controls.Add(dtp1);
                }
               

            }
            {
                NpgsqlDataAdapter da = new NpgsqlDataAdapter("SELECT * FROM " + "vault", connection);
                NpgsqlCommandBuilder cb = new NpgsqlCommandBuilder(da);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView_vault.DataSource = dt;
            }
        }

        private void UpdateDataGrids()
        {
            for (int i = 0; i < tabControl.TabPages.Count; i++)
            {
                var tab = tabControl.TabPages[i];
                tab.Controls.Clear();
            }
            LoadDataGrids();
        }

        private void SetPersionalInfo()
        {
            richTextBox1.Text = "Расахацький Максим\n" +
                "БІ-1\n" +
                "Факультет Комп'ютерних Наук та Кібернетики\n" +
                "Київський національний університет імені Тараса Шевченка\n" +
                "Phone: 066-589-33-26\n" +
                "Email: maksym.rasakhatskyi@gmail.com";
            richTextBox1.ReadOnly = true;
            richTextBox1.Font = new Font("Comic Sans MS", 24);

        }

        private void SetupChart()
        {
            ChartArea CA = chart1.ChartAreas[0]; 
            CA.AxisX.ScaleView.Zoomable = true;
            CA.CursorX.AutoScroll = true;
            CA.CursorX.IsUserSelectionEnabled = true;
        }

        private void button_save_to_db_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < tabControl.TabPages.Count; i++)
            {
                var tab = tabControl.TabPages[i];
                var dg = tab.Controls[0] as DataGridView;
                NpgsqlDataAdapter da = new NpgsqlDataAdapter("SELECT * FROM " + tab.Text, connection);
                NpgsqlCommandBuilder cb = new NpgsqlCommandBuilder(da);
                da.Update((DataTable)dg.DataSource);
            }
            {
                NpgsqlDataAdapter da = new NpgsqlDataAdapter("SELECT * FROM " + "vault", connection);
                NpgsqlCommandBuilder cb = new NpgsqlCommandBuilder(da);
                da.Update((DataTable)dataGridView_vault.DataSource);
            }
        }

        private void button_vault_Click_old(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV files (*.csv)|*.csv";
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() != DialogResult.OK)
                return;

            using (NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM get_vault_table()", connection))
            using (NpgsqlDataReader reader = command.ExecuteReader())
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(saveFileDialog.FileName, false, new System.Text.UTF8Encoding(true)))
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    file.Write($"\"{reader.GetName(i)}\"");
                    if (i < reader.FieldCount - 1)
                        file.Write(",");
                }
                file.WriteLine();

                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        file.Write($"\"{reader[i].ToString()}\"");
                        if (i < reader.FieldCount - 1)
                            file.Write(",");
                    }
                    file.WriteLine();
                }
            }
        }

        private void button_vault_Click(object sender, EventArgs e)
        {
            using (NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM get_vault_table()", connection))
            using (NpgsqlDataReader reader = command.ExecuteReader());

            using (NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM delete_moved_cases()", connection))
            using (NpgsqlDataReader reader = command.ExecuteReader()) ;

            UpdateDataGrids();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string storedFuncName = "";
            if (radioButton1.Checked) storedFuncName = "get_crimes_by_city";
            if (radioButton2.Checked) storedFuncName = "get_detective_solved_cases";
            if (radioButton3.Checked) storedFuncName = "get_crime_cases_status";
            if (radioButton4.Checked) storedFuncName = "get_cases_by_person";

            if (storedFuncName.Length == 0) return;

            using (NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM " + storedFuncName + "()", connection))
            using (NpgsqlDataReader reader = command.ExecuteReader())
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridView_slices.DataSource = dt;
            }

        }

        Point? prevPosition = null;
        System.Windows.Forms.ToolTip tooltip = new System.Windows.Forms.ToolTip();

        void chart1_MouseMove(object sender, MouseEventArgs e)
        {
            var pos = e.Location;
            if (prevPosition.HasValue && pos == prevPosition.Value)
                return;
            tooltip.RemoveAll();
            prevPosition = pos;
            var results = chart1.HitTest(pos.X, pos.Y, false,
                                            ChartElementType.DataPoint);
            foreach (var result in results)
            {
                if (result.ChartElementType == ChartElementType.DataPoint)
                {
                    var prop = result.Object as DataPoint;
                    if (prop != null)
                    {
                        var pointXPixel = result.ChartArea.AxisX.ValueToPixelPosition(prop.XValue);
                        var pointYPixel = result.ChartArea.AxisY.ValueToPixelPosition(prop.YValues[0]);

                        // check if the cursor is really close to the point (2 pixels around the point)
                        if (Math.Abs(pos.X - pointXPixel) < 2 &&
                            Math.Abs(pos.Y - pointYPixel) < 2)
                        {
                            tooltip.Show("X=" + prop.XValue + ", Y=" + prop.YValues[0], this.chart1,
                                            pos.X, pos.Y - 15);
                        }
                    }
                }
            }
        }

        private void radioButton_chart_CheckedChanged(object sender, EventArgs e)
        {
            chart1.Visible = true;
            if (radioButton_chart_1.Checked)
            {
                using (NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM get_crimes_per_week()", connection))
                using (NpgsqlDataReader reader = command.ExecuteReader())
                {
                    chart1.Series.Clear();
                    chart1.ChartAreas.Clear();
                    chart1.ChartAreas.Add(new ChartArea("ChartArea1"));
                    chart1.Series.Add(new Series("Series1"));
                    chart1.Series["Series1"].ChartType = SeriesChartType.Line;
                    chart1.Series["Series1"].XValueMember = "crime_week";
                    chart1.Series["Series1"].YValueMembers = "total_cases";
                    chart1.Series["Series1"].LegendText = "Crimes per week";
                    chart1.Series["Series1"].IsValueShownAsLabel = false;
                    chart1.DataSource = reader;
                    chart1.DataBind();
                    SetupChart();
                }
            }
            if(radioButton_chart_2.Checked)
            {
                using (NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM get_crimes_per_severity()", connection))
                using (NpgsqlDataReader reader = command.ExecuteReader())
                {
                    chart1.Series.Clear();
                    chart1.ChartAreas.Clear();
                    chart1.ChartAreas.Add(new ChartArea("ChartArea1"));
                    chart1.Series.Add(new Series("Series1"));
                    chart1.Series["Series1"].ChartType = SeriesChartType.Column;
                    chart1.Series["Series1"].XValueMember = "crime_severity";
                    chart1.Series["Series1"].YValueMembers = "total_cases";
                    chart1.Series["Series1"].LegendText = "Crimes per severity";
                    chart1.Series["Series1"].IsValueShownAsLabel = true;
                    chart1.DataSource = reader;
                    chart1.DataBind();
                    SetupChart();
                }
            }
            if  (radioButton_chart_3.Checked)
            {
                using (NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM get_criminals_by_age_category()", connection))
                using (NpgsqlDataReader reader = command.ExecuteReader())
                {
                    chart1.Series.Clear();
                    chart1.ChartAreas.Clear();
                    chart1.ChartAreas.Add(new ChartArea("ChartArea1"));
                    chart1.Series.Add(new Series("Series1"));
                    chart1.Series["Series1"].ChartType = SeriesChartType.Column;
                    chart1.Series["Series1"].XValueMember = "age_category";
                    chart1.Series["Series1"].YValueMembers = "number_of_criminals";
                    chart1.Series["Series1"].LegendText = "Crimes per severity";
                    chart1.Series["Series1"].IsValueShownAsLabel = true;
                    chart1.DataSource = reader;
                    chart1.DataBind();
                    SetupChart();
                }
            }
            if (radioButton_chart_4.Checked)
            {
                using (NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM get_detective_solved_cases()", connection))
                using (NpgsqlDataReader reader = command.ExecuteReader())
                {
                    chart1.Series.Clear();
                    chart1.ChartAreas.Clear();
                    chart1.ChartAreas.Add(new ChartArea("ChartArea1"));
                    chart1.Series.Add(new Series("Series1"));
                    chart1.Series["Series1"].ChartType = SeriesChartType.Pie;
                    chart1.Series["Series1"].XValueMember = "detective_name";
                    chart1.Series["Series1"].YValueMembers = "solved_cases";
                    chart1.Series["Series1"].IsValueShownAsLabel = true;
                    chart1.DataSource = reader;
                    chart1.DataBind();
                    SetupChart();
                }
            }
            if (radioButton_chart_5.Checked)
            {
                using (NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM get_detective_solved_cases()", connection))
                using (NpgsqlDataReader reader = command.ExecuteReader())
                {
                    chart1.Series.Clear();
                    chart1.ChartAreas.Clear();
                    chart1.ChartAreas.Add(new ChartArea("ChartArea1"));
                    chart1.Series.Add(new Series("Series1"));
                    chart1.Series["Series1"].ChartType = SeriesChartType.Pie;
                    chart1.Series["Series1"].XValueMember = "detective_name";
                    chart1.Series["Series1"].YValueMembers = "unsolved_cases";
                    chart1.Series["Series1"].IsValueShownAsLabel = true;
                    chart1.DataSource = reader;
                    chart1.DataBind();
                    SetupChart();
                }
            }
            if (radioButton_chart_6.Checked)
            {
                using (NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM get_crime_counts()", connection))
                using (NpgsqlDataReader reader = command.ExecuteReader())
                {
                    chart1.Series.Clear();
                    chart1.ChartAreas.Clear();
                    chart1.ChartAreas.Add(new ChartArea("ChartArea1"));
                    chart1.Series.Add(new Series("Series1"));
                    chart1.Series["Series1"].ChartType = SeriesChartType.Pie;
                    chart1.Series["Series1"].XValueMember = "crime_name";
                    chart1.Series["Series1"].YValueMembers = "total_cases";
                    chart1.Series["Series1"].IsValueShownAsLabel = true;

                    chart1.Series["Series1"].ToolTip = "#VALX: #VALY";

                    chart1.DataSource = reader;
                    chart1.DataBind();
                    SetupChart();
                }
            }
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            UpdateDataGrids();  
        }

    }
}