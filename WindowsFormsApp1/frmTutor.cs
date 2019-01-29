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
        public Dictionary<String, String> listaFiltros = new Dictionary<String, String>();        
        private void RefreshForm()
        {
            //esconder todos os painéis
            pnlCadastroNovo.Hide();
            pnlPresenca.Hide();
            pnlCadastroPesquisa.Hide();
            pnlMudarSenha.Hide();
            pnlEditarCadastro.Hide();
            pnlExcluir.Hide();
            pnlEditarOutroCadastro.Hide();
        } 

        public frmTutor(Usuario tutor)
        {
            Login = tutor;
            TodosUsuarios = Consulta.getUsuarios();
            TodasDatas = Consulta.getDatas(TodosUsuarios);
            InitializeComponent();
            cmbAluno.Items.Add("Todos os alunos");
            foreach (Usuario u in TodosUsuarios)
            {
                if (!u.tutor)
                {
                    cmbAluno.Items.Add(u.getNome());
                }                
            }
            verDatasToolStripMenuItem_Click();

        }
        private void preencherDataGridView(List<Data> listaDatas)
        {
            dataGridView.Rows.Clear();
            dataGridView.Refresh();
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView.ColumnCount = 9;

            dataGridView.Columns[0].Name = "Id";
            dataGridView.Columns[0].Visible = false;
            dataGridView.Columns[1].ValueType = typeof(int);

            dataGridView.Columns[1].Name = "Dia";
            dataGridView.Columns[1].ValueType = typeof(DateTime);
            dataGridView.Columns[1].FillWeight = 10;

            dataGridView.Columns[2].Name = "Hora";
            dataGridView.Columns[2].ValueType = typeof(DateTime);
            dataGridView.Columns[2].FillWeight = 9;

            dataGridView.Columns[3].Name = "Aluno";
            dataGridView.Columns[3].FillWeight = 16;

            dataGridView.Columns[4].Name = "Grupo";
            dataGridView.Columns[4].FillWeight = 6;

            dataGridView.Columns[5].Name = "Presente?";
            dataGridView.Columns[5].FillWeight = 13;

            dataGridView.Columns[6].Name = "No horário?";
            dataGridView.Columns[6].FillWeight = 13;

            dataGridView.Columns[7].Name = "Justificativa";
            dataGridView.Columns[7].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView.Columns[7].FillWeight = 26;

            dataGridView.Columns[8].Name = "Tutor";
            dataGridView.Columns[8].FillWeight = 13;

            foreach (Data data in listaDatas)
            {
                int index = dataGridView.Rows.Add();

                dataGridView.Rows[index].Cells[0].Value = data.getId();

                dataGridView.Rows[index].Cells[1].Value = data.getDataEsperada().Date;
                dataGridView.Rows[index].Cells[2].Value = data.getDataEsperada().TimeOfDay;
                dataGridView.Rows[index].Cells[3].Value = data.Aluno.getNome();

                dataGridView.Rows[index].Cells[4].Value = data.Aluno.grupo;

                if (data.presente)
                {
                    dataGridView.Rows[index].Cells[5].Value = "Sim";
                    dataGridView.Rows[index].Cells[5].Style.BackColor = Color.LightGreen;
                }
                else
                {
                    dataGridView.Rows[index].Cells[5].Value = "Não";
                    dataGridView.Rows[index].Cells[5].Style.BackColor = Color.IndianRed;
                }

                if (data.noHorario)
                {
                    dataGridView.Rows[index].Cells[6].Value = "Sim";
                    dataGridView.Rows[index].Cells[6].Style.BackColor = Color.LightGreen;
                }
                else
                {
                    dataGridView.Rows[index].Cells[6].Value = "Não";
                    if (data.isRealSet())
                    {
                        dataGridView.Rows[index].Cells[6].Value += " ("+data.getDataReal().TimeOfDay+ ")";
                    }
                    dataGridView.Rows[index].Cells[6].Style.BackColor = Color.IndianRed;
                }
                if (data.justificativa != null && data.justificativa.Length > 0)
                {
                    dataGridView.Rows[index].Cells[7].Value = data.justificativa;
                }

                if (data.Tutor != null)
                {
                    dataGridView.Rows[index].Cells[8].Value = data.Tutor.getNome();
                }
            }
        }

        private void frmTutor_Load(object sender, EventArgs e)
        {
            RefreshForm();
        }


        private void verDatasToolStripMenuItem_Click(object sender = null, EventArgs e = null)
        {            
            pnlPresenca.Show();
            pnlPresenca.BringToFront();           
            listaFiltros["Datas"] = "Passado";
            filtrarDatas();
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;            
            if (index == -1)
                return;
            int id = int.Parse(dataGridView.Rows[index].Cells[0].Value.ToString());
            Data d = TodasDatas.Find(x => x.getId() == id);            
            frmEditData frmEditData = new frmEditData(d);
            frmEditData.Show();
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {            
            System.Threading.Thread.Sleep(100);
            listaFiltros.Clear();
            listaFiltros["Datas"] = "Futuras";
            filtrarDatas();

        }

        private void cmbAluno_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            String name = cmb.Items[cmb.SelectedIndex].ToString();            
            listaFiltros["Aluno"] = name;
            filtrarDatas();
        }
        private void chbFaltas_CheckedChanged(object sender, EventArgs e)
        {
            if (chbFaltas.Checked)
                listaFiltros["Faltas"] = "";
            else
                listaFiltros.Remove("Faltas");
            filtrarDatas();
        }

        private void nudFiltroGrupo_ValueChanged(object sender, EventArgs e)
        {
            if (nudFiltroGrupo.Value > 0)
                listaFiltros["Grupo"] = nudFiltroGrupo.Value.ToString();
            else
                listaFiltros.Remove("Grupo");
            filtrarDatas();
        }

        private void cmbFiltroDatas_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            if (cmb.SelectedIndex == -1)
                return;
            String opcao = cmb.Items[cmb.SelectedIndex].ToString();

            if (opcao != "todas")
                listaFiltros["Datas"] = opcao;
            else
                listaFiltros.Remove("Datas");
            filtrarDatas();
        }
        private void filtrarDatas()
        {
            //Verifica a variável listaFiltros e busca datas correspondentes aos diferentes filtros armazenados no dicionário            
            List<Data> resultado = TodasDatas.FindAll(x=> true);
            if (listaFiltros.ContainsKey("Aluno"))
            {
                if (listaFiltros["Aluno"] != "" && listaFiltros["Aluno"] != "Todos os alunos")
                {
                    Usuario aluno = TodosUsuarios.Find(x => x.getNome() == listaFiltros["Aluno"]);
                    resultado = resultado.FindAll(x => x.Aluno.Equals(aluno));
                }
            }
            if (listaFiltros.ContainsKey("Datas"))
            {
                if (listaFiltros["Datas"] == "Futuras")
                    resultado = resultado.FindAll(x => x.getDataEsperada().CompareTo(DateTime.Now) > 0);
                else if (listaFiltros["Datas"] == "Anteriores")
                    resultado = resultado.FindAll(x => x.getDataEsperada().CompareTo(DateTime.Now) < 0);
            }
            if (listaFiltros.ContainsKey("Faltas"))
            {
                resultado = resultado.FindAll(x => !x.presente);
            }            
            if (listaFiltros.ContainsKey("Grupo"))
            {
                resultado = resultado.FindAll(x => x.Aluno.grupo.ToString() == listaFiltros["Grupo"]);
            }


            preencherDataGridView(resultado);
        }
        private void btnLimparFiltros_Click(object sender, EventArgs e)
        {
            listaFiltros.Clear();
            chbFaltas.Checked = false;
            nudFiltroGrupo.Value = 0;
            cmbFiltroDatas.SelectedIndex = 0;
            cmbAluno.SelectedIndex = 0;
            filtrarDatas();

        }
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            filtrarDatas();
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
            int grupo = (int)nudGrupo.Value;
            String confirmarSenha = txtConfirmSenha.Text;
            String email = txtEmail.Text;
            if (senha == confirmarSenha)
            {
                Usuario novoUsuario = new Usuario(nome, grupo, email, senha, chbTutor.Checked);
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





        private void procurarCadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshForm();
            pnlCadastroPesquisa.Show();
            pnlCadastroPesquisa.BringToFront();
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
                    if(!usuario.tutor)
                        lblResultado.Text += " (G"+usuario.grupo+")";
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
        private void btnLimparEdicao_Click(object sender, EventArgs e)
        {
            editarCadastroToolStripMenuItem1_Click(sender, e);
        }



        private void excluirCadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshForm();
            pnlExcluir.Show();
            pnlExcluir.BringToFront();
            if (cmbExcluirUsuario.Items.Count == 0)
            {
                foreach (Usuario usuario in TodosUsuarios)
                {
                    cmbExcluirUsuario.Items.Add(usuario.getNome());
                }
            }
        }
        private void txtExcluirSenha_TextChanged(object sender, EventArgs e)
        {
            if (txtExcluirSenha.Text != "")
            {
                btnExcluirConfirmar.Enabled = true;
            }
            else
            {
                btnExcluirConfirmar.Enabled = false;
            }
        }

        private void btnExcluirConfirmar_Click(object sender, EventArgs e)
        {
            if (Login.comparaSenha(txtExcluirSenha.Text))
            {
                DialogResult confirmacao;
                String name = cmbExcluirUsuario.SelectedItem.ToString();
                confirmacao = MessageBox
                    .Show("Remover o usuário removerá todas as datas associadas a ele\n" 
                            + "Essa operação não pode ser desfeita" 
                            + "\nTem certeza que deseja remover o usuario " + name + "?",
                    "Confirmação",
                    MessageBoxButtons.YesNo);
                if(confirmacao == DialogResult.Yes)
                {
                    Usuario usuarioADeleter = TodosUsuarios.Find(x => x.getNome().Equals(name));
                    usuarioADeleter.deleteUsuario();
                }

            }
            else
            {
                lblExcluirErro.Text = "Senha incorreta";
            }
        }

        private void editarCadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshForm();
            pnlEditarOutroCadastro.Show();
            pnlEditarOutroCadastro.BringToFront();
            if(cmbEditarUsuarios.Items.Count == 0)
                foreach (Usuario usuario in TodosUsuarios)
                {
                    cmbEditarUsuarios.Items.Add(usuario.getNome());
                }            
        }

        private void cmbEditarUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {            
            ComboBox cmb = (ComboBox)sender;
            String nome = cmb.Items[cmb.SelectedIndex].ToString();

            lblEditarCadastro.Text = "Editando " + nome;

            pnlEditarControles.Visible = true;
            Usuario usuario = TodosUsuarios.Find(x => x.getNome() == nome);

            nudId.Value = usuario.id;

            txtEditarNome.Text = usuario.getNome();
            txtEditarEmail.Text = usuario.getEmail();
            nudEditarGrupo.Value = usuario.grupo;
            txtEditarOutroSenha.Text = txtEditarOutroConfirmacao.Text = "";

        }

        private void btnSalvarOutroUsuario_Click(object sender, EventArgs e)
        {            
            if (txtEditarOutroSenha.Text != txtEditarOutroConfirmacao.Text)
            {                
                lblErroEditarOutroUsuario.Text = "Senhas não conferem";
                return;
            }
            Usuario usuario = TodosUsuarios.Find(x => x.id == nudId.Value);          
            if (usuario == null)
            {
                return;
            }
            DialogResult result =  MessageBox.Show("Tem certeza que quer alterar o usuário " + usuario.getNome() + "?", "Confirmação", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                if (txtEditarNome.Text != usuario.getNome() || txtEditarEmail.Text != usuario.getEmail() || nudEditarGrupo.Value != usuario.grupo)
                {
                    usuario.updateUsuario(txtEditarNome.Text, txtEditarEmail.Text, (int)nudEditarGrupo.Value);
                }
                if (txtEditarOutroSenha.Text != "" && !usuario.comparaSenha(txtEditarOutroSenha.Text))
                {
                    usuario.mudaSenha(txtEditarOutroSenha.Text);
                }
            }            
                        

        }

        private void btnEditarOutrosLimpar_Click(object sender, EventArgs e)
        {
            Usuario usuario = TodosUsuarios.Find(x => x.id == nudId.Value);

            nudId.Value = usuario.id;

            txtEditarNome.Text = usuario.getNome();
            txtEditarEmail.Text = usuario.getEmail();
            nudEditarGrupo.Value = usuario.grupo;
            txtEditarOutroSenha.Text = txtEditarOutroConfirmacao.Text = "";

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void criarDatasFuturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddData frmAddData = new frmAddData();
            frmAddData.Show();

        }
        
    }
}
