namespace Loto_mais_fácil
{
    public partial class Form1 : Form
    {
        int qtEscolhas = 0;
        List<int> numerosEscolhidos = new List<int>();
        List<int> numerosSorteados = new List<int>();
        List<string> historicoRodadas = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        void atualizarLabelEscolhidos()
        {
            listesc.Items.Clear();

            foreach (int num in numerosEscolhidos)
            {
                listesc.Items.Add(num);
            }
        }


        private void b1_Click(object sender, EventArgs e)
        {
            b1.Enabled = false;
            numerosEscolhidos.Add(1);
            qtEscolhas++;
            atualizarLabelEscolhidos();
            verifica_jogada();
        }

        void verifica_jogada()
        {
            if (qtEscolhas == 25)
            {
                b1.Enabled = false;
                b2.Enabled = false;
                b3.Enabled = false;
                b4.Enabled = false;
                b5.Enabled = false;
                b6.Enabled = false;
                b7.Enabled = false;
                b8.Enabled = false;
                b9.Enabled = false;
                b10.Enabled = false;
                b11.Enabled = false;
                b12.Enabled = false;
                b13.Enabled = false;
                b14.Enabled = false;
                b15.Enabled = false;
                b16.Enabled = false;
                b17.Enabled = false;
                b18.Enabled = false;
                b19.Enabled = false;
                b20.Enabled = false;
                b21.Enabled = false;
                b22.Enabled = false;
                b23.Enabled = false;
                b24.Enabled = false;
                b25.Enabled = false;
                b26.Enabled = false;
                b27.Enabled = false;
                b28.Enabled = false;
                b29.Enabled = false;
                b30.Enabled = false;
                b31.Enabled = false;
                b32.Enabled = false;
                b33.Enabled = false;
                b34.Enabled = false;
                b35.Enabled = false;
                b36.Enabled = false;
                b37.Enabled = false;
                b38.Enabled = false;
                b39.Enabled = false;
                b40.Enabled = false;
                b41.Enabled = false;
                b42.Enabled = false;
                b43.Enabled = false;
                b44.Enabled = false;
                b45.Enabled = false;
                b46.Enabled = false;
                b47.Enabled = false;
                b48.Enabled = false;
                b49.Enabled = false;
                b50.Enabled = false;
                MessageBox.Show("Você ja fez suas escolhas!!!!!!!");
            }
        }

        private void b2_Click(object sender, EventArgs e)
        {
            b2.Enabled = false;
            numerosEscolhidos.Add(2);
            qtEscolhas++;
            atualizarLabelEscolhidos();
            verifica_jogada();
        }

        private void b3_Click(object sender, EventArgs e)
        {
            b3.Enabled = false;
            numerosEscolhidos.Add(3);
            qtEscolhas++;
            atualizarLabelEscolhidos();
            verifica_jogada();
        }

        private void b4_Click(object sender, EventArgs e)
        {
            b4.Enabled = false;
            numerosEscolhidos.Add(4);
            qtEscolhas++;
            atualizarLabelEscolhidos();
            verifica_jogada();
        }

        private void b5_Click(object sender, EventArgs e)
        {
            b5.Enabled = false;
            numerosEscolhidos.Add(5);
            qtEscolhas++;
            atualizarLabelEscolhidos();
            verifica_jogada();
        }

        private void b6_Click(object sender, EventArgs e)
        {
            b6.Enabled = false;
            numerosEscolhidos.Add(6);
            qtEscolhas++;
            atualizarLabelEscolhidos();
            verifica_jogada();
        }

        private void b7_Click(object sender, EventArgs e)
        {
            b7.Enabled = false;
            numerosEscolhidos.Add(7);
            qtEscolhas++;
            atualizarLabelEscolhidos();
            verifica_jogada();
        }

        private void b8_Click(object sender, EventArgs e)
        {
            b8.Enabled = false;
            numerosEscolhidos.Add(8);
            qtEscolhas++;
            atualizarLabelEscolhidos();
            verifica_jogada();
        }

