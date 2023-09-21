/*
 * Criado por SharpDevelop.
 * Usuário: alfredao
 * Data: 06/11/2018
 * Hora: 14:27
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Projeto_Final
{
	/// <summary>
	/// Description of cat_europeus.
	/// </summary>
	public partial class cat_europeus : Form
	{
		public cat_europeus()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void LogoClick(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start ( "https://boleirosdacasa.blogspot.com" );
		}
	}
}
