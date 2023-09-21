/*
 * Criado por SharpDevelop.
 * Usuário: alfredao
 * Data: 23/10/2018
 * Hora: 15:24
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace Projeto_Final
{
	partial class frm_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_login));
            this.logo = new System.Windows.Forms.PictureBox();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.lbl_senha = new System.Windows.Forms.Label();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_entrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logo.ErrorImage = ((System.Drawing.Image)(resources.GetObject("logo.ErrorImage")));
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.InitialImage = ((System.Drawing.Image)(resources.GetObject("logo.InitialImage")));
            this.logo.Location = new System.Drawing.Point(151, 24);
            this.logo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(368, 161);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 1;
            this.logo.TabStop = false;
            this.logo.Click += new System.EventHandler(this.LogoClick);
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usuario.Location = new System.Drawing.Point(32, 212);
            this.lbl_usuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(133, 28);
            this.lbl_usuario.TabIndex = 2;
            this.lbl_usuario.Text = "Usuário:";
            // 
            // lbl_senha
            // 
            this.lbl_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_senha.Location = new System.Drawing.Point(32, 270);
            this.lbl_senha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_senha.Name = "lbl_senha";
            this.lbl_senha.Size = new System.Drawing.Size(133, 28);
            this.lbl_senha.TabIndex = 3;
            this.lbl_senha.Text = "Senha:";
            // 
            // txt_user
            // 
            this.txt_user.Location = new System.Drawing.Point(151, 219);
            this.txt_user.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(367, 22);
            this.txt_user.TabIndex = 4;
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(151, 273);
            this.txt_pass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(367, 22);
            this.txt_pass.TabIndex = 5;
            // 
            // btn_sair
            // 
            this.btn_sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sair.Location = new System.Drawing.Point(63, 326);
            this.btn_sair.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(103, 41);
            this.btn_sair.TabIndex = 6;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.Btn_sairClick);
            // 
            // btn_entrar
            // 
            this.btn_entrar.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.btn_entrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_entrar.Location = new System.Drawing.Point(400, 326);
            this.btn_entrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_entrar.Name = "btn_entrar";
            this.btn_entrar.Size = new System.Drawing.Size(103, 41);
            this.btn_entrar.TabIndex = 7;
            this.btn_entrar.Text = "Entrar";
            this.btn_entrar.UseVisualStyleBackColor = true;
            this.btn_entrar.Click += new System.EventHandler(this.Btn_entrarClick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(529, 241);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 36);
            this.label1.TabIndex = 8;
            this.label1.Text = "Login: Marcel\r\nSenha: 123";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(657, 405);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_entrar);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.lbl_senha);
            this.Controls.Add(this.lbl_usuario);
            this.Controls.Add(this.logo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		private System.Windows.Forms.TextBox txt_user;
		private System.Windows.Forms.TextBox txt_pass;
		private System.Windows.Forms.Button btn_entrar;
		private System.Windows.Forms.Button btn_sair;
		private System.Windows.Forms.Label lbl_senha;
		private System.Windows.Forms.Label lbl_usuario;
		private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label label1;
    }
}
