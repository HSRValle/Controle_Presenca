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
    public partial class frmEditData : Form
    {
        public frmEditData(Data data)
        {
            InitializeComponent();
            data.getDataEsperada();
            lblData.Text += data.getDataEsperada();
            lblAluno.Text += data.Aluno.getNome();
        }
    }
}