        private void b9_Click(object sender, EventArgs e)
        {
            b9.Enabled = false;
            numerosEscolhidos.Add(9);
            qtEscolhas++;
            atualizarLabelEscolhidos();
            verifica_jogada();
        }

        private void b10_Click(object sender, EventArgs e)
        {
            b10.Enabled = false;
            numerosEscolhidos.Add(10);
            qtEscolhas++;
            atualizarLabelEscolhidos();
            verifica_jogada();
        }

        private void b11_Click(object sender, EventArgs e)
        {
            b11.Enabled = false;
            numerosEscolhidos.Add(11);
            qtEscolhas++;
            atualizarLabelEscolhidos();
            verifica_jogada();
        }

        private void b12_Click(object sender, EventArgs e)
        {
            b12.Enabled = false;
            numerosEscolhidos.Add(12);
            qtEscolhas++;
            atualizarLabelEscolhidos();
            verifica_jogada();
        }

        private void b13_Click(object sender, EventArgs e)
        {
            b13.Enabled = false;
            numerosEscolhidos.Add(13);
            qtEscolhas++;
            atualizarLabelEscolhidos();
            verifica_jogada();
        }

        private void b14_Click(object sender, EventArgs e)
        {
            b14.Enabled = false;
            numerosEscolhidos.Add(14);
            qtEscolhas++;
            atualizarLabelEscolhidos();
            verifica_jogada();
        }

        private void b15_Click(object sender, EventArgs e)
        {
            b15.Enabled = false;
            numerosEscolhidos.Add(15);
            qtEscolhas++;
            atualizarLabelEscolhidos();
            verifica_jogada();
        }

        private void b16_Click(object sender, EventArgs e)
        {
            b16.Enabled = false;
            numerosEscolhidos.Add(16);
            qtEscolhas++;
            atualizarLabelEscolhidos();
            verifica_jogada();
        }

        private void b17_Click(object sender, EventArgs e)
        {
            b17.Enabled = false;
            numerosEscolhidos.Add(17);
            qtEscolhas++;
            atualizarLabelEscolhidos();
            verifica_jogada();
        }

        private void b18_Click(object sender, EventArgs e)
        {
            b18.Enabled = false;
            numerosEscolhidos.Add(18);
            qtEscolhas++;
            atualizarLabelEscolhidos();
            verifica_jogada();
        }

        private void b19_Click(object sender, EventArgs e)
        {
            b19.Enabled = false;
            numerosEscolhidos.Add(19);
            qtEscolhas++;
            atualizarLabelEscolhidos();
            verifica_jogada();
        }

        private void b20_Click(object sender, EventArgs e)
        {
            b20.Enabled = false;
            numerosEscolhidos.Add(20);
            qtEscolhas++;
            atualizarLabelEscolhidos();
            verifica_jogada();
        }

        private void b21_Click(object sender, EventArgs e)
        {
            b21.Enabled = false;
            numerosEscolhidos.Add(21);
            qtEscolhas++;
            atualizarLabelEscolhidos();
            verifica_jogada();
        }

        private void b22_Click(object sender, EventArgs e)
        {
            b22.Enabled = false;
            numerosEscolhidos.Add(22);
            qtEscolhas++;
            atualizarLabelEscolhidos();
            verifica_jogada();
        }

        private void b23_Click(object sender, EventArgs e)
        {
            b23.Enabled = false;
            numerosEscolhidos.Add(23);
            qtEscolhas++;
            atualizarLabelEscolhidos();
            verifica_jogada();
        }

        private void b24_Click(object sender, EventArgs e)
        {
            b24.Enabled = false;
            numerosEscolhidos.Add(24);
            qtEscolhas++;
            atualizarLabelEscolhidos();
            verifica_jogada();
        }

        private void b25_Click(object sender, EventArgs e)
        {
            b25.Enabled = false;
            numerosEscolhidos.Add(25);
            qtEscolhas++;
            atualizarLabelEscolhidos();
            verifica_jogada();
        }

