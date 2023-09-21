/*
 * Criado por SharpDevelop.
 * Usuário: alfredao
 * Data: 06/11/2018
 * Hora: 14:05
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Projeto_Final
{
	/// <summary>
	/// Description of cat_brasil.
	/// </summary>
	public partial class cat_brasil : Form
	{
		public cat_brasil()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Cat_brasilLoad(object sender, EventArgs e)
		{
			
		}
		
		void Btn_voltarClick(object sender, EventArgs e)
		{
			frm_menu flog = new frm_menu();
			flog.Show();
			this.Visible = false;
		}
		
		void LogoClick(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start ( "https://boleirosdacasa.blogspot.com" );
		}
	}
}
