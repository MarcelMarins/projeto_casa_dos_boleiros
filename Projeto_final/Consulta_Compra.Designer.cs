/*
 * Criado por SharpDevelop.
 * Usuário: aluno
 * Data: 30/10/2018
 * Hora: 14:52
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace Projeto_Final
{
	partial class Consulta_Compra
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consulta_Compra));
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.btn_voltar = new System.Windows.Forms.Button();
			this.btn_consulta = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.produtos = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(282, 152);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(310, 20);
			this.textBox1.TabIndex = 21;
			// 
			// btn_voltar
			// 
			this.btn_voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_voltar.Location = new System.Drawing.Point(282, 268);
			this.btn_voltar.Name = "btn_voltar";
			this.btn_voltar.Size = new System.Drawing.Size(143, 44);
			this.btn_voltar.TabIndex = 20;
			this.btn_voltar.Text = "VOLTAR";
			this.btn_voltar.UseVisualStyleBackColor = true;
			this.btn_voltar.Click += new System.EventHandler(this.Btn_voltarClick);
			// 
			// btn_consulta
			// 
			this.btn_consulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_consulta.Location = new System.Drawing.Point(282, 200);
			this.btn_consulta.Name = "btn_consulta";
			this.btn_consulta.Size = new System.Drawing.Size(143, 44);
			this.btn_consulta.TabIndex = 19;
			this.btn_consulta.Text = "CONSULTAR";
			this.btn_consulta.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label1.Location = new System.Drawing.Point(101, 147);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(178, 24);
			this.label1.TabIndex = 16;
			this.label1.Text = "Código da Compra:";
			// 
			// produtos
			// 
			this.produtos.BackColor = System.Drawing.Color.Transparent;
			this.produtos.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.produtos.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.produtos.Location = new System.Drawing.Point(220, 46);
			this.produtos.Name = "produtos";
			this.produtos.Size = new System.Drawing.Size(311, 42);
			this.produtos.TabIndex = 15;
			this.produtos.Text = "Cadastro de compras";
			// 
			// Consulta_Compra
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(724, 409);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.btn_voltar);
			this.Controls.Add(this.btn_consulta);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.produtos);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Consulta_Compra";
			this.Text = "Consulta_Compra";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		private System.Windows.Forms.Label produtos;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btn_consulta;
		private System.Windows.Forms.Button btn_voltar;
		private System.Windows.Forms.TextBox textBox1;
	}
}
