/*
 * Criado por SharpDevelop.
 * Usuário: aluno
 * Data: 30/10/2018
 * Hora: 14:28
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace Projeto_Final
{
	partial class Compras_Cadastro
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Compras_Cadastro));
			this.produtos = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.btn_cadastro = new System.Windows.Forms.Button();
			this.btn_voltar = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// produtos
			// 
			this.produtos.BackColor = System.Drawing.Color.Transparent;
			this.produtos.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.produtos.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.produtos.Location = new System.Drawing.Point(160, 33);
			this.produtos.Name = "produtos";
			this.produtos.Size = new System.Drawing.Size(311, 42);
			this.produtos.TabIndex = 5;
			this.produtos.Text = "Cadastro de compras";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label1.Location = new System.Drawing.Point(36, 120);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(83, 24);
			this.label1.TabIndex = 7;
			this.label1.Text = "Produto:";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label2.Location = new System.Drawing.Point(36, 164);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(146, 24);
			this.label2.TabIndex = 8;
			this.label2.Text = "Fornecedor(a):";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label3.Location = new System.Drawing.Point(36, 207);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(146, 24);
			this.label3.TabIndex = 9;
			this.label3.Text = "Categoria:";
			// 
			// btn_cadastro
			// 
			this.btn_cadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_cadastro.Location = new System.Drawing.Point(426, 305);
			this.btn_cadastro.Name = "btn_cadastro";
			this.btn_cadastro.Size = new System.Drawing.Size(143, 44);
			this.btn_cadastro.TabIndex = 10;
			this.btn_cadastro.Text = "CADASTRAR";
			this.btn_cadastro.UseVisualStyleBackColor = true;
			this.btn_cadastro.Click += new System.EventHandler(this.Btn_cadastroClick);
			// 
			// btn_voltar
			// 
			this.btn_voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_voltar.Location = new System.Drawing.Point(39, 305);
			this.btn_voltar.Name = "btn_voltar";
			this.btn_voltar.Size = new System.Drawing.Size(143, 44);
			this.btn_voltar.TabIndex = 11;
			this.btn_voltar.Text = "VOLTAR";
			this.btn_voltar.UseVisualStyleBackColor = true;
			this.btn_voltar.Click += new System.EventHandler(this.Btn_voltarClick);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(125, 124);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(310, 20);
			this.textBox1.TabIndex = 12;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(188, 169);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(310, 20);
			this.textBox2.TabIndex = 13;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(143, 212);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(310, 20);
			this.textBox3.TabIndex = 14;
			// 
			// Compras_Cadastro
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(686, 434);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.btn_voltar);
			this.Controls.Add(this.btn_cadastro);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.produtos);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Compras_Cadastro";
			this.Text = "Compras_Cadastro";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button btn_voltar;
		private System.Windows.Forms.Button btn_cadastro;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label produtos;
	}
}
