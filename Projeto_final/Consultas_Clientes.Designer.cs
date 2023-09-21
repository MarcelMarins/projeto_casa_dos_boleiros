/*
 * Criado por SharpDevelop.
 * Usuário: aluno
 * Data: 30/10/2018
 * Hora: 13:52
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace Projeto_Final
{
	partial class Consultas_Clientes
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consultas_Clientes));
			this.produtos = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// produtos
			// 
			this.produtos.BackColor = System.Drawing.Color.Transparent;
			this.produtos.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.produtos.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.produtos.Location = new System.Drawing.Point(79, 53);
			this.produtos.Name = "produtos";
			this.produtos.Size = new System.Drawing.Size(335, 45);
			this.produtos.TabIndex = 5;
			this.produtos.Text = "Consulta de clientes";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label1.Location = new System.Drawing.Point(22, 191);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(179, 30);
			this.label1.TabIndex = 6;
			this.label1.Text = "Número do cliente: ";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(193, 191);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(303, 20);
			this.textBox1.TabIndex = 7;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.Black;
			this.button1.Location = new System.Drawing.Point(346, 304);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(134, 33);
			this.button1.TabIndex = 8;
			this.button1.Text = "CONSULTAR";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.ForeColor = System.Drawing.Color.Black;
			this.button2.Location = new System.Drawing.Point(43, 304);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(95, 33);
			this.button2.TabIndex = 9;
			this.button2.Text = "VOLTAR";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// Consultas_Clientes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(530, 445);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.produtos);
			this.ForeColor = System.Drawing.Color.Brown;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Consultas_Clientes";
			this.Text = "Consultas_Clientes";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label produtos;
	}
}
