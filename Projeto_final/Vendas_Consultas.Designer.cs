/*
 * Criado por SharpDevelop.
 * Usuário: Aluno
 * Data: 05/11/2018
 * Hora: 12:57
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace Projeto_Final
{
	partial class Vendas_Consultas
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vendas_Consultas));
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.produtos = new System.Windows.Forms.Label();
			this.btn_consultar = new System.Windows.Forms.Button();
			this.btn_voltar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(227, 196);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(295, 20);
			this.textBox3.TabIndex = 22;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(227, 154);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(295, 20);
			this.textBox2.TabIndex = 21;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(227, 111);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(295, 20);
			this.textBox1.TabIndex = 20;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label3.Location = new System.Drawing.Point(23, 190);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(198, 25);
			this.label3.TabIndex = 19;
			this.label3.Text = "Código do produto:";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label2.Location = new System.Drawing.Point(23, 106);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(198, 25);
			this.label2.TabIndex = 18;
			this.label2.Text = "Número do cliente:";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label1.Location = new System.Drawing.Point(23, 148);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(198, 25);
			this.label1.TabIndex = 17;
			this.label1.Text = "Nome do cliente:";
			// 
			// produtos
			// 
			this.produtos.BackColor = System.Drawing.Color.Transparent;
			this.produtos.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.produtos.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.produtos.Location = new System.Drawing.Point(151, 39);
			this.produtos.Name = "produtos";
			this.produtos.Size = new System.Drawing.Size(311, 42);
			this.produtos.TabIndex = 16;
			this.produtos.Text = "Cadastro de vendas";
			// 
			// btn_consultar
			// 
			this.btn_consultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_consultar.Location = new System.Drawing.Point(363, 257);
			this.btn_consultar.Name = "btn_consultar";
			this.btn_consultar.Size = new System.Drawing.Size(126, 33);
			this.btn_consultar.TabIndex = 23;
			this.btn_consultar.Text = "Consultar";
			this.btn_consultar.UseVisualStyleBackColor = true;
			// 
			// btn_voltar
			// 
			this.btn_voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_voltar.ForeColor = System.Drawing.Color.Black;
			this.btn_voltar.Location = new System.Drawing.Point(50, 257);
			this.btn_voltar.Name = "btn_voltar";
			this.btn_voltar.Size = new System.Drawing.Size(95, 33);
			this.btn_voltar.TabIndex = 26;
			this.btn_voltar.Text = "VOLTAR";
			this.btn_voltar.UseVisualStyleBackColor = true;
			this.btn_voltar.Click += new System.EventHandler(this.Btn_voltarClick);
			// 
			// Vendas_Consultas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(563, 308);
			this.Controls.Add(this.btn_voltar);
			this.Controls.Add(this.btn_consultar);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.produtos);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Vendas_Consultas";
			this.Text = "Vendas_Consultas";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		private System.Windows.Forms.Button btn_voltar;
		private System.Windows.Forms.Button btn_consultar;
		private System.Windows.Forms.Label produtos;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
	}
}
