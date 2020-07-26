using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PI_RFID_Arduino_WindowsFormsApp.Reader
{
    public partial class fReader : Form
    {
        #region variables
        List<decimal> temp = new List<decimal>();
        decimal temperatura = new decimal();
        int tempo = 0;
        string RxString;
        bool reset = false;
        string Status = String.Empty;
        #endregion
        #region initialize
        public fReader(SerialPort serialPort)
        {
            InitializeComponent();

            BuildAnalyzeGraphic();
            serialPort2 = serialPort;
            //serialPort2.BaudRate = 9600;
            //serialPort2.Parity = Parity.None;
            //serialPort2.StopBits = StopBits.One;
            //serialPort2.DataBits = 8;
            //serialPort2.Handshake = Handshake.None;
            //serialPort2.RtsEnable = true;
            this.MaximizeBox = false;
        }
        private void btnStartRead_Click(object sender, EventArgs e)
        {
            Status = "1";
            if (reset)
            {
                serialPort2.Open();
            }
            if (serialPort2.IsOpen)
            {
                try
                {
                    serialPort2.Write(Status);
                    lblResult.Text = "Esperando dados da comunicação serial";
                }
                catch (Exception error)
                {
                    MessageBox.Show("Erro na conexão serial" + error, "Informação do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }

            }

            serialPort2.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived);
            btnClean.Enabled = false;
        }
        #endregion
        #region serial communication 
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            RxString = serialPort2.ReadExisting();
            tempo++;
            this.Invoke(new EventHandler(trataDadoRecebido));

        }
        private void trataDadoRecebido(object sender, EventArgs e)
        {
            string[] collect;
            collect = Regex.Split(RxString, "\r\n", RegexOptions.IgnoreCase,
                                                 TimeSpan.FromMilliseconds(500));
            foreach (var item in collect)
            {
                if (!String.IsNullOrEmpty(item))
                {
                    temperatura = (Convert.ToDecimal(item));
                    temp.Add(temperatura);
                }
            }
            PlotResultGraphic();
            lblResult.Text = "";
            if ((temp.Count % 60) == 0 && (temp.Count > 60))
            {
                calculaTemp();
            }

        }
        #endregion
        #region button click 


        private void btnClean_Click(object sender, EventArgs e)
        {
            temp.Clear();
            tempo = 0;
            foreach (var series in cDados.Series)
            {
                series.Points.Clear();
            }



        }

        private void btnStopRead_Click(object sender, EventArgs e)
        {
            Status = "0";
            btnClean.Enabled = true;
            if (serialPort2.IsOpen)
            {
                try
                {
                    serialPort2.Write(Status);

                    lblResult.Text = "";

                }
                catch (Exception error)
                {
                    MessageBox.Show("Erro na conexão serial" + error, "Informação do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }

            }

        }
        #region build analyze graphic
        private void BuildAnalyzeGraphic()
        {
            Title title1 = new Title();
            Legend legend1 = new Legend();
            Series series1 = new Series();

            cDados.BackColor = System.Drawing.Color.LightGray;
            //cDados.DataBindings.Add(new System.Windows.Forms.Binding("DataSource", this.dadosBindingSource, "tempo", true));
            cDados.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            cDados.Location = new System.Drawing.Point(0, 50);
            cDados.Margin = new System.Windows.Forms.Padding(0);
            cDados.Name = "cDados";
            cDados.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Legend = "Temperatura";
            series1.MarkerBorderColor = System.Drawing.Color.Transparent;
            series1.MarkerColor = System.Drawing.Color.Black;
            series1.MarkerSize = 2;
            series1.Name = "Temperatura";
            cDados.Size = new System.Drawing.Size(786, 348);
            cDados.TabIndex = 1;
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Variação de Temperatura";
            cDados.Titles.Add(title1);

        }
        #endregion
        #region form close action 


        private void fReader_FormClosed(object sender, FormClosedEventArgs e)
        {
            cDados.Series.Clear();
            cDados.ChartAreas.Clear();
            cDados.Titles.Clear();
            cDados.DataBindings.Clear();
            cDados.Legends.Clear();
        }
        #endregion
        private void PlotResultGraphic()
        {
            if (temp.Count() > 0)
            {
                try
                {
                    for (int i = 0; i < temp.Count(); i = i + 1)
                    {

                        cDados.Series["Temperatura"].Points.AddXY(tempo, temperatura);

                    }

                }
                catch (Exception error)
                {
                    MessageBox.Show("Erro na conexão serial" + error, "Informação do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }

                //cResult.ChartAreas[0].AxisX.MajorGrid.Interval = a;
                //cResult.ChartAreas[0].AxisY.MajorGrid.Interval = b;
            }

        }
        #endregion

        #region save figure button
        private void saveFigureButton_Click()
        {
            SaveFileDialog _saveFigure = new SaveFileDialog();
            _saveFigure.Filter = "JPG Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
            _saveFigure.Title = "Variação de Temperatura";
            _saveFigure.ShowDialog();
            if (_saveFigure.FileName != "")
            {
                System.IO.FileStream _path = (System.IO.FileStream)_saveFigure.OpenFile();
                switch (_saveFigure.FilterIndex)
                {
                    case 1:
                        cDados.SaveImage(_path, ChartImageFormat.Jpeg);
                        break;

                    case 2:
                        cDados.SaveImage(_path, ChartImageFormat.Bmp);
                        break;

                    case 3:
                        cDados.SaveImage(_path, ChartImageFormat.Gif);
                        break;
                }

                _path.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveFigureButton_Click();
        }
        #endregion

        private void timerRead_Tick(object sender, EventArgs e)
        {

        }

        //private void timerteste_Tick(object sender, EventArgs e)
        //{
        //    temperatura = tempo++;
        //    temp.Add(temperatura);
        //}
        private void calculaTemp()
        {
            int contador = 0;
            for (int i = 0; i < temp.Count(); i++)
            {
                if (temp[i] > 25)
                {
                    int cont = 0;
                    for (int j = i; j < temp.Count(); j++)
                    {
                        if (temp[j] > 25)
                        {
                            cont++;
                        }
                        if (cont > 30)
                        {
                            break;
                        }
                    }
                    contador = cont;
                }
                if (contador >= 30)
                {

                    break;
                }
            }
            if (contador >= 30)
            {
                lblResult.Text = "A temperatura ficou acima de 25° por 30 minutos";
            }
            else
            {
                lblResult.Text = "A temperatura não ficou acima de 25° por 30 minutos";
            }


        }
    }
}
