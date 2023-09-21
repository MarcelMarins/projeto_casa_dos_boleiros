/*
 * Criado por SharpDevelop.
 * Usuário: aluno
 * Data: 30/10/2018
 * Hora: 14:17
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Projeto_Final
{
	/// <summary>
	/// Description of Consulta_Estoque.
	/// </summary>
	public partial class Consulta_Estoque : Form
	{
		public Consulta_Estoque()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Btn_voltarClick(object sender, EventArgs e)
		{
			btn_voltar.Enabled = true;
				frm_menu flog = new frm_menu();
				flog.Show();
				this.Visible = false ;
		}
	}
}
