/*
 * Criado por SharpDevelop.
 * Usuário: Aluno
 * Data: 22/10/2018
 * Hora: 14:43
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Projeto_Final
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void ProgressBar1Click(object sender, EventArgs e)
		{
			
		}
		
		void Timer1Tick(object sender, EventArgs e)
		{
			if (pgBar1.Value < 100)
			{
				pgBar1.Value = pgBar1.Value + 2;
			}else{
				timer1.Enabled = false;
				frm_login exi = new frm_login();
				exi.Show();
				this.Visible = false ;
			}
			}
		
		void PictureBox1Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start ( "https://boleirosdacasa.blogspot.com" );
		}
		}

}
