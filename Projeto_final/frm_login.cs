/*
 * Criado por SharpDevelop.
 * Usuário: alfredao
 * Data: 23/10/2018
 * Hora: 15:24
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Projeto_Final
{
	/// <summary>
	/// Description of frm_login.
	/// </summary>
	public partial class frm_login : Form
	{
		public frm_login()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Btn_entrarClick(object sender, EventArgs e)
		{
			if ((txt_user.Text == "Marcel")  && (txt_pass.Text == "123"))
			{
				MessageBox.Show ("Login concluído com sucesso!");
				btn_entrar.Enabled = true;
				frm_menu flog = new frm_menu();
				flog.Show();
				this.Visible = false ;
			}else{
				MessageBox.Show ("Login ou senha inválida!");
			}
		}
		
		void Btn_sairClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void LogoClick(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start ( "https://boleirosdacasa.blogspot.com" );
		}

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
