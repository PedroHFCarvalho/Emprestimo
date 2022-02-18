namespace Emprestimo
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblTaxa = new System.Windows.Forms.Label();
            this.lblPagamentos = new System.Windows.Forms.Label();
            this.lblMensal = new System.Windows.Forms.Label();
            this.lblAnalise = new System.Windows.Forms.Label();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.txtTaxa = new System.Windows.Forms.TextBox();
            this.txtMeses = new System.Windows.Forms.TextBox();
            this.txtPagamento = new System.Windows.Forms.TextBox();
            this.txtAnalise = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnMeses = new System.Windows.Forms.Button();
            this.btnPagamentos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.Location = new System.Drawing.Point(34, 46);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(161, 20);
            this.lblSaldo.TabIndex = 0;
            this.lblSaldo.Text = "Saldo do Empréstimo";
            // 
            // lblTaxa
            // 
            this.lblTaxa.AutoSize = true;
            this.lblTaxa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTaxa.Location = new System.Drawing.Point(34, 78);
            this.lblTaxa.Name = "lblTaxa";
            this.lblTaxa.Size = new System.Drawing.Size(108, 20);
            this.lblTaxa.TabIndex = 1;
            this.lblTaxa.Text = "Taxa de Juros";
            // 
            // lblPagamentos
            // 
            this.lblPagamentos.AutoSize = true;
            this.lblPagamentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPagamentos.Location = new System.Drawing.Point(34, 108);
            this.lblPagamentos.Name = "lblPagamentos";
            this.lblPagamentos.Size = new System.Drawing.Size(181, 20);
            this.lblPagamentos.TabIndex = 2;
            this.lblPagamentos.Text = "Número de Pagamentos";
            this.lblPagamentos.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblMensal
            // 
            this.lblMensal.AutoSize = true;
            this.lblMensal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblMensal.Location = new System.Drawing.Point(34, 140);
            this.lblMensal.Name = "lblMensal";
            this.lblMensal.Size = new System.Drawing.Size(146, 20);
            this.lblMensal.TabIndex = 3;
            this.lblMensal.Text = "Pagamento Mensal";
            // 
            // lblAnalise
            // 
            this.lblAnalise.AutoSize = true;
            this.lblAnalise.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblAnalise.Location = new System.Drawing.Point(392, 29);
            this.lblAnalise.Name = "lblAnalise";
            this.lblAnalise.Size = new System.Drawing.Size(172, 20);
            this.lblAnalise.TabIndex = 4;
            this.lblAnalise.Text = "Análise do Empréstimo";
            // 
            // txtSaldo
            // 
            this.txtSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSaldo.Location = new System.Drawing.Point(224, 43);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(100, 26);
            this.txtSaldo.TabIndex = 5;
            this.txtSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSaldo.TextChanged += new System.EventHandler(this.txtSaldo_TextChanged);
            this.txtSaldo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSaldo_KeyPress);
            // 
            // txtTaxa
            // 
            this.txtTaxa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTaxa.Location = new System.Drawing.Point(224, 76);
            this.txtTaxa.Name = "txtTaxa";
            this.txtTaxa.Size = new System.Drawing.Size(100, 26);
            this.txtTaxa.TabIndex = 6;
            this.txtTaxa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtMeses
            // 
            this.txtMeses.BackColor = System.Drawing.Color.White;
            this.txtMeses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtMeses.Location = new System.Drawing.Point(225, 108);
            this.txtMeses.Name = "txtMeses";
            this.txtMeses.ReadOnly = true;
            this.txtMeses.Size = new System.Drawing.Size(100, 26);
            this.txtMeses.TabIndex = 7;
            this.txtMeses.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPagamento
            // 
            this.txtPagamento.BackColor = System.Drawing.Color.Gray;
            this.txtPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPagamento.Location = new System.Drawing.Point(225, 140);
            this.txtPagamento.Name = "txtPagamento";
            this.txtPagamento.ReadOnly = true;
            this.txtPagamento.Size = new System.Drawing.Size(100, 26);
            this.txtPagamento.TabIndex = 8;
            this.txtPagamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPagamento.TextChanged += new System.EventHandler(this.txtPagamento_TextChanged);
            // 
            // txtAnalise
            // 
            this.txtAnalise.BackColor = System.Drawing.Color.White;
            this.txtAnalise.Font = new System.Drawing.Font("Courier New", 10F);
            this.txtAnalise.Location = new System.Drawing.Point(370, 52);
            this.txtAnalise.Multiline = true;
            this.txtAnalise.Name = "txtAnalise";
            this.txtAnalise.ReadOnly = true;
            this.txtAnalise.Size = new System.Drawing.Size(203, 114);
            this.txtAnalise.TabIndex = 9;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCalcular.Location = new System.Drawing.Point(38, 172);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(286, 30);
            this.btnCalcular.TabIndex = 10;
            this.btnCalcular.Text = "Calcular Pagamento Mensal";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Enabled = false;
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnNovo.Location = new System.Drawing.Point(38, 205);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(286, 30);
            this.btnNovo.TabIndex = 11;
            this.btnNovo.Text = "Novo Empréstimo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSair.Location = new System.Drawing.Point(513, 205);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 30);
            this.btnSair.TabIndex = 12;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // btnMeses
            // 
            this.btnMeses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnMeses.Location = new System.Drawing.Point(331, 111);
            this.btnMeses.Name = "btnMeses";
            this.btnMeses.Size = new System.Drawing.Size(33, 23);
            this.btnMeses.TabIndex = 13;
            this.btnMeses.Text = "X";
            this.btnMeses.UseVisualStyleBackColor = true;
            this.btnMeses.Click += new System.EventHandler(this.btnMeses_Click);
            // 
            // btnPagamentos
            // 
            this.btnPagamentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnPagamentos.Location = new System.Drawing.Point(330, 143);
            this.btnPagamentos.Name = "btnPagamentos";
            this.btnPagamentos.Size = new System.Drawing.Size(33, 23);
            this.btnPagamentos.TabIndex = 14;
            this.btnPagamentos.Text = "X";
            this.btnPagamentos.UseVisualStyleBackColor = true;
            this.btnPagamentos.Click += new System.EventHandler(this.btnPagamentos_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 247);
            this.Controls.Add(this.btnPagamentos);
            this.Controls.Add(this.btnMeses);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtAnalise);
            this.Controls.Add(this.txtPagamento);
            this.Controls.Add(this.txtMeses);
            this.Controls.Add(this.txtTaxa);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.lblAnalise);
            this.Controls.Add(this.lblMensal);
            this.Controls.Add(this.lblPagamentos);
            this.Controls.Add(this.lblTaxa);
            this.Controls.Add(this.lblSaldo);
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assistente de Empréstimo";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label lblTaxa;
        private System.Windows.Forms.Label lblPagamentos;
        private System.Windows.Forms.Label lblMensal;
        private System.Windows.Forms.Label lblAnalise;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.TextBox txtTaxa;
        private System.Windows.Forms.TextBox txtMeses;
        private System.Windows.Forms.TextBox txtPagamento;
        private System.Windows.Forms.TextBox txtAnalise;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnMeses;
        private System.Windows.Forms.Button btnPagamentos;
    }
}

