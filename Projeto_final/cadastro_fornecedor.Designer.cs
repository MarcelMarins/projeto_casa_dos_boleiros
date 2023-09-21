/*
 * Criado por SharpDevelop.
 * Usuário: Aluno
 * Data: 29/10/2018
 * Hora: 14:54
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace Projeto_Final
{
	partial class cadastro_fornecedor
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadastro_fornecedor));
			this.btn_final = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.lbl_01 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btn_final
			// 
			this.btn_final.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_final.Location = new System.Drawing.Point(182, 307);
			this.btn_final.Name = "btn_final";
			this.btn_final.Size = new System.Drawing.Size(148, 50);
			this.btn_final.TabIndex = 35;
			this.btn_final.Text = "FINALIZAR";
			this.btn_final.UseVisualStyleBackColor = true;
			this.btn_final.Click += new System.EventHandler(this.Btn_finalClick);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(201, 127);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(300, 20);
			this.textBox1.TabIndex = 26;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label7.Location = new System.Drawing.Point(29, 31);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(525, 52);
			this.label7.TabIndex = 25;
			this.label7.Text = "CADASTRO DE FORNECEDOR";
			// 
			// lbl_01
			// 
			this.lbl_01.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_01.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lbl_01.Location = new System.Drawing.Point(29, 123);
			this.lbl_01.Name = "lbl_01";
			this.lbl_01.Size = new System.Drawing.Size(181, 28);
			this.lbl_01.TabIndex = 18;
			this.lbl_01.Text = "Nome da empresa: ";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(201, 172);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(300, 20);
			this.textBox2.TabIndex = 37;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label1.Location = new System.Drawing.Point(65, 167);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(141, 28);
			this.label1.TabIndex = 36;
			this.label1.Text = "Representante: ";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(221, 210);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(300, 20);
			this.textBox3.TabIndex = 39;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label2.Location = new System.Drawing.Point(137, 208);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(69, 28);
			this.label2.TabIndex = 38;
			this.label2.Text = "CNPJ :";
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(252, 252);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(255, 20);
			this.textBox4.TabIndex = 41;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label3.Location = new System.Drawing.Point(48, 247);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(207, 28);
			this.label3.TabIndex = 40;
			this.label3.Text = "Endereço da empresa: ";
			// 
			// cadastro_fornecedor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(589, 369);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btn_final);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.lbl_01);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "cadastro_fornecedor";
			this.Text = "cadastro_fornecedor";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label lbl_01;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button btn_final;
	}
}
