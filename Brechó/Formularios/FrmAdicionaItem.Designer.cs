namespace Brechó
{
    partial class FrmAdicionaItem
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Prodcod = new System.Windows.Forms.TextBox();
            this.btn_Adiciona = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Valorcompra = new System.Windows.Forms.TextBox();
            this.btn_Pagamento = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecionar itens";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código do produto:";
            // 
            // txt_Prodcod
            // 
            this.txt_Prodcod.Location = new System.Drawing.Point(214, 81);
            this.txt_Prodcod.Name = "txt_Prodcod";
            this.txt_Prodcod.Size = new System.Drawing.Size(153, 20);
            this.txt_Prodcod.TabIndex = 2;
            // 
            // btn_Adiciona
            // 
            this.btn_Adiciona.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Adiciona.Location = new System.Drawing.Point(373, 81);
            this.btn_Adiciona.Name = "btn_Adiciona";
            this.btn_Adiciona.Size = new System.Drawing.Size(75, 23);
            this.btn_Adiciona.TabIndex = 3;
            this.btn_Adiciona.Text = "Adicionar";
            this.btn_Adiciona.UseVisualStyleBackColor = true;
            this.btn_Adiciona.Click += new System.EventHandler(this.btn_Adiciona_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Valor da compra:";
            // 
            // txt_Valorcompra
            // 
            this.txt_Valorcompra.Location = new System.Drawing.Point(197, 147);
            this.txt_Valorcompra.Name = "txt_Valorcompra";
            this.txt_Valorcompra.Size = new System.Drawing.Size(153, 20);
            this.txt_Valorcompra.TabIndex = 5;
            // 
            // btn_Pagamento
            // 
            this.btn_Pagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Pagamento.Location = new System.Drawing.Point(160, 211);
            this.btn_Pagamento.Name = "btn_Pagamento";
            this.btn_Pagamento.Size = new System.Drawing.Size(136, 39);
            this.btn_Pagamento.TabIndex = 6;
            this.btn_Pagamento.Text = "Ir para pagamento";
            this.btn_Pagamento.UseVisualStyleBackColor = true;
            this.btn_Pagamento.Click += new System.EventHandler(this.btn_Pagamento_Click);
            // 
            // FrmAdicionaItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 289);
            this.Controls.Add(this.btn_Pagamento);
            this.Controls.Add(this.txt_Valorcompra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Adiciona);
            this.Controls.Add(this.txt_Prodcod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmAdicionaItem";
            this.Text = "FrmAdicionaItem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Prodcod;
        private System.Windows.Forms.Button btn_Adiciona;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Valorcompra;
        private System.Windows.Forms.Button btn_Pagamento;
    }
}