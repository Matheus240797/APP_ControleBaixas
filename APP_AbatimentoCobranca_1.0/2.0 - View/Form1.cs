using MySql.Data.MySqlClient;
using System.Data;

namespace APP_AbatimentoCobranca_1._0 {
    public partial class Form1 : Form {
        
        CRUD crud = new CRUD();
        frmConsultaCliente frmConsultaCliente = new frmConsultaCliente();

        public string dadoBuscado;
        public int opcao;
        
        public static string id;
        public static string contrato;
        public static string cpf;
        public static string nome;
        public static string valorPrestacao;
        public static string valorPrincipal;
        public static string convenio;
        public static string residuo;
        public static string proposta;
        public static string valorRecebido;
        public static string usuario;
        public static string equipe;
        
        public Form1() {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e) {
         
            pnForm1.BackColor = ColorTranslator.FromHtml("#0466C8");
            rbCPF.Checked = true;

        }
        private void btnPesquisar_Click_1(object sender, EventArgs e) {
            if (rbContrato.Checked) {
                opcao = 1;
                dadoBuscado = txtPesquisar.Text;
            } else if (rbCPF.Checked) {
                opcao = 2;
                dadoBuscado = txtPesquisar.Text;
            } else if (rbNome.Checked) {
                opcao = 3;
                dadoBuscado = txtPesquisar.Text;
            }

            READ(opcao, dadoBuscado);
        }
        private void btnAtualizar_Click(object sender, EventArgs e) {
            if (rbContrato.Checked) {
                opcao = 1;
                dadoBuscado = txtPesquisar.Text;
            } else if (rbCPF.Checked) {
                opcao = 2;
                dadoBuscado = txtPesquisar.Text;
            } else if (rbNome.Checked) {
                opcao = 3;
                dadoBuscado = txtPesquisar.Text;
            }

            READ(opcao, dadoBuscado);
        }

        public void READ(int opcao, string dadoBuscado) {
            dtGridClientes.DataSource = null;
            crud.Read_data(opcao, dadoBuscado);
            dtGridClientes.DataSource = crud.dt;
        }
        private void dtGridClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {

            try {
                DataGridViewRow linha = dtGridClientes.Rows[e.RowIndex];

                id = linha.Cells[0].Value.ToString();
                contrato = linha.Cells[1].Value.ToString();
                cpf = linha.Cells[2].Value.ToString();
                nome = linha.Cells[3].Value.ToString();
                valorPrestacao = linha.Cells[4].Value.ToString();
                valorPrincipal = linha.Cells[5].Value.ToString();
                convenio = linha.Cells[6].Value.ToString();
                residuo = linha.Cells[7].Value.ToString();
                proposta = linha.Cells[8].Value.ToString();
                valorRecebido = linha.Cells[9].Value.ToString();
                equipe = linha.Cells[10].Value.ToString();
                usuario = linha.Cells[11].Value.ToString();
                
                frmConsultaCliente.ShowDialog();

            } catch (Exception) {
                MessageBox.Show("Selecione uma linha!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCloseForm1_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void txtPesquisar_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter)
                btnPesquisar.PerformClick();
        }

        
    }
}