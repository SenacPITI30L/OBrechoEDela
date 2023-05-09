using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Brechó
{
    public partial class FrmAdicionaItem : Form
    {
        public FrmAdicionaItem()
        {
            InitializeComponent();
        }

        private void btn_Pagamento_Click(object sender, EventArgs e)
        {
                string codigo = txt_Prodcod.Text;
                string valCompra = txt_Valorcompra.Text;

            if (!string.IsNullOrEmpty(valCompra) && !string.IsNullOrEmpty(valCompra))
            {
              frmMetododePagamento pagamento = new frmMetododePagamento();
              pagamento.ShowDialog();
                
            }
            else 
            {
              MessageBox.Show("Preencha todos os campos");
            }
        }

        private void btn_Adiciona_Click(object sender, EventArgs e)
        {
            string codigoDeBarras = txt_Prodcod.Text;

            int soma = 0;

            foreach (char digito in codigoDeBarras)
            {
                if (char.IsDigit(digito))
                {
                    soma += int.Parse(digito.ToString());
                }
            }

            txt_Valorcompra.Text = soma.ToString();
        }
    }
}
