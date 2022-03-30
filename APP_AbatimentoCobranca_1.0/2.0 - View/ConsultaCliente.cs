using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace APP_AbatimentoCobranca_1._0 {
    public partial class frmConsultaCliente : Form {
        
        CRUD crud = new CRUD();
        
        public frmConsultaCliente() {
            InitializeComponent();
        }

        private void frmConsultaCliente_Load(object sender, EventArgs e) {
            txtContrato.Text = Form1.contrato;
            txtCPF.Text = Form1.cpf;
            txtNome.Text = Form1.nome;
            txtValorPrestacao.Text = Form1.valorPrestacao;
            txtValorPrincipal.Text = Form1.valorPrincipal;
            txtConvenio.Text = Form1.convenio;
            txtResiduo.Text = Form1.residuo;
            txtProposta.Text = Form1.proposta;
            txtValorRecebido.Text = Form1.valorRecebido;
            cbEquipe.Text = Form1.equipe;
            txtUsuario.Text = Form1.usuario;
        }

        private void btnSalvar_Click(object sender, EventArgs e) {
            UPDATE();
        }

        public void UPDATE() {
            crud.proposta = txtProposta.Text;
            string text = txtValorRecebido.Text;
            crud.valorRecebido = text.Replace(".", "").Replace(",", ".");
            crud.equipe = cbEquipe.Text;
            crud.usuario = txtUsuario.Text;
            crud.id = Form1.id;
            
            bool retorno = crud.Update_data();
            if (retorno == true)
                this.Close();
        }

        private void txtValorRecebido_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = !char.IsNumber(e.KeyChar) && !char.IsPunctuation(e.KeyChar) && (e.KeyChar != '\b'); //Restringe em caracteres numericos, pontuações e backspace
        }

        private void txtValorRecebido_Leave(object sender, EventArgs e) {

            try {
                if (txtValorRecebido.Text != null &&
                !String.IsNullOrEmpty(txtValorRecebido.Text) &&
                txtValorRecebido.Text != "") {

                    txtValorRecebido.Text = String.Format("{0:N2}", double.Parse(txtValorRecebido.Text)); //Formata para Decimal
                }
            } catch (Exception) {
                MessageBox.Show("Valor Recebido incorreto!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtValorRecebido.Focus();
            }
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = !char.IsLetter(e.KeyChar) && (e.KeyChar != '\b' && !char.IsWhiteSpace(e.KeyChar));
        }
        
        private void txtUsuario_Leave(object sender, EventArgs e) {
            txtUsuario.Text = txtUsuario.Text.ToUpper();
        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e) {
            this.Close();
        }

        
    }
}
