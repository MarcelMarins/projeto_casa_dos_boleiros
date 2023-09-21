/*
 * Criado por SharpDevelop.
 * Usuário: Aluno
 * Data: 29/10/2018
 * Hora: 15:02
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace Projeto_Final
{
	partial class cadastro_de_produtos
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadastro_de_produtos));
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.lbl_01 = new System.Windows.Forms.Label();
			this.btn_final = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(165, 223);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(237, 20);
			this.textBox4.TabIndex = 22;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(165, 197);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(237, 20);
			this.textBox3.TabIndex = 21;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(165, 166);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(237, 20);
			this.textBox2.TabIndex = 20;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(165, 135);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(237, 20);
			this.textBox1.TabIndex = 19;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label7.Location = new System.Drawing.Point(50, 41);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(471, 52);
			this.label7.TabIndex = 18;
			this.label7.Text = "CADASTRO DE PRODUTOS";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label3.Location = new System.Drawing.Point(48, 192);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(185, 28);
			this.label3.TabIndex = 16;
			this.label3.Text = "Categoria:";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label2.Location = new System.Drawing.Point(48, 221);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(88, 28);
			this.label2.TabIndex = 15;
			this.label2.Text = "Preço:";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label1.Location = new System.Drawing.Point(48, 161);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(129, 28);
			this.label1.TabIndex = 14;
			this.label1.Text = "Empresa:";
			// 
			// lbl_01
			// 
			this.lbl_01.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_01.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lbl_01.Location = new System.Drawing.Point(48, 130);
			this.lbl_01.Name = "lbl_01";
			this.lbl_01.Size = new System.Drawing.Size(100, 28);
			this.lbl_01.TabIndex = 13;
			this.lbl_01.Text = "Nome:";
			// 
			// btn_final
			// 
			this.btn_final.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_final.Location = new System.Drawing.Point(191, 284);
			this.btn_final.Name = "btn_final";
			this.btn_final.Size = new System.Drawing.Size(148, 50);
			this.btn_final.TabIndex = 23;
			this.btn_final.Text = "FINALIZAR";
			this.btn_final.UseVisualStyleBackColor = true;
			this.btn_final.Click += new System.EventHandler(this.Btn_finalClick);
			// 
			// cadastro_de_produtos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(540, 346);
			this.Controls.Add(this.btn_final);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lbl_01);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "cadastro_de_produtos";
			this.Text = "cadastro_de_produtos";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		private System.Windows.Forms.Button btn_final;
		private System.Windows.Forms.Label lbl_01;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
	}
}
