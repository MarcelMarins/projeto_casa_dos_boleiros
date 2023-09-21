/*
 * Criado por SharpDevelop.
 * Usuário: alfredao
 * Data: 23/10/2018
 * Hora: 13:52
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Projeto_Final
{
	/// <summary>
	/// Description of lbl_menu.
	/// </summary>
	public partial class frm_menu : Form
	{
		public frm_menu()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void ToolStripTextBox1Click(object sender, EventArgs e)
		{
			
		}
		
		void ClientesToolStripMenuItemClick(object sender, EventArgs e)
		{
				Cadastro_Clientes flog = new Cadastro_Clientes();
				flog.Show();
				this.Visible = false;
		}
		
		void SairToolStripMenuItemClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
		void ProdutosClick(object sender, EventArgs e)
		{
			cadastro_de_produtos flog = new cadastro_de_produtos();
			flog.Show();
			this.Visible = false;
		}
		
		void FuncionáriosToolStripMenuItemClick(object sender, EventArgs e)
		{
			cadastrar_funcionários flog = new cadastrar_funcionários();
				flog.Show();
				this.Visible = false ;
		}
		
		void FornecedoresToolStripMenuItemClick(object sender, EventArgs e)
		{
				cadastro_fornecedor flog = new cadastro_fornecedor();
				flog.Show();
				this.Visible = false ;
		}
		
		void ClientesToolStripMenuItem1Click(object sender, EventArgs e)
		{
			Consultas_Clientes flog = new Consultas_Clientes();
			flog.Show();
			this.Visible = false;
		}
		
		void FuncionáriosToolStripMenuItem1Click(object sender, EventArgs e)
		{
			Consultas_Funcionários flog = new Consultas_Funcionários();
			flog.Show();
			this.Visible = false;
		}
		
		void FornecedoresToolStripMenuItem1Click(object sender, EventArgs e)
		{
			Consultas_Fornecedores flog = new Consultas_Fornecedores();
			flog.Show();
			this.Visible = false;
		}
		
		void ProdutosToolStripMenuItem1Click(object sender, EventArgs e)
		{
			Consultas_Produtos flog = new Consultas_Produtos();
			flog.Show();
			this.Visible = false;
		}
		
		void CancelarToolStripMenuItem1Click(object sender, EventArgs e)
		{
			MessageBox.Show("Compras canceladas!");
		}
		
		
		void CancelarToolStripMenuItemClick(object sender, EventArgs e)
		{
			MessageBox.Show("Compras canceladas!"); 
		}
		
		void Ico_clienteClick(object sender, EventArgs e)
		{
			Cadastro_Clientes flog = new Cadastro_Clientes();
				flog.Show();
				this.Visible = false;
		}
		
		void Ico_funcionarioClick(object sender, EventArgs e)
		{
			cadastrar_funcionários flog = new cadastrar_funcionários();
				flog.Show();
				this.Visible = false ;
		}
		
		void Ico_fornecedorClick(object sender, EventArgs e)
		{
			cadastro_fornecedor flog = new cadastro_fornecedor();
				flog.Show();
				this.Visible = false;
		}
		
		void Ico_produtosClick(object sender, EventArgs e)
		{
			cadastro_de_produtos flog = new cadastro_de_produtos();
			flog.Show();
			this.Visible = false;
		}
		
		
		
		void CadastrarToolStripMenuItemClick(object sender, EventArgs e)
		{
			Compras_Cadastro flog = new Compras_Cadastro();
			flog.Show();
			this.Visible = false;
		}
		
		void Ico_compraClick(object sender, EventArgs e)
		{
			Compras_Cadastro flog = new Compras_Cadastro();
			flog.Show();
			this.Visible = false;
		}
		
		void CadastrarToolStripMenuItem1Click(object sender, EventArgs e)
		{
			Vendas_Produto flog = new Vendas_Produto();
			flog.Show();
			this.Visible = false;
		}
		
		void Ico_vendasClick(object sender, EventArgs e)
		{
			Vendas_Produto flog = new Vendas_Produto();
			flog.Show();
			this.Visible = false;
		}
		
		void Ico_exitClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		void Frm_menuLoad(object sender, EventArgs e)
		{
	
		}
		
		void Pro_nacClick(object sender, EventArgs e)
		{
			cat_brasil flog = new cat_brasil ();
			flog.Show();
			this.Visible = false;
		}
		
		void Tip_europeuClick(object sender, EventArgs e)
		{
			cat_europeus flog = new cat_europeus();
			flog.Show();
			this.Visible = false;
		}
		
		void Tip_invernoClick(object sender, EventArgs e)
		{
			Cat_Inverno flog = new Cat_Inverno();
			flog.Show();
			this.Visible = false;
		}
		
		void Tip_femininoClick(object sender, EventArgs e)
		{
			Cat_Feminino flog = new Cat_Feminino();
			flog.Show();
			this.Visible = false;
		}
		
		void Tip_acessoriosClick(object sender, EventArgs e)
		{
			Cat_Acessorios flog = new Cat_Acessorios();
			flog.Show();
			this.Visible = false;
		}
		
		void Tip_jogoClick(object sender, EventArgs e)
		{
			Cat_Jogo flog = new Cat_Jogo();
			flog.Show();
			this.Visible = false;
		}
		
		void PedidosToolStripMenuItemClick(object sender, EventArgs e)
		{
			Compras_Pedidos flog = new Compras_Pedidos();
			flog.Show();
			this.Visible = false;
		}
		
		void Tip_americasClick(object sender, EventArgs e)
		{
			cat_sulamerica flog = new cat_sulamerica();
			flog.Show();
			this.Visible = false;
		}
		
		void Tip_selecaoClick(object sender, EventArgs e)
		{
			Cat_Seleções flog = new Cat_Seleções();
			flog.Show();
			this.Visible = false;
		}
		
		void LogoClick(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start ( "https://boleirosdacasa.blogspot.com" );
		}
		
		void ProdutosToolStripMenuItemClick(object sender, EventArgs e)
		{
			cadastro_de_produtos flog = new cadastro_de_produtos();
			flog.Show();
			this.Visible = false;
		}
		
		void ConsultarToolStripMenuItemClick(object sender, EventArgs e)
		{
			Consulta_Compra flog = new Consulta_Compra();
			flog.Show();
			this.Visible = false;
		}
	}
}
