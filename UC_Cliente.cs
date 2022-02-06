using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_Manager
{
    public partial class UC_Cliente : UserControl
    {
        public UC_Cliente()
        {
            InitializeComponent();
        }
        private void Func_CPFOUCNPJ()
        {
            if (cbx_pessoa.Text.Length != 0)
            {
                if (cbx_pessoa.Text.Length == 6)
                {
                    lb_cpfoucnpj.Text = "CPF:";
                    mkb_cpfoucnpj.Mask = "000.000.000 - 00";
                }
                else if (cbx_pessoa.Text.Length > 6)
                {
                    //lb_cpfoucnpj.Location.X = 370;
                    //lb_cpfoucnpj.Location.Y = 168;
                    lb_cpfoucnpj.Text = "CNPJ:";
                    mkb_cpfoucnpj.Mask = "00.000.000/0000-00";
                }
            }
        }
        private void cbx_pessoa_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Func_CPFOUCNPJ();
        }
    }
}
