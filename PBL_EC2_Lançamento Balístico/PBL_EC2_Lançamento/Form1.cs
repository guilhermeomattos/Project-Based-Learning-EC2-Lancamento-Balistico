using System.Windows.Forms.DataVisualization.Charting;

namespace PBL_EC2_Lançamento
{
    public partial class Form1 : Form
    {
        private List<DataPoint> trajetoriaPontos = new List<DataPoint>(); // Lista de pontos que representam a trajetória do projétil
        private int indiceAtual = 0; // Índice atual usado para percorrer a lista de pontos da trajetória
        private System.Windows.Forms.Timer animandoGrafico_tick = new System.Windows.Forms.Timer(); // Timer usado para animar o gráfico da trajetória
        private double x;
        private double y;
        private double menorAnguloPossivel;
        public Form1()
        {
            InitializeComponent();
            this.AcceptButton = btnMenorAngulo;          
        }

        double velocidadeInicial; //m/s^2
        double tempoX; // segundos
        double anguloGraus;
        bool anguloValido = false;
        double g = 9.8; //gravidade m/s^2
        double anguloRadianos;
        string movimento;

        //Entra com os valores da distância x e altura y
        private void btnMenorAngulo_Click(object sender, EventArgs e)
        {            
            //verifica se os espaços estão vazios
            if (string.IsNullOrWhiteSpace(txtX.Text) || string.IsNullOrWhiteSpace(txtY.Text))
            {
                MessageBox.Show("Por favor, insira valores válidos para as coordenadas");
                return;
            }
            //garantindo que os valores das coordenadas são numéricos e positivos
            if (!double.TryParse(txtX.Text, out double num1) || !double.TryParse(txtY.Text, out double num2))
            {
                MessageBox.Show("Por favor, insira um valor numérico válido.");
                return;
            }
            if ((Convert.ToDouble(txtX.Text)) < 0 || (Convert.ToDouble(txtY.Text)) < 0)
            {
                MessageBox.Show("Por favor, insira valores POSITIVOS para as coordenadas.");
                return;
            }

            x = Convert.ToDouble(txtX.Text);
            y = Convert.ToDouble(txtY.Text);
            //realiza o cálculo do menor ângulo
            menorAnguloPossivel = ((Math.Atan(y / x)) * 180 / Math.PI);

            //exibe na tela o ângulo que deve ser superado para atingir o alvo
            lblMenorAngulo.Text = ($"Ângulo a ser superado: {menorAnguloPossivel.ToString("F2")}°");
            lblMenorAngulo.Visible = true;

            btnEnviar.Visible = true;
            txtAngulo.Visible = true;
            lblGraus.Visible = true;
            lblTexto.Visible = true;

            this.AcceptButton = btnEnviar;
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            
            while (!anguloValido)
            {
                //verifica se os espaços estão vazios
                if (string.IsNullOrWhiteSpace(txtAngulo.Text) || !double.TryParse(txtAngulo.Text, out double num))
                {
                    MessageBox.Show("Por favor, insira um valor válido para do ângulo");
                    return;
                }
                else
                {
                    anguloGraus = Convert.ToDouble(txtAngulo.Text);
                    //Convertendo o angulo em graus para Radiano
                    anguloRadianos = (anguloGraus * Math.PI / 180); //angulo* Math.PI / 180: Isso converte o ângulo fornecido pelo usuário de graus para radianos
                }

                if (anguloGraus >= 90 || Math.Tan(anguloRadianos) < y / x)
                {
                    MessageBox.Show($"\nÂngulo inválido. O valor do ângulo deve ser maior que {menorAnguloPossivel.ToString("F2")}° e menor do 90° para atingir o alvo!.");
                    anguloValido = false;
                    return;
                }
                else if (Math.Tan(anguloRadianos) > y / x && anguloGraus < 90)
                {
                    anguloValido = true;

                    velocidadeInicial = CalcularVelocidadeInicial(x, y, anguloGraus);

                    // Calcular as componentes v0x e v0y
                    double v0x = velocidadeInicial * Math.Cos(anguloRadianos);
                    double v0y = velocidadeInicial * Math.Sin(anguloRadianos);

                    // tempo gasto para atingir o alvo
                    tempoX = x / v0x;

                    // componente da velocidade em Y, se + atingiu na subida, se - atingiu na descida
                    double vy = v0y - g * tempoX;

                    if (vy < 0)
                    {
                        movimento = "DESCENDENTE";
                        lblSentido.Text = ($"Atinge o alvo em movimento DESCENDENTE");
                        lblSentido.Visible = true;
                    }
                    else
                    {
                        movimento = "ASCENDENTE";
                        lblSentido.Text = ($"Atinge o alvo em movimento ASCENDENTE");
                        lblSentido.Visible = true;
                    }

                    lblTGasto.Text = $"Intervalo de tempo: {tempoX.ToString("F2")} s";
                    lblTGasto.Visible = true;

                    lblVInicial.Text = $"Velocidade Inicial: {velocidadeInicial.ToString("F2")} m/s";
                    lblVInicial.Visible = true;

                }


            }
            btnDados.Enabled = true;
            btnGrafico.Enabled = true;
        }