        private void b26_Click(object sender, EventArgs e)
        {
            b26.Enabled = false;
            numerosEscolhidos.Add(26);
            qtEscolhas++;
            atualizarLabelEscolhidos();
            verifica_jogada();
        }

        private void b27_Click(object sender, EventArgs e)
        {
            b27.Enabled = false;
            numerosEscolhidos.Add(27);
            qtEscolhas++;
            atualizarLabelEscolhidos();
            verifica_jogada();
        }

        private void b28_Click(object sender, EventArgs e)
        {
            b28.Enabled = false;
            numerosEscolhidos.Add(28);
            qtEscolhas++;
            atualizarLabelEscolhidos();
            verifica_jogada();
        }

        private void b29_Click(object sender, EventArgs e)
        {
            b29.Enabled = false;
            numerosEscolhidos.Add(29);
            qtEscolhas++;
            atualizarLabelEscolhidos();
            verifica_jogada();
        }

        private void b30_Click(object sender, EventArgs e)
        {
            b30.Enabled = false;
            numerosEscolhidos.Add(30);
            qtEscolhas++;
            atualizarLabelEscolhidos();
            verifica_jogada();
        }

        private void b31_Click(object sender, EventArgs e)
        {
            b31.Enabled = false;
            numerosEscolhidos.Add(31);
            qtEscolhas++;
            atualizarLabelEscolhidos();
            verifica_jogada();
        }

        private void b32_Click(object sender, EventArgs e)
        {
            b32.Enabled = false;
            numerosEscolhidos.Add(32);
            qtEscolhas++;
            atualizarLabelEscolhidos();
            verifica_jogada();
        }

        private void b33_Click(object sender, EventArgs e)
        {
            b33.Enabled = false;
            numerosEscolhidos.Add(33);
            qtEscolhas++;
            atualizarLabelEscolhidos();
            verifica_jogada();
        }

        private void b34_Click(object sender, EventArgs e)
        {
            b34.Enabled = false;
            numerosEscolhidos.Add(34);
            qtEscolhas++;
            atualizarLabelEscolhidos();
            verifica_jogada();
        }

        private void b35_Click(object sender, EventArgs e)
        {
            b35.Enabled = false;
            numerosEscolhidos.Add(35);
            qtEscolhas++;
            atualizarLabelEscolhidos();
            verifica_jogada();
        }

        private void b36_Click(object sender, EventArgs e)
        {
            b36.Enabled = false;
            numerosEscolhidos.Add(36);
            qtEscolhas++;
            atualizarLabelEscolhidos();
            verifica_jogada();
        }

        private void b37_Click(object sender, EventArgs e)
        {
            b37.Enabled = false;
            numerosEscolhidos.Add(37);
            qtEscolhas++;
            atualizarLabelEscolhidos();
            verifica_jogada();
        }

        private void b38_Click(object sender, EventArgs e)
        {
            b38.Enabled = false;
            numerosEscolhidos.Add(38);
            qtEscolhas++;
            atualizarLabelEscolhidos();
            verifica_jogada();
        }

        private void b39_Click(object sender, EventArgs e)
        {
            b39.Enabled = false;
            numerosEscolhidos.Add(39);
            qtEscolhas++;
            atualizarLabelEscolhidos();
            verifica_jogada();
        }

        private void b40_Click(object sender, EventArgs e)
        {
            b40.Enabled = false;
            numerosEscolhidos.Add(40);
            qtEscolhas++;
            atualizarLabelEscolhidos();
            verifica_jogada();
        }

        private void b41_Click(object sender, EventArgs e)
        {
            b41.Enabled = false;
            numerosEscolhidos.Add(41);
            qtEscolhas++;
            atualizarLabelEscolhidos();
            verifica_jogada();
        }

        private void b42_Click(object sender, EventArgs e)
        {
            b42.Enabled = false;
            numerosEscolhidos.Add(42);
            qtEscolhas++;
            atualizarLabelEscolhidos();
            verifica_jogada();
        }

