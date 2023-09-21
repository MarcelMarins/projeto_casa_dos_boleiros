/*
 * Criado por SharpDevelop.
 * Usuário: aluno
 * Data: 30/10/2018
 * Hora: 14:08
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace Projeto_Final
{
	partial class Consultas_Fornecedores
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consultas_Fornecedores));
			this.btn_voltar = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.produtos = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btn_voltar
			// 
			this.btn_voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_voltar.ForeColor = System.Drawing.Color.Black;
			this.btn_voltar.Location = new System.Drawing.Point(61, 298);
			this.btn_voltar.Name = "btn_voltar";
			this.btn_voltar.Size = new System.Drawing.Size(95, 33);
			this.btn_voltar.TabIndex = 19;
			this.btn_voltar.Text = "VOLTAR";
			this.btn_voltar.UseVisualStyleBackColor = true;
			this.btn_voltar.Click += new System.EventHandler(this.Btn_voltarClick);
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.Black;
			this.button1.Location = new System.Drawing.Point(364, 298);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(134, 33);
			this.button1.TabIndex = 18;
			this.button1.Text = "CONSULTAR";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(238, 185);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(275, 20);
			this.textBox1.TabIndex = 17;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label1.Location = new System.Drawing.Point(26, 180);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(227, 30);
			this.label1.TabIndex = 16;
			this.label1.Text = "Número do fornecedor:";
			// 
			// produtos
			// 
			this.produtos.BackColor = System.Drawing.Color.Transparent;
			this.produtos.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.produtos.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.produtos.Location = new System.Drawing.Point(52, 51);
			this.produtos.Name = "produtos";
			this.produtos.Size = new System.Drawing.Size(423, 45);
			this.produtos.TabIndex = 15;
			this.produtos.Text = "Consulta de fornecedores";
			// 
			// Consultas_Fornecedores
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(539, 381);
			this.Controls.Add(this.btn_voltar);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.produtos);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Consultas_Fornecedores";
			this.Text = "Consultas_Fornecedores";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		private System.Windows.Forms.Label produtos;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button btn_voltar;
	}
}
