using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Emprestimo
{
    public partial class frmPrincipal : Form
    {
        private bool computarPagamento;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtSaldo_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            btnPagamentos.PerformClick();
        }

        private void btnPagamentos_Click(object sender, EventArgs e)
        {
            computarPagamento = true;
            btnPagamentos.Visible = false;
            btnMeses.Visible = true;
            txtMeses.ReadOnly = false;
            txtMeses.BackColor = Color.White;
            txtPagamento.Text = "";
            txtPagamento.ReadOnly = true;
            txtPagamento.BackColor = Color.Gray;
            btnCalcular.Text = "Calcular Pagamento Mensal";
        }

        private void btnMeses_Click(object sender, EventArgs e)
        {
            computarPagamento = false;
            btnPagamentos.Visible = true;
            btnMeses.Visible = false;
            txtMeses.Text = "";
            txtMeses.ReadOnly = true;
            txtMeses.BackColor = Color.Gray;
            txtPagamento.ReadOnly = false;
            txtPagamento.BackColor = Color.White;
            btnCalcular.Text = "Calcular Número de Pagamentos";
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // declaração das variáveis
            double saldo, taxa, pagamento;
            int meses;
            double jurosMensal, multiplicador;
            // leitura dos campos informados pelo usuário, verifica se os campos estão vazios
            if (txtSaldo.Text != "")
            {
                saldo = Convert.ToDouble(txtSaldo.Text);
            }
            else
            {
                MessageBox.Show("Informe o Saldo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSaldo.Focus();
                return;
            }
            if (txtTaxa.Text != "")
            {
                taxa = Convert.ToDouble(txtTaxa.Text);
            }
            else
            {
                MessageBox.Show("Informe a Taxa de Juros.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTaxa.Focus();
                return;
            }
            jurosMensal = taxa / 1200;
            // código para o calculo dos valores dependendo da opção selecionada
            if (computarPagamento)
            {
                // calcula o valor do pagamento mensal
                if (txtMeses.Text != "")
                {
                    meses = Convert.ToInt32(txtMeses.Text);
                    if (meses == 0)
                    {
                        MessageBox.Show("O Número de Pagamentos deve ser maior que zero.", "Erro",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtMeses.Focus();
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Informe o Número de Pagamentos.", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMeses.Focus();
                    return;
                }
                if (taxa == 0)
                {
                    pagamento = saldo / meses;
                }
                else
                {
                    multiplicador = Math.Pow(1 + jurosMensal, meses);
                    pagamento = saldo * jurosMensal * multiplicador / (multiplicador - 1);
                }
                // atribui o valor calculado ao campo Pagamento Mensal
                txtPagamento.Text = String.Format("{0:f2}", pagamento);
            }
            else
            {
                // calcula o número de pagamentos mensais
                if (txtPagamento.Text != "")
                {
                    pagamento = Convert.ToDouble(txtPagamento.Text);
                    if (pagamento == 0.0)
                    {
                        MessageBox.Show("O Pagamento Mensal deve ser maior que zero.", "Erro",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtPagamento.Focus();
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Informe o Pagamento Mensal.", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPagamento.Focus();
                    return;
                }
                if (taxa == 0)
                {
                    meses = (int)(saldo / pagamento);
                }
                else
                {
                    meses = (int)((Math.Log(pagamento) - Math.Log(pagamento - saldo * jurosMensal)) / Math.Log(1 + jurosMensal));
                }
                // atribui o valor calculado ao campo Número de Pagamentos
                txtMeses.Text = meses.ToString();
            }
            // código para o preenchimento da análise do empréstimo
            double saldoEmprestimo, pagamentoFinal;
            pagamento = Convert.ToDouble(txtPagamento.Text);
            // monta o resultado da análise
            StringBuilder texto = new StringBuilder();
            texto.Append("Saldo do Empréstimo: R$ ");
            texto.Append(String.Format("{0:f2}", saldo));
            texto.Append("\r\nTaxa de Juros: ");
            texto.Append(String.Format("{0:f2}", taxa) + "%");
            saldoEmprestimo = saldo;
            for (int i = 1; i <= meses - 1; i++)
            {
                saldoEmprestimo += saldoEmprestimo * jurosMensal - pagamento;
            }
            pagamentoFinal = saldoEmprestimo;
            if (pagamentoFinal > pagamento)
            {
                saldoEmprestimo += saldoEmprestimo * jurosMensal - pagamento;
                pagamentoFinal = saldoEmprestimo;
                meses++;
                txtMeses.Text = meses.ToString();
            }
            texto.Append("\r\n\r\n");
            texto.Append(Convert.ToString(meses - 1));
            texto.Append(" Pagamentos de R$ ");
            texto.Append(String.Format("{0:f2}", pagamento));
            texto.Append("\r\nPagamento Final de: R$ ");
            texto.Append(String.Format("{0:f2}", pagamentoFinal));
            texto.Append("\r\nTotal de Pagamentos: R$ ");
            texto.Append(String.Format("{0:f2}", (meses - 1) * pagamento + pagamentoFinal));
            texto.Append("\r\nJuros Pagos: R$ ");
            texto.Append(String.Format("{0:f2}", (meses - 1) * pagamento + pagamentoFinal - saldo));
            // atribui o texto gerado ao campo de Analise de Emprestimo
            txtAnalise.Text = texto.ToString();
            // habilita/desabilita os botões
            btnCalcular.Enabled = false;
            btnNovo.Enabled = true;
            btnNovo.Focus();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (computarPagamento)
            {
                txtPagamento.Text = "";
            }
            else
            {
                txtMeses.Text = "";
            }
            txtAnalise.Text = "";
            btnCalcular.Enabled = true;
            btnNovo.Enabled = false;
            txtSaldo.Focus();
        }

        private void txtPagamento_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSaldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
            {
                e.Handled = false;
            }
            else if ((int)e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else if (e.KeyChar == ',' || e.KeyChar == '.')
            {
                // substitui o ponto por vírgula
                e.KeyChar = ',';
                if (txtSaldo.Text.IndexOf(",") == -1)
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            else if ((int)e.KeyChar == 13)
            {
                txtTaxa.Focus();
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
