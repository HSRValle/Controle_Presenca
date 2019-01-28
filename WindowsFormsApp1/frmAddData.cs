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
    }
}
