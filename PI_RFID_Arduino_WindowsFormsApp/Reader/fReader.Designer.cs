namespace PI_RFID_Arduino_WindowsFormsApp.Reader
{
    partial class fReader
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tlpReadMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnStopRead = new System.Windows.Forms.Button();
            this.btnStartRead = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tlpResultMain = new System.Windows.Forms.TableLayoutPanel();
            this.cDados = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblResult = new System.Windows.Forms.Label();
            this.timerRead = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.serialPort2 = new System.IO.Ports.SerialPort(this.components);
            this.tlpReadMain.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tlpResultMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cDados)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpReadMain
            // 
            this.tlpReadMain.ColumnCount = 2;
            this.tlpReadMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tlpReadMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpReadMain.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tlpReadMain.Controls.Add(this.tlpResultMain, 1, 0);
            this.tlpReadMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpReadMain.Location = new System.Drawing.Point(0, 0);
            this.tlpReadMain.Margin = new System.Windows.Forms.Padding(0);
            this.tlpReadMain.Name = "tlpReadMain";
            this.tlpReadMain.RowCount = 1;
            this.tlpReadMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpReadMain.Size = new System.Drawing.Size(1050, 575);
            this.tlpReadMain.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.SkyBlue;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btnStopRead, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnStartRead, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnClean, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnSave, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 575);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnStopRead
            // 
            this.btnStopRead.BackColor = System.Drawing.Color.Firebrick;
            this.btnStopRead.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStopRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStopRead.Location = new System.Drawing.Point(0, 258);
            this.btnStopRead.Margin = new System.Windows.Forms.Padding(0);
            this.btnStopRead.Name = "btnStopRead";
            this.btnStopRead.Size = new System.Drawing.Size(200, 108);
            this.btnStopRead.TabIndex = 0;
            this.btnStopRead.Text = "Parar";
            this.btnStopRead.UseVisualStyleBackColor = false;
            this.btnStopRead.Click += new System.EventHandler(this.btnStopRead_Click);
            // 
            // btnStartRead
            // 
            this.btnStartRead.BackColor = System.Drawing.Color.ForestGreen;
            this.btnStartRead.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStartRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartRead.Location = new System.Drawing.Point(0, 150);
            this.btnStartRead.Margin = new System.Windows.Forms.Padding(0);
            this.btnStartRead.Name = "btnStartRead";
            this.btnStartRead.Size = new System.Drawing.Size(200, 108);
            this.btnStartRead.TabIndex = 1;
            this.btnStartRead.Text = "Começar";
            this.btnStartRead.UseVisualStyleBackColor = false;
            this.btnStartRead.Click += new System.EventHandler(this.btnStartRead_Click);
            // 
            // btnClean
            // 
            this.btnClean.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClean.Location = new System.Drawing.Point(0, 366);
            this.btnClean.Margin = new System.Windows.Forms.Padding(0);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(200, 108);
            this.btnClean.TabIndex = 2;
            this.btnClean.Text = "Apagar";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(3, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(194, 44);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Savar";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tlpResultMain
            // 
            this.tlpResultMain.ColumnCount = 1;
            this.tlpResultMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpResultMain.Controls.Add(this.cDados, 0, 0);
            this.tlpResultMain.Controls.Add(this.lblResult, 0, 1);
            this.tlpResultMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpResultMain.Location = new System.Drawing.Point(200, 0);
            this.tlpResultMain.Margin = new System.Windows.Forms.Padding(0);
            this.tlpResultMain.Name = "tlpResultMain";
            this.tlpResultMain.RowCount = 2;
            this.tlpResultMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpResultMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpResultMain.Size = new System.Drawing.Size(850, 575);
            this.tlpResultMain.TabIndex = 1;
            // 
            // cDados
            // 
            chartArea2.Name = "ChartArea1";
            this.cDados.ChartAreas.Add(chartArea2);
            this.cDados.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.cDados.Legends.Add(legend2);
            this.cDados.Location = new System.Drawing.Point(3, 3);
            this.cDados.Name = "cDados";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Temperatura";
            this.cDados.Series.Add(series2);
            this.cDados.Size = new System.Drawing.Size(844, 519);
            this.cDados.TabIndex = 2;
            this.cDados.Text = "Medição de Temperatura";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(3, 525);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(118, 25);
            this.lblResult.TabIndex = 3;
            this.lblResult.Text = "Resultado";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerRead
            // 
            this.timerRead.Interval = 700;
            this.timerRead.Tick += new System.EventHandler(this.timerRead_Tick);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // serialPort2
            // 
            this.serialPort2.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // fReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 575);
            this.Controls.Add(this.tlpReadMain);
            this.Name = "fReader";
            this.Text = "Leitura de parâmetros";
            this.tlpReadMain.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tlpResultMain.ResumeLayout(false);
            this.tlpResultMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cDados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpReadMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnStopRead;
        private System.Windows.Forms.Button btnStartRead;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Timer timerRead;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TableLayoutPanel tlpResultMain;
        private System.Windows.Forms.DataVisualization.Charting.Chart cDados;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Timer timer1;
        private System.IO.Ports.SerialPort serialPort2;
    }
}