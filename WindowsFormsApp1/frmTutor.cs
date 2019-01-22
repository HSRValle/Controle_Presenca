using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data;
using MySql.Data.MySqlClient;

/** lblResultado existe para que o resultado possa ser imprimido nessa label, mudar caso ache um metódo mais eficiente **/

namespace WindowsFormsApp1
{
    public partial class frmTutor : Form
    {   
        // as listas e o usuário atual devem estar sempre disponíveis
        public static List<Usuario> TodosUsuarios;
        public static List<Data> TodasDatas;
        public static Usuario Login;
        private Boolean exibirFuturo;
        private void RefreshForm()
        {
            //esconder todos os painéis
            pnlCadastroNovo.Hide();
            pnlPresenca.Hide();
            pnlCadastroPesquisa.Hide();
            pnlMudarSenha.Hide();
            pnlEditarCadastro.Hide();
        } 

        public frmTutor(Usuario tutor)
        {
            Login = tutor;
            TodosUsuarios = Consulta.getUsuarios();
            TodasDatas = Consulta.getDatas(TodosUsuarios);
            InitializeComponent();

            datasPassadasToolStripMenuItem_Click();

        }
        private void preencherDataGridView(List<Data> listaDatas)
        {
            dataGridView.Rows.Clear();
            dataGridView.Refresh();
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView.ColumnCount = 7;

            dataGridView.Columns[0].Name = "Id";
            dataGridView.Columns[0].Visible = false;
            dataGridView.Columns[1].ValueType = typeof(int);

            dataGridView.Columns[1].Name = "Data";
            dataGridView.Columns[1].ValueType = typeof(DateTime);
            dataGridView.Columns[1].FillWeight = 17;

            dataGridView.Columns[2].Name = "Aluno";
            dataGridView.Columns[2].FillWeight = 16;

            dataGridView.Columns[3].Name = "Presente?";
            dataGridView.Columns[3].FillWeight = 13;

            dataGridView.Columns[4].Name = "No horário?";
            dataGridView.Columns[4].FillWeight = 13;

            dataGridView.Columns[5].Name = "Justificativa";
            dataGridView.Columns[5].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView.Columns[5].FillWeight = 28;

            dataGridView.Columns[6].Name = "Tutor";
            dataGridView.Columns[6].FillWeight = 13;

            foreach (Data data in listaDatas)
            {
                int index = dataGridView.Rows.Add();

                dataGridView.Rows[index].Cells[0].Value = data.getId();

                dataGridView.Rows[index].Cells[1].Value = data.getDataEsperada();
                dataGridView.Rows[index].Cells[2].Value = data.Aluno.getNome();

                if (data.presente)
                {
                    dataGridView.Rows[index].Cells[3].Value = "Sim";
                    dataGridView.Rows[index].Cells[3].Style.BackColor = Color.LightGreen;
                }
                else
                {
                    dataGridView.Rows[index].Cells[3].Value = "Não";
                    dataGridView.Rows[index].Cells[3].Style.BackColor = Color.IndianRed;
                }

                if (data.noHorario)
                {
                    dataGridView.Rows[index].Cells[4].Value = "Sim";
                    dataGridView.Rows[index].Cells[4].Style.BackColor = Color.LightGreen;
                }
                else
                {
                    dataGridView.Rows[index].Cells[4].Value = "Não";
                    dataGridView.Rows[index].Cells[4].Style.BackColor = Color.IndianRed;
                }
                if (data.justificativa != null && data.justificativa.Length > 0)
                {
                    dataGridView.Rows[index].Cells[5].Value = data.justificativa;
                }

                if (data.Tutor != null)
                {
                    dataGridView.Rows[index].Cells[6].Value = data.Tutor.getNome();
                }
            }
        }

        private void frmTutor_Load(object sender, EventArgs e)
        {
            RefreshForm();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        /**
        private void presençaDosAlunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MySqlConnection sqlcon = new MySqlConnection(Sql.Conection());
            sqlcon.Open();
            MySqlCommand cmd = new MySqlCommand("Select * from new_schema.usuarios", sqlcon);
            DataSet ds = new DataSet();
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            sda.Fill(ds);
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = ds.Tables[0].ToString();
            dataGridView1.Show();

        } **/

        private void procurarCadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshForm();
            pnlCadastroPesquisa.Show();
            pnlCadastroPesquisa.BringToFront();
        }

        private void datasFuturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.exibirFuturo = true;
            pnlPresenca.Show();
            pnlPresenca.BringToFront();
            List<Data> filtro = TodasDatas.FindAll(x => x.getDataEsperada().CompareTo(DateTime.Now) > 0);
            preencherDataGridView(filtro);
        }

        private void datasPassadasToolStripMenuItem_Click(object sender = null, EventArgs e = null)
        {
            this.exibirFuturo = false;
            pnlPresenca.Show();
            pnlPresenca.BringToFront();
            List<Data> filtro = TodasDatas.FindAll(x => x.getDataEsperada().CompareTo(DateTime.Now) < 0);        
            preencherDataGridView(filtro);            
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            int id = int.Parse(dataGridView.Rows[index].Cells[0].Value.ToString());
            Data d = TodasDatas.Find(x => x.getId() == id);            
            frmEditData frmEditData = new frmEditData(d);
            frmEditData.Show();
        }
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (this.exibirFuturo)
            {
                datasFuturasToolStripMenuItem_Click(sender, e);
            }
            else
            {
                datasPassadasToolStripMenuItem_Click(sender, e);
            }
        }



        private void novoCadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /**fazer o painel relevante aparecer e o trazer para frente, 
            para ter certeza que não está escondio atrás de outro painel**/
            RefreshForm(); 
            pnlCadastroNovo.Show();
            pnlCadastroNovo.BringToFront();
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            String nome = txtNome.Text;
            String senha = txtSenha.Text;
            String confirmarSenha = txtConfirmSenha.Text;
            String email = txtEmail.Text;
            if (senha == confirmarSenha)
            {
                Usuario novoUsuario = new Usuario(nome, email, senha, chbTutor.Checked);
                novoUsuario.insertNewUsuario();
                TodosUsuarios.Add(novoUsuario);
                MessageBox.Show("Usuário cadastrado");
                btnLimpar_Click(sender, e);
            }
            else
            {
                lblErroNovo.Text = "Senhas não correspondem.";
            }


        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = txtSenha.Text = txtConfirmSenha.Text = txtEmail.Text = "";
        }



        private void editarSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshForm();
            pnlMudarSenha.Show();
            pnlMudarSenha.BringToFront();
        }
        private void btnEditarSenha_Click(object sender, EventArgs e)
        {
            String SenhaAntiga = txtSenhaAntiga.Text;
            String NovaSenha = txtNovaSenha.Text;
            String ConfSenha = txtConfSenha.Text;
            if (!Login.comparaSenha(SenhaAntiga))
            {
                lblErro.Text = "Senha incorreta";
                return;
            }
            if (NovaSenha != ConfSenha)
            {
                lblErro.Text = "Senhas não correspondem.";
                return;
            }
            Login.mudaSenha(NovaSenha);
            MessageBox.Show("Senha alterada com sucesso");
            txtNovaSenha.Text = txtConfSenha.Text = txtSenhaAntiga.Text = "";

        }




        private void excluirCadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshForm();
            pnlExcluir.Show();
            pnlExcluir.BringToFront();
        }




        private void btnCriar_Click(object sender, EventArgs e)
        {
            createNextDatas();
            System.Threading.Thread.Sleep(100);
            datasFuturasToolStripMenuItem_Click(sender, e);
        }
        public Boolean createNextDatas(int dias = 7)
        {
            List<Data> novasDatas = new List<Data>();


            DateTime hoje = DateTime.Now;
            TimeSpan manha = new TimeSpan(9, 0, 0);
            TimeSpan tarde = new TimeSpan(13, 30, 0);
            for (int i = 1; i <= dias; i++)
            {
                DateTime novaData = hoje.AddDays(i);
                novaData = novaData.Date + manha;
                if (novaData.DayOfWeek != DayOfWeek.Saturday && novaData.DayOfWeek != DayOfWeek.Sunday)
                {
                    foreach (Usuario usuario in TodosUsuarios)
                    {
                        if (!usuario.tutor)
                        {
                            //Se é aluno
                            Data insert = new Data(novaData.Date + manha, usuario);
                            insert.insertNewData();
                            TodasDatas.Add(insert);
                            if (novaData.DayOfWeek != DayOfWeek.Monday && novaData.DayOfWeek != DayOfWeek.Friday)
                            {
                                insert = new Data(novaData.Date + tarde, usuario);
                                insert.insertNewData();
                                TodasDatas.Add(insert);


                            }

                        }
                        // Else com horários para tutores?
                    }
                }

            }            
            return true;
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            lblResultado.Text = "Resultado:";
            String nome = txtProcNome.Text;
            List<Usuario> resultado = TodosUsuarios.FindAll(x => x.getNome().Contains(nome) );
            if(resultado.Count > 0)
            {
                foreach (Usuario usuario in resultado)
                {
                    lblResultado.Text += "\n" + usuario.getNome();
                }
            }
            else
            {
                lblResultado.Text += "\nNenhum usuário encontrado";
            }
        }

        private void editarCadastroToolStripMenuItem1_Click(object sender, EventArgs e)
        {            
            RefreshForm();
            pnlEditarCadastro.Show();            
            pnlEditarCadastro.BringToFront();

            txtNomeEditar.Text = Login.getNome();
            txtEmailEditar.Text = Login.getEmail();
        }

        private void btnSalvarEditar_Click(object sender, EventArgs e)
        {
            Login.updateUsuario(txtNomeEditar.Text, txtEmailEditar.Text);
            MessageBox.Show("Usuário alterado");
        }
    }
}
