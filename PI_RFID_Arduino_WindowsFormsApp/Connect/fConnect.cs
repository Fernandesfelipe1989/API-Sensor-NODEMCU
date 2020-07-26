using PI_RFID_Arduino_WindowsFormsApp.Reader;
using System;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;

namespace PI_RFID_Arduino_WindowsFormsApp
{
    public partial class fConnect : Form
    {
        #region variable

        bool connect = false;
        #endregion
        public fConnect()
        {
            InitializeComponent();
            timerCom.Enabled = true;
            this.MaximizeBox = false;
            lblStatusConnect.Text = "Desconectado";
            lblStatusConnect.BackColor = Color.Red;
        }
        #region continuos read of serial port


        private void atualizaListaComs()
        {
            int i = 0;
            bool qntDifrente = false;
            if (cbSerial.Items.Count == SerialPort.GetPortNames().Length)
            {
                foreach (var item in SerialPort.GetPortNames())
                {
                    if (cbSerial.Items[i++].Equals(item) == false)
                    {
                        qntDifrente = true;

                    }
                }
            }
            else
            {
                qntDifrente = true;
            }
            if (!qntDifrente)
            {
                return;
            }
            cbSerial.Items.Clear();
            foreach (var serial in SerialPort.GetPortNames())
            {
                cbSerial.Items.Add(serial);
            }
            cbSerial.SelectedIndex = 0;
        }

        private void timerCom_Tick(object sender, EventArgs e)
        {
            atualizaListaComs();
        }
        #endregion
        #region button click 


        private void btnConnect_Click(object sender, EventArgs e)
        {
            timerCom.Enabled = false;
            this.Cursor = Cursors.WaitCursor;
            if (!serialPort1.IsOpen)
            {
                try
                {

                    serialPort1.PortName = cbSerial.Items[cbSerial.SelectedIndex].ToString();
                    serialPort1.Open();
                    btnConnect.Text = "Desconectar";
                    lblStatusConnect.Text = "Conectado";
                    lblStatusConnect.BackColor = Color.Green;
                    cbSerial.Enabled = false;
                    connect = true;
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro na conexão serial" + erro, "Informação do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblStatusConnect.Text = "Desconectado";
                    lblStatusConnect.BackColor = Color.DarkRed;
                    return;
                }
            }
            else
            {
                try
                {
                    serialPort1.Close();
                    cbSerial.Enabled = true;
                    lblStatusConnect.Text = "Desconectado";
                    lblStatusConnect.BackColor = Color.DarkRed;
                    btnConnect.Text = "Conectar";
                    connect = false;
                }
                catch (Exception error)
                {
                    MessageBox.Show("Erro na conexão serial" + error, "Informação do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            this.Cursor = Cursors.Default;
        }
        #endregion

        private void btnSend_Click(object sender, EventArgs e)
        {

        }
        #region form close action 


        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
        }
        #endregion

        private void btnRead_Click(object sender, EventArgs e)
        {
            if (connect)
            {
                fReader fReader = new fReader(serialPort1);
                fReader.ShowDialog();

            }
            else
            {
                MessageBox.Show("Sem conexão com uma placa", "Informação do sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
