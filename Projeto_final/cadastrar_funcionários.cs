/*
 * Criado por SharpDevelop.
 * Usuário: Aluno
 * Data: 29/10/2018
 * Hora: 14:40
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Projeto_Final
{
	/// <summary>
	/// Description of cadastrar_funcionários.
	/// </summary>
	public partial class cadastrar_funcionários : Form
	{
		public cadastrar_funcionários()
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
			MessageBox.Show ("Cadastro do funcionário feito!");
				btn_final.Enabled = true;
				frm_menu flog = new frm_menu();
				flog.Show();
				this.Visible = false ;
		}
	}
}
