using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;


namespace APP_AbatimentoCobranca_1._0 {

    class DB {
        //public FormAguardando form = new FormAguardando();

        public MySqlConnection con;

        public DB() {
            string server = "172.16.0.121";
            string database = "cobranca";
            string user = "matheus";
            string password = "Akrk@001";

            string connString = String.Format("Server={0};Database={1};Uid={2};Pwd={3}", server, database, user, password);

            con = new MySqlConnection(connString);

        }
    }

    class CRUD : DB {

        // PROPIEDADES
        public string? proposta { get; set; }
        public string? valorRecebido { get; set; }
        public string? equipe { get; set; }
        public string? usuario { get; set; }

        // ID
        public string? id { get; set; }

        // PRORPIEDADE DE DADOS
        public DataTable dt = new DataTable();
        private DataSet ds = new DataSet();


        // LEITURA DE DADOS
        public void Read_data(int option, string dadoBuscado) {

            string query;

            try {
                /*if (!String.IsNullOrEmpty(dadoBuscado))
                    dadoBuscado = null;*/

                switch (option) {
                    case 1:
                        query = "SELECT ID, " +
                                "CONTRATO, " +
                                "CPF, " +
                                "NOME, " +
                                "(VALOR_PARCELA) PARCELA, " +
                                "(VALOR_PRINCIPAL) 'VALOR PRINCIPAL', " +
                                "CONVENIO 'CONVÊNIO', " +
                                "RESIDUO 'RESÍDUO', " +
                                "PROPOSTA, " +
                                "(VALOR_RECEBIDO) 'VALOR RECEBIDO', " +
                                "EQUIPE, " +
                                "USUARIO 'COLABORADOR'," +
                                "DT_ULT_ATUALIZACAO 'DATA ULT. ATUALIZAÇÃO'" +
                                //"FROM recebimento_cobranca WHERE CONTRATO LIKE '%" + dadoBuscado + "%'";
                                "FROM recebimento_cobranca WHERE CONTRATO = '" + dadoBuscado + "'";
                        break;
                    case 2:
                        query = "SELECT ID, " +
                                "CONTRATO, " +
                                "CPF, " +
                                "NOME, " +
                                "(VALOR_PARCELA) PARCELA, " +
                                "(VALOR_PRINCIPAL) 'VALOR PRINCIPAL', " +
                                "CONVENIO 'CONVÊNIO', " +
                                "RESIDUO 'RESÍDUO', " +
                                "PROPOSTA, " +
                                "(VALOR_RECEBIDO) 'VALOR RECEBIDO', " +
                                "EQUIPE, " +
                                "USUARIO 'COLABORADOR', " +
                                "DT_ULT_ATUALIZACAO 'DATA ULT. ATUALIZAÇÃO'" +
                                //"FROM recebimento_cobranca WHERE CPF LIKE '%" + dadoBuscado + "%'";
                                "FROM recebimento_cobranca WHERE CPF = '" + dadoBuscado + "'";
                        break;
                    case 3:
                        query = "SELECT ID, " +
                                "CONTRATO, " +
                                "CPF, " +
                                "NOME, " +
                                "(VALOR_PARCELA) PARCELA, " +
                                "(VALOR_PRINCIPAL) 'VALOR PRINCIPAL', " +
                                "CONVENIO 'CONVÊNIO', " +
                                "RESIDUO 'RESÍDUO', " +
                                "PROPOSTA, " +
                                "(VALOR_RECEBIDO) 'VALOR RECEBIDO', " +
                                "EQUIPE, " +
                                "USUARIO 'COLABORADOR', " +
                                "DT_ULT_ATUALIZACAO 'DATA ULT. ATUALIZAÇÃO'" +
                                "FROM recebimento_cobranca WHERE NOME LIKE '%" + dadoBuscado + "%'";
                        break;
                    default:
                        query = "";
                        break;
                }

                con.Open();
                using (MySqlCommand cmd = new MySqlCommand()) {
                    dt.Clear();
                    MySqlDataAdapter MDA = new MySqlDataAdapter(query, con);
                    MDA.Fill(ds);
                    dt = ds.Tables[0];
                }
                con.Close();

            } catch (Exception) {
                MessageBox.Show("Falha na conexão com o banco de dados, entre contato com o responsável.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool Update_data() {
            //MessageBox.Show($"{proposta} // {valorRecebido} // {equipe} // {id}");

            con.Open();
            using (MySqlCommand cmd = new MySqlCommand()) {

                try {
                    string Date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                    //cmd.CommandText = "UPDATE recebimento_cobranca SET PROPOSTA=@proposta, VALOR_RECEBIDO=@valor_recebido, EQUIPE=@equipe, DT_ATUALIZACAO=@dt_atualizacao WHERE ID=@id";
                    cmd.CommandText = "UPDATE recebimento_cobranca SET PROPOSTA=@proposta, VALOR_RECEBIDO=@valor_recebido, EQUIPE=@equipe, USUARIO=@usuario, DT_ULT_ATUALIZACAO=@dt_atualizacao WHERE ID=@id";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;

                    if(String.IsNullOrEmpty(proposta) || String.IsNullOrEmpty(valorRecebido) || String.IsNullOrEmpty(equipe) || String.IsNullOrEmpty(usuario)) {
                        MessageBox.Show("Preencha todas as informações para atualizar!", "Consulta cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        con.Close();
                        return false;
                    } else {
                        cmd.Parameters.Add("@proposta", MySqlDbType.VarString).Value = proposta;
                        cmd.Parameters.Add("@valor_recebido", MySqlDbType.VarString).Value = valorRecebido;
                        cmd.Parameters.Add("@equipe", MySqlDbType.VarString).Value = equipe;
                        cmd.Parameters.Add("@usuario", MySqlDbType.VarString).Value = usuario;
                        cmd.Parameters.Add("@dt_atualizacao", MySqlDbType.VarString).Value = Date;
                        cmd.Parameters.Add("@id", MySqlDbType.VarString).Value = id;

                        cmd.ExecuteNonQuery();
                        con.Close();

                        MessageBox.Show("Atualizado com sucesso!", "Consulta cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                    
                } catch (Exception) {
                    MessageBox.Show("Preencha todas as informações para atualizar!", "Consulta cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con.Close();
                    return false;
                }
            }
        }
    }
}

