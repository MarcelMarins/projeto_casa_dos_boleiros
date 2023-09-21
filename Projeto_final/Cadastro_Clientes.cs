/*
 * Criado por SharpDevelop.
 * Usuário: Aluno
 * Data: 29/10/2018
 * Hora: 14:22
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Projeto_Final
{
	/// <summary>
	/// Description of Cadastro_Clientes.
	/// </summary>
	public partial class Cadastro_Clientes : Form
	{
		public Cadastro_Clientes()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			MessageBox.Show ("Cadastro do cliente feito!");
				btn_final.Enabled = true;
				frm_menu flog = new frm_menu();
				flog.Show();
				this.Visible = false ;
		}
	}
}