        private void b43_Click(object sender, EventArgs e)
        {
            b43.Enabled = false;
            numerosEscolhidos.Add(43);
            qtEscolhas++;
            atualizarLabelEscolhidos();
            verifica_jogada();
        }

        private void b44_Click(object sender, EventArgs e)
        {
            b44.Enabled = false;
            numerosEscolhidos.Add(44);
            qtEscolhas++;
            atualizarLabelEscolhidos();
            verifica_jogada();
        }

        private void b45_Click(object sender, EventArgs e)
        {
            b45.Enabled = false;
            numerosEscolhidos.Add(45);
            qtEscolhas++;
            atualizarLabelEscolhidos();
            verifica_jogada();
        }

        private void b46_Click(object sender, EventArgs e)
        {
            b46.Enabled = false;
            numerosEscolhidos.Add(46);
            qtEscolhas++;
            atualizarLabelEscolhidos();
            verifica_jogada();
        }

        private void b47_Click(object sender, EventArgs e)
        {
            b47.Enabled = false;
            numerosEscolhidos.Add(47);
            qtEscolhas++;
            atualizarLabelEscolhidos();
            verifica_jogada();
        }

        private void b48_Click(object sender, EventArgs e)
        {
            b48.Enabled = false;
            numerosEscolhidos.Add(48);
            qtEscolhas++;
            atualizarLabelEscolhidos();
            verifica_jogada();
        }

        private void b49_Click(object sender, EventArgs e)
        {
            b49.Enabled = false;
            numerosEscolhidos.Add(49);
            qtEscolhas++;
            atualizarLabelEscolhidos();
            verifica_jogada();
        }

        private void b50_Click(object sender, EventArgs e)
        {
            b50.Enabled = false;
            numerosEscolhidos.Add(50);
            qtEscolhas++;
            atualizarLabelEscolhidos();
            verifica_jogada();
        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            if (qtEscolhas != 25)
            {
                MessageBox.Show("Escolha 25 números primeiro!");
                return;
            }

            if (txtNome.Text == "")
            {
                MessageBox.Show("Digite seu nome!");
                return;
            }

            double valor;
            if (!double.TryParse(textBox2.Text, out valor) || valor <= 0)
            {
                MessageBox.Show("Digite um valor válido!");
                return;
            }

            Random r = new Random();
            numerosSorteados.Clear();
            while (numerosSorteados.Count < 25)
            {
                int num = r.Next(1, 51);
                if (!numerosSorteados.Contains(num))
                    numerosSorteados.Add(num);
            }

            int acertos = 0;
            foreach (int num in numerosEscolhidos)
            {
                if (numerosSorteados.Contains(num))
                    acertos++;
            }

            double premio = 0;
            if (acertos == 0 || acertos == 25)
                premio = valor * 100;
            else if (acertos >= 20 && acertos <= 24)
                premio = valor * acertos;

            string msg = $"Jogador: {txtNome.Text}\n";
            msg += $"Aposta: R$ {valor:F2}\n";
            msg += $"Seus números: {string.Join(",", numerosEscolhidos)}\n";
            msg += $"Números sorteados: {string.Join(",", numerosSorteados)}\n";
            msg += $"Acertos: {acertos}\n\n";

            historicoRodadas.Add(msg);
            labelhist.Text = string.Join("\n\n------------------\n\n", historicoRodadas);

            if (premio > 0)
                msg += $"PARABÉNS! Você ganhou R$ {premio:F2}!";
            else
                msg += $"Não ganhou desta vez.";

            MessageBox.Show(msg);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listesc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void butlimp_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 50; i++)
            {
                Button b = this.Controls.Find("b" + i, true).FirstOrDefault() as Button;
                if (b != null)
                    b.Enabled = true;
            }

            numerosEscolhidos.Clear();
            qtEscolhas = 0;

            listesc.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            historicoRodadas.Clear();
            labelhist.Text = "";
        }
    }
}
