/*
 * Criado por SharpDevelop.
 * Usuário: aluno
 * Data: 30/10/2018
 * Hora: 14:28
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Projeto_Final
{
	/// <summary>
	/// Description of Compras_Cadastro.
	/// </summary>
	public partial class Compras_Cadastro : Form
	{
		public Compras_Cadastro()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Btn_cadastroClick(object sender, EventArgs e)
		{
			MessageBox.Show ("Cadastro feito com sucesso!");
				btn_cadastro.Enabled = true;
				frm_menu flog = new frm_menu();
				flog.Show();
				this.Visible = false ;
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
