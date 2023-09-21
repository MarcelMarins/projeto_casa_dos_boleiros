/*
 * Criado por SharpDevelop.
 * Usuário: Aluno
 * Data: 29/10/2018
 * Hora: 15:02
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Projeto_Final
{
	/// <summary>
	/// Description of cadastro_de_produtos.
	/// </summary>
	public partial class cadastro_de_produtos : Form
	{
		public cadastro_de_produtos()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Btn_finalClick(object sender, EventArgs e)
		{
			MessageBox.Show ("Cadastro do produto feito!");
				btn_final.Enabled = true;
				frm_menu flog = new frm_menu();
				flog.Show();
				this.Visible = false ;
		}
	}
}
