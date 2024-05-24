namespace PBL_EC2_Lançamento
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblTexto = new Label();
            txtAngulo = new TextBox();
            btnEnviar = new Button();
            btnGrafico = new Button();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            lblSentido = new Label();
            lblMenorAngulo = new Label();
            lblTGasto = new Label();
            lblVInicial = new Label();
            lblValorX = new Label();
            lblValorY = new Label();
            txtX = new TextBox();
            txtY = new TextBox();
            btnMenorAngulo = new Button();
            animandoGrafico = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            btnDados = new Button();
            label2 = new Label();
            label3 = new Label();
            lblGraus = new Label();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // lblTexto
            // 
            lblTexto.AutoSize = true;
            lblTexto.BackColor = Color.Transparent;
            lblTexto.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblTexto.ForeColor = SystemColors.ControlLightLight;
            lblTexto.Location = new Point(70, 279);
            lblTexto.Name = "lblTexto";
            lblTexto.Size = new Size(199, 32);
            lblTexto.TabIndex = 0;
            lblTexto.Text = "Digite o ângulo:";
            lblTexto.Visible = false;
            // 
            // txtAngulo
            // 
            txtAngulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtAngulo.Location = new Point(275, 279);
            txtAngulo.Name = "txtAngulo";
            txtAngulo.Size = new Size(100, 35);
            txtAngulo.TabIndex = 4;
            txtAngulo.Visible = false;
            // 
            // btnEnviar
            // 
            btnEnviar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnEnviar.Location = new Point(395, 279);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(100, 35);
            btnEnviar.TabIndex = 5;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Visible = false;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // btnGrafico
            // 
            btnGrafico.Enabled = false;
            btnGrafico.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnGrafico.Location = new Point(875, 737);
            btnGrafico.Name = "btnGrafico";
            btnGrafico.Size = new Size(162, 76);
            btnGrafico.TabIndex = 6;
            btnGrafico.Text = "Gráfico";
            btnGrafico.UseVisualStyleBackColor = true;
            btnGrafico.Click += btnGrafico_Click;
            // 
            // chart1
            // 
            chart1.BackSecondaryColor = Color.Transparent;
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(49, 448);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(799, 456);
            chart1.TabIndex = 3;
            chart1.Text = "Trajetória";
            chart1.Visible = false;
            // 
            // lblSentido
            // 
            lblSentido.AutoSize = true;
            lblSentido.BackColor = Color.FromArgb(64, 64, 64);
            lblSentido.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblSentido.ForeColor = SystemColors.ControlLightLight;
            lblSentido.Location = new Point(524, 319);
            lblSentido.Name = "lblSentido";
            lblSentido.Size = new Size(101, 32);
            lblSentido.TabIndex = 0;
            lblSentido.Text = "Sentido";
            lblSentido.Visible = false;
            // 
            // lblMenorAngulo
            // 
            lblMenorAngulo.AutoSize = true;
            lblMenorAngulo.BackColor = Color.FromArgb(64, 64, 64);
            lblMenorAngulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblMenorAngulo.ForeColor = SystemColors.ControlLightLight;
            lblMenorAngulo.Location = new Point(524, 194);
            lblMenorAngulo.Name = "lblMenorAngulo";
            lblMenorAngulo.Size = new Size(177, 32);
            lblMenorAngulo.TabIndex = 0;
            lblMenorAngulo.Text = "Menor ângulo";
            lblMenorAngulo.Visible = false;
            // 
            // lblTGasto
            // 
            lblTGasto.AutoSize = true;
            lblTGasto.BackColor = Color.FromArgb(64, 64, 64);
            lblTGasto.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblTGasto.ForeColor = SystemColors.ControlLightLight;
            lblTGasto.Location = new Point(524, 277);
            lblTGasto.Name = "lblTGasto";
            lblTGasto.Size = new Size(163, 32);
            lblTGasto.TabIndex = 0;
            lblTGasto.Text = "Tempo Gasto";
            lblTGasto.Visible = false;
            // 
            // lblVInicial
            // 
            lblVInicial.AutoSize = true;
            lblVInicial.BackColor = Color.FromArgb(64, 64, 64);
            lblVInicial.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblVInicial.ForeColor = SystemColors.ControlLightLight;
            lblVInicial.Location = new Point(524, 235);
            lblVInicial.Name = "lblVInicial";
            lblVInicial.Size = new Size(213, 32);
            lblVInicial.TabIndex = 0;
            lblVInicial.Text = "Velocidade inicial";
            lblVInicial.Visible = false;
            // 
            // lblValorX
            // 
            lblValorX.AutoSize = true;
            lblValorX.BackColor = Color.Transparent;
            lblValorX.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblValorX.ForeColor = SystemColors.ControlLightLight;
            lblValorX.Location = new Point(47, 194);
            lblValorX.Name = "lblValorX";
            lblValorX.Size = new Size(222, 32);
            lblValorX.TabIndex = 4;
            lblValorX.Text = "Distância do Alvo:";
            // 
            // lblValorY
            // 
            lblValorY.AutoSize = true;
            lblValorY.BackColor = Color.Transparent;
            lblValorY.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblValorY.ForeColor = SystemColors.ControlLightLight;
            lblValorY.Location = new Point(81, 230);
            lblValorY.Name = "lblValorY";
            lblValorY.Size = new Size(188, 32);
            lblValorY.TabIndex = 4;
            lblValorY.Text = "Altura do Alvo:";
            // 
            // txtX
            // 
            txtX.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtX.Location = new Point(275, 194);
            txtX.Name = "txtX";
            txtX.Size = new Size(100, 35);
            txtX.TabIndex = 1;
            // 
            // txtY
            // 
            txtY.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtY.Location = new Point(275, 232);
            txtY.Name = "txtY";
            txtY.Size = new Size(100, 35);
            txtY.TabIndex = 2;
            // 
            // btnMenorAngulo
            // 
            btnMenorAngulo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnMenorAngulo.Location = new Point(395, 194);
            btnMenorAngulo.Name = "btnMenorAngulo";
            btnMenorAngulo.Size = new Size(100, 73);
            btnMenorAngulo.TabIndex = 3;
            btnMenorAngulo.Text = "Calcular Ângulo";
            btnMenorAngulo.UseVisualStyleBackColor = true;
            btnMenorAngulo.Click += btnMenorAngulo_Click;
            // 
            // animandoGrafico
            // 
            animandoGrafico.Tick += animandoGrafico_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Impact", 36F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(310, 49);
            label1.Name = "label1";
            label1.Size = new Size(452, 60);
            label1.TabIndex = 7;
            label1.Text = "Lançamento Balístico";
            // 
            // btnDados
            // 
            btnDados.Enabled = false;
            btnDados.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDados.Location = new Point(875, 828);
            btnDados.Name = "btnDados";
            btnDados.Size = new Size(162, 75);
            btnDados.TabIndex = 8;
            btnDados.Text = "Armazenar Dados";
            btnDados.UseVisualStyleBackColor = true;
            btnDados.Click += btnDados_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Window;
            label2.Location = new Point(354, 211);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 9;
            label2.Text = "m";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Window;
            label3.Location = new Point(354, 249);
            label3.Name = "label3";
            label3.Size = new Size(18, 15);
            label3.TabIndex = 9;
            label3.Text = "m";
            // 
            // lblGraus
            // 
            lblGraus.AutoSize = true;
            lblGraus.BackColor = SystemColors.Window;
            lblGraus.Location = new Point(337, 296);
            lblGraus.Name = "lblGraus";
            lblGraus.Size = new Size(36, 15);
            lblGraus.TabIndex = 9;
            lblGraus.Text = "graus";
            lblGraus.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1064, 961);
            Controls.Add(lblGraus);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnDados);
            Controls.Add(label1);
            Controls.Add(btnMenorAngulo);
            Controls.Add(txtY);
            Controls.Add(txtX);
            Controls.Add(lblValorY);
            Controls.Add(lblValorX);
            Controls.Add(chart1);
            Controls.Add(btnGrafico);
            Controls.Add(btnEnviar);
            Controls.Add(txtAngulo);
            Controls.Add(lblVInicial);
            Controls.Add(lblTGasto);
            Controls.Add(lblMenorAngulo);
            Controls.Add(lblSentido);
            Controls.Add(lblTexto);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PBL_Lançamento";
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTexto;
        private TextBox txtAngulo;
        private Button btnEnviar;
        private Button btnGrafico;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Label lblSentido;
        private Label lblMenorAngulo;
        private Label lblTGasto;
        private Label lblVInicial;
        private Label lblValorX;
        private Label lblValorY;
        private TextBox txtX;
        private TextBox txtY;
        private Button btnMenorAngulo;
        private System.Windows.Forms.Timer animandoGrafico;
        private Label label1;
        private Button btnDados;
        private Label label2;
        private Label label3;
        private Label lblGraus;
    }
}