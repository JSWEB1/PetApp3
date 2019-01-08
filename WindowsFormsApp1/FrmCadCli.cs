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
    public partial class FrmCadCli : Form
    {
        public FrmCadCli()
        {
            InitializeComponent();
        }

        private void FrmCadCli_Load(object sender, EventArgs e)
        {

        }

        private void rgPesTipo_EditValueChanged(object sender, EventArgs e)
        {
            if (Funcoes.toString(rgPesTipo.EditValue) == "JUR")
            {
                edNomeCli.Enabled = false;
                edNasCli.Enabled = false;
            }
        }
    }
}
