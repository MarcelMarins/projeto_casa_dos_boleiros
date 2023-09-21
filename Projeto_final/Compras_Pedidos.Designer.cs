/*
 * Criado por SharpDevelop.
 * Usuário: aluno
 * Data: 30/10/2018
 * Hora: 14:56
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace Projeto_Final
{
	partial class Compras_Pedidos
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Compras_Pedidos));
			this.btn_voltar = new System.Windows.Forms.Button();
			this.produtos = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btn_voltar
			// 
			this.btn_voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_voltar.Location = new System.Drawing.Point(227, 300);
			this.btn_voltar.Name = "btn_voltar";
			this.btn_voltar.Size = new System.Drawing.Size(143, 44);
			this.btn_voltar.TabIndex = 25;
			this.btn_voltar.Text = "VOLTAR";
			this.btn_voltar.UseVisualStyleBackColor = true;
			this.btn_voltar.Click += new System.EventHandler(this.Btn_voltarClick);
			// 
			// produtos
			// 
			this.produtos.BackColor = System.Drawing.Color.Transparent;
			this.produtos.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.produtos.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.produtos.Location = new System.Drawing.Point(161, 45);
			this.produtos.Name = "produtos";
			this.produtos.Size = new System.Drawing.Size(281, 42);
			this.produtos.TabIndex = 22;
			this.produtos.Text = "Pedidos Realizados";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label1.Location = new System.Drawing.Point(236, 142);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(91, 42);
			this.label1.TabIndex = 26;
			this.label1.Text = "Camisa";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label2.Location = new System.Drawing.Point(236, 184);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(91, 42);
			this.label2.TabIndex = 27;
			this.label2.Text = "Boné";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label3.Location = new System.Drawing.Point(236, 226);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(91, 42);
			this.label3.TabIndex = 28;
			this.label3.Text = "Jaqueta";
			// 
			// Compras_Pedidos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(583, 423);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btn_voltar);
			this.Controls.Add(this.produtos);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Compras_Pedidos";
			this.Text = "Compras_Pedidos";
			this.ResumeLayout(false);

		}
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label produtos;
		private System.Windows.Forms.Button btn_voltar;
	}
}
