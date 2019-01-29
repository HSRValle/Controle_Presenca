using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmAddData : Form
    {
        public frmAddData()
        {
            InitializeComponent();
            calFim.MinDate = DateTime.Now;
            calFim.SelectionStart = DateTime.Now;

            foreach (Usuario aluno in frmTutor.TodosUsuarios)
            {
                if (!aluno.tutor)
                {
                    int i = lbxAlunos.Items.Add(aluno.getNome());
                    lbxAlunos.SetSelected(i, true);
                }                    
            }            
        }

        private void calInicio_DateChanged(object sender, DateRangeEventArgs e)
        {
            MonthCalendar calendar = (MonthCalendar)sender;
            calFim.MinDate = calendar.SelectionStart;
            calFim.SelectionStart = calendar.SelectionStart;
        }

        private void btnCriarDatas_Click(object sender, EventArgs e)
        {
            createNextDatas(calInicio.SelectionRange.Start, calFim.SelectionRange.End);
        }
        public Boolean createNextDatas(DateTime inicio, DateTime fim)
        {
            List<Data> novasDatas = new List<Data>();            

            DateTime atual = inicio;
            TimeSpan manha = new TimeSpan(9, 0, 0);
            TimeSpan tarde = new TimeSpan(13, 30, 0);

            //aumenta o valor de fim para que o último dia seja incluído na inserção
            fim = fim + manha;

            while (atual <= fim)
            {                
                if (atual.DayOfWeek != DayOfWeek.Saturday && atual.DayOfWeek != DayOfWeek.Sunday)
                {
                    List<Usuario> usuariosSelecionados = frmTutor.TodosUsuarios.FindAll(x => lbxAlunos.SelectedItems.Contains(x.getNome()));
                    foreach (Usuario usuario in usuariosSelecionados)
                    {
                        if (!usuario.tutor)
                        { 
                            Data insert = new Data(atual.Date + manha, usuario);
                            if (insert.insertNewData())
                                frmTutor.TodasDatas.Add(insert);
                            if (atual.DayOfWeek != DayOfWeek.Monday && atual.DayOfWeek != DayOfWeek.Friday)
                            {
                                insert = new Data(atual.Date + tarde, usuario);
                                if (insert.insertNewData())
                                    frmTutor.TodasDatas.Add(insert);


                            }

                        }                        
                    }
                }
                atual = atual.AddDays(1);                
            }            
            return true;
        }
    }
}