        //Função que calcula a velocidade inicial
        static double CalcularVelocidadeInicial(double x, double y, double anguloEmGraus)
        {
            double g = 9.8; // Aceleração da gravidade em m/s^2

            // Convertendo o ângulo de graus para radianos
            double anguloEmRadianos = anguloEmGraus * Math.PI / 180;

            // Calcular o termo dentro dos parênteses, divide a fórmula em termos
            double termo1 = -g * Math.Pow(x, 2);
            double termo2 = 1 + Math.Pow(Math.Tan(anguloEmRadianos), 2);
            double termo3 = 2 * (y - x * Math.Tan(anguloEmRadianos));

            // Calcular v0^2
            double v0Quadrado = termo1 * termo2 / termo3;

            // Retornar a raiz quadrada de v0^2 para obter v0
            double v0 = Math.Sqrt(v0Quadrado);

            return v0;
        }

        //BOTÃO PARA PLOTAR O GRÁFICO DA TRAJETÓRIA
        private void btnGrafico_Click(object sender, EventArgs e)
        {
            chart1.Visible = true;
            // Configurações do gráfico
            chart1.ChartAreas[0].AxisX.Title = "Distância (m)";
            chart1.ChartAreas[0].AxisY.Title = "Altura (m)";
            

            // Define intervalos  para os eixos
            chart1.ChartAreas[0].AxisX.Interval = 50; // Define intervalo para o eixo X
            chart1.ChartAreas[0].AxisY.Interval = 100; // Define intervalo para o eixo Y

            // Define a série de trajetórias
            Series trajetoriaSerie = new Series("Trajetória")
            {
                ChartType = SeriesChartType.Point, // Define o tipo de gráfico como dispersão
                Color = Color.Black,            
            };


            // Adiciona a série ao gráfico
            chart1.Series.Clear();
            chart1.Series.Add(trajetoriaSerie);

            // Adiciona os pontos da trajetória calculando o valor de Y para cada valor de X
            trajetoriaPontos.Clear();
            for (double xi = 5; xi <= x; xi += 5)
            {
                double yi = xi * Math.Tan(anguloRadianos) - (g * Math.Pow(xi, 2)) / (2 * Math.Pow(velocidadeInicial * Math.Cos(anguloRadianos), 2));
                trajetoriaPontos.Add(new DataPoint(xi, yi));
            }

            //Timer para animar o gráfico
            // Configuração do Timer
            animandoGrafico.Interval = 100; // Intervalo em milissegundos
            animandoGrafico.Tick += animandoGrafico_Tick;
            animandoGrafico.Start();

            //Define um ponto fixo no gráfico (alvo)
            Series pontoFixoSerie = new Series("Alvo")
            {
                ChartType = SeriesChartType.Point,
                Color = Color.Red, // Define a cor do ponto fixo
                MarkerStyle = MarkerStyle.Cross,
                MarkerSize = 14 // Ajusta o tamanho do marcador se necessário
            };

            pontoFixoSerie.Points.Add(new DataPoint(x, y));
            chart1.Series.Add(pontoFixoSerie);
        }

        // Evento do Timer
        private void animandoGrafico_Tick(object sender, EventArgs e)
        {
            if (indiceAtual < trajetoriaPontos.Count)
            {
                chart1.Series["Trajetória"].Points.Add(trajetoriaPontos[indiceAtual]);
                indiceAtual++;
            }
            else
            {
                animandoGrafico.Stop();
            }
        }

        //BOTÃO PARA ARMAZENAR OS DADOS EM ARQUIVO TXT
        private void btnDados_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("Dados_da_trajetoria.txt"))
            {
                writer.WriteLine($"Ângulo a ser superado: {menorAnguloPossivel.ToString("F2")}°\n" +
                                 $"Velocidade inicial: {velocidadeInicial.ToString("F2")}m/s\n" +                                
                                 $"Tempo para atingir o alvo: {tempoX.ToString("F2")}s\n" +
                                 $"Atinge o alvo em movimento: {movimento}\n");

                writer.WriteLine("\nValores de X e Y em metros em cada instante de tempo:\n");

                writer.WriteLine(" Tempo |  X  |  Y  ");
                // Calcular e armazenar os valores de x e y
                for (double t = 0; t <= tempoX; t += 0.1)
                {
                    double xi = velocidadeInicial * Math.Cos(anguloRadianos) * t;
                    double yi = velocidadeInicial * Math.Sin(anguloRadianos) * t - 0.5 * g * Math.Pow(t, 2);                  
                    writer.WriteLine($"{t:F2} | {xi:F2} | {yi:F2}");

                }
            }
            MessageBox.Show("Dados Armazenados com sucesso!");
        }
    }
}