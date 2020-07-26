namespace PI_RFID_Arduino_WindowsFormsApp
{
    partial class fConnect
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnConnect = new System.Windows.Forms.Button();
            this.cbSerial = new System.Windows.Forms.ComboBox();
            this.timerCom = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.tlpConnectMain = new System.Windows.Forms.TableLayoutPanel();
            this.tlpButtonConnect = new System.Windows.Forms.TableLayoutPanel();
            this.tlpButtonLocation = new System.Windows.Forms.TableLayoutPanel();
            this.lblStatusConnect = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pbConnectArduino = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tlpButtonRead = new System.Windows.Forms.TableLayoutPanel();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.tlpConnectMain.SuspendLayout();
            this.tlpButtonConnect.SuspendLayout();
            this.tlpButtonLocation.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbConnectArduino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tlpButtonRead.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnConnect.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnConnect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.Location = new System.Drawing.Point(3, 50);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(537, 69);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Conectar";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // cbSerial
            // 
            this.cbSerial.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbSerial.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cbSerial.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSerial.FormattingEnabled = true;
            this.cbSerial.Location = new System.Drawing.Point(617, 68);
            this.cbSerial.Name = "cbSerial";
            this.cbSerial.Size = new System.Drawing.Size(396, 33);
            this.cbSerial.TabIndex = 1;
            // 
            // timerCom
            // 
            this.timerCom.Interval = 1000;
            this.timerCom.Tick += new System.EventHandler(this.timerCom_Tick);
            // 
            // tlpConnectMain
            // 
            this.tlpConnectMain.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tlpConnectMain.ColumnCount = 1;
            this.tlpConnectMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpConnectMain.Controls.Add(this.tlpButtonConnect, 0, 1);
            this.tlpConnectMain.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tlpConnectMain.Location = new System.Drawing.Point(0, 0);
            this.tlpConnectMain.Margin = new System.Windows.Forms.Padding(0);
            this.tlpConnectMain.Name = "tlpConnectMain";
            this.tlpConnectMain.RowCount = 2;
            this.tlpConnectMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 350F));
            this.tlpConnectMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpConnectMain.Size = new System.Drawing.Size(1087, 595);
            this.tlpConnectMain.TabIndex = 2;
            // 
            // tlpButtonConnect
            // 
            this.tlpButtonConnect.ColumnCount = 1;
            this.tlpButtonConnect.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpButtonConnect.Controls.Add(this.tlpButtonLocation, 0, 0);
            this.tlpButtonConnect.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tlpButtonConnect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpButtonConnect.Location = new System.Drawing.Point(0, 350);
            this.tlpButtonConnect.Margin = new System.Windows.Forms.Padding(0);
            this.tlpButtonConnect.Name = "tlpButtonConnect";
            this.tlpButtonConnect.RowCount = 2;
            this.tlpButtonConnect.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpButtonConnect.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpButtonConnect.Size = new System.Drawing.Size(1087, 245);
            this.tlpButtonConnect.TabIndex = 0;
            // 
            // tlpButtonLocation
            // 
            this.tlpButtonLocation.ColumnCount = 2;
            this.tlpButtonLocation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpButtonLocation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpButtonLocation.Controls.Add(this.btnConnect, 0, 1);
            this.tlpButtonLocation.Controls.Add(this.cbSerial, 1, 1);
            this.tlpButtonLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpButtonLocation.Location = new System.Drawing.Point(0, 0);
            this.tlpButtonLocation.Margin = new System.Windows.Forms.Padding(0);
            this.tlpButtonLocation.Name = "tlpButtonLocation";
            this.tlpButtonLocation.RowCount = 2;
            this.tlpButtonLocation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpButtonLocation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tlpButtonLocation.Size = new System.Drawing.Size(1087, 122);
            this.tlpButtonLocation.TabIndex = 0;
            // 
            // lblStatusConnect
            // 
            this.lblStatusConnect.AutoSize = true;
            this.lblStatusConnect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStatusConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusConnect.Location = new System.Drawing.Point(128, 10);
            this.lblStatusConnect.Name = "lblStatusConnect";
            this.lblStatusConnect.Size = new System.Drawing.Size(831, 39);
            this.lblStatusConnect.TabIndex = 2;
            this.lblStatusConnect.Text = "Oi";
            this.lblStatusConnect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pbConnectArduino, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1081, 344);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // pbConnectArduino
            // 
            this.pbConnectArduino.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbConnectArduino.Image = global::PI_RFID_Arduino_WindowsFormsApp.Properties.Resources.Arduino;
            this.pbConnectArduino.InitialImage = null;
            this.pbConnectArduino.Location = new System.Drawing.Point(120, 63);
            this.pbConnectArduino.Margin = new System.Windows.Forms.Padding(0);
            this.pbConnectArduino.Name = "pbConnectArduino";
            this.pbConnectArduino.Size = new System.Drawing.Size(300, 217);
            this.pbConnectArduino.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbConnectArduino.TabIndex = 2;
            this.pbConnectArduino.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::PI_RFID_Arduino_WindowsFormsApp.Properties.Resources.raspberry;
            this.pictureBox1.Location = new System.Drawing.Point(660, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tableLayoutPanel2.Controls.Add(this.lblStatusConnect, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.tlpButtonRead, 1, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 122);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1087, 123);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // tlpButtonRead
            // 
            this.tlpButtonRead.ColumnCount = 2;
            this.tlpButtonRead.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpButtonRead.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpButtonRead.Controls.Add(this.btnRead, 0, 0);
            this.tlpButtonRead.Controls.Add(this.btnAbout, 1, 0);
            this.tlpButtonRead.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpButtonRead.Location = new System.Drawing.Point(125, 74);
            this.tlpButtonRead.Margin = new System.Windows.Forms.Padding(0);
            this.tlpButtonRead.Name = "tlpButtonRead";
            this.tlpButtonRead.RowCount = 1;
            this.tlpButtonRead.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpButtonRead.Size = new System.Drawing.Size(837, 39);
            this.tlpButtonRead.TabIndex = 3;
            // 
            // btnRead
            // 
            this.btnRead.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRead.Location = new System.Drawing.Point(0, 0);
            this.btnRead.Margin = new System.Windows.Forms.Padding(0);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(418, 39);
            this.btnRead.TabIndex = 0;
            this.btnRead.Text = "Leitura";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.Location = new System.Drawing.Point(418, 0);
            this.btnAbout.Margin = new System.Windows.Forms.Padding(0);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(419, 39);
            this.btnAbout.TabIndex = 1;
            this.btnAbout.Text = "Informações";
            this.btnAbout.UseVisualStyleBackColor = true;
            // 
            // fConnect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1087, 595);
            this.Controls.Add(this.tlpConnectMain);
            this.Name = "fConnect";
            this.Text = "Painel de Controle";
            this.tlpConnectMain.ResumeLayout(false);
            this.tlpButtonConnect.ResumeLayout(false);
            this.tlpButtonLocation.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbConnectArduino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tlpButtonRead.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ComboBox cbSerial;
        private System.Windows.Forms.Timer timerCom;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TableLayoutPanel tlpConnectMain;
        private System.Windows.Forms.TableLayoutPanel tlpButtonConnect;
        private System.Windows.Forms.TableLayoutPanel tlpButtonLocation;
        private System.Windows.Forms.Label lblStatusConnect;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pbConnectArduino;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tlpButtonRead;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnAbout;
    }
}

