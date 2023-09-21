/*
 * Criado por SharpDevelop.
 * Usuário: Aluno
 * Data: 05/11/2018
 * Hora: 12:57
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Projeto_Final
{
	/// <summary>
	/// Description of Vendas_Consultas.
	/// </summary>
	public partial class Vendas_Consultas : Form
	{
		public Vendas_Consultas()
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
				this.Visible = false;
		}
	}
}
