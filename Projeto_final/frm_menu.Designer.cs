/*
 * Criado por SharpDevelop.
 * Usuário: alfredao
 * Data: 23/10/2018
 * Hora: 13:52
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace Projeto_Final
{
	partial class frm_menu
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_menu));
			this.logo = new System.Windows.Forms.PictureBox();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.funcionáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.fornecedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.clientesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.funcionáriosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.fornecedoresToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.produtosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.estoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.comprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.consultasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.pedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cancelarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cadastrarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cancelarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.produtos = new System.Windows.Forms.Label();
			this.ico_fornecedores = new System.Windows.Forms.ToolStrip();
			this.ico_cliente = new System.Windows.Forms.ToolStripButton();
			this.ico_funcionario = new System.Windows.Forms.ToolStripButton();
			this.ico_fornecedor = new System.Windows.Forms.ToolStripButton();
			this.ico_produtos = new System.Windows.Forms.ToolStripButton();
			this.ico_compra = new System.Windows.Forms.ToolStripButton();
			this.ico_vendas = new System.Windows.Forms.ToolStripButton();
			this.ico_exit = new System.Windows.Forms.ToolStripButton();
			this.pro_nac = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tip_europeu = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.tip_feminino = new System.Windows.Forms.PictureBox();
			this.label4 = new System.Windows.Forms.Label();
			this.tip_acessorios = new System.Windows.Forms.PictureBox();
			this.label5 = new System.Windows.Forms.Label();
			this.tip_inverno = new System.Windows.Forms.PictureBox();
			this.label6 = new System.Windows.Forms.Label();
			this.tip_jogo = new System.Windows.Forms.PictureBox();
			this.label7 = new System.Windows.Forms.Label();
			this.tip_americas = new System.Windows.Forms.PictureBox();
			this.label8 = new System.Windows.Forms.Label();
			this.tip_selecao = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.ico_fornecedores.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pro_nac)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tip_europeu)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tip_feminino)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tip_acessorios)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tip_inverno)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tip_jogo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tip_americas)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tip_selecao)).BeginInit();
			this.SuspendLayout();
			// 
			// logo
			// 
			this.logo.BackColor = System.Drawing.Color.Transparent;
			this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.logo.ErrorImage = ((System.Drawing.Image)(resources.GetObject("logo.ErrorImage")));
			this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
			this.logo.InitialImage = ((System.Drawing.Image)(resources.GetObject("logo.InitialImage")));
			this.logo.Location = new System.Drawing.Point(214, 69);
			this.logo.Name = "logo";
			this.logo.Size = new System.Drawing.Size(276, 131);
			this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.logo.TabIndex = 0;
			this.logo.TabStop = false;
			this.logo.Click += new System.EventHandler(this.LogoClick);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.cadastroToolStripMenuItem,
									this.consultasToolStripMenuItem,
									this.comprasToolStripMenuItem,
									this.vendasToolStripMenuItem,
									this.sairToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(736, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// cadastroToolStripMenuItem
			// 
			this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.clientesToolStripMenuItem,
									this.funcionáriosToolStripMenuItem,
									this.fornecedoresToolStripMenuItem,
									this.produtosToolStripMenuItem});
			this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
			this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
			this.cadastroToolStripMenuItem.Text = "Cadastro";
			// 
			// clientesToolStripMenuItem
			// 
			this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
			this.clientesToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
			this.clientesToolStripMenuItem.Text = "Clientes";
			this.clientesToolStripMenuItem.Click += new System.EventHandler(this.ClientesToolStripMenuItemClick);
			// 
			// funcionáriosToolStripMenuItem
			// 
			this.funcionáriosToolStripMenuItem.Name = "funcionáriosToolStripMenuItem";
			this.funcionáriosToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
			this.funcionáriosToolStripMenuItem.Text = "Funcionários";
			this.funcionáriosToolStripMenuItem.Click += new System.EventHandler(this.FuncionáriosToolStripMenuItemClick);
			// 
			// fornecedoresToolStripMenuItem
			// 
			this.fornecedoresToolStripMenuItem.Name = "fornecedoresToolStripMenuItem";
			this.fornecedoresToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
			this.fornecedoresToolStripMenuItem.Text = "Fornecedores";
			this.fornecedoresToolStripMenuItem.Click += new System.EventHandler(this.FornecedoresToolStripMenuItemClick);
			// 
			// produtosToolStripMenuItem
			// 
			this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
			this.produtosToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
			this.produtosToolStripMenuItem.Text = "Produtos";
			this.produtosToolStripMenuItem.Click += new System.EventHandler(this.ProdutosToolStripMenuItemClick);
			// 
			// consultasToolStripMenuItem
			// 
			this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.clientesToolStripMenuItem1,
									this.funcionáriosToolStripMenuItem1,
									this.fornecedoresToolStripMenuItem1,
									this.produtosToolStripMenuItem1,
									this.estoqueToolStripMenuItem});
			this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
			this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
			this.consultasToolStripMenuItem.Text = "Consultas";
			// 
			// clientesToolStripMenuItem1
			// 
			this.clientesToolStripMenuItem1.Name = "clientesToolStripMenuItem1";
			this.clientesToolStripMenuItem1.Size = new System.Drawing.Size(145, 22);
			this.clientesToolStripMenuItem1.Text = "Clientes";
			this.clientesToolStripMenuItem1.Click += new System.EventHandler(this.ClientesToolStripMenuItem1Click);
			// 
			// funcionáriosToolStripMenuItem1
			// 
			this.funcionáriosToolStripMenuItem1.Name = "funcionáriosToolStripMenuItem1";
			this.funcionáriosToolStripMenuItem1.Size = new System.Drawing.Size(145, 22);
			this.funcionáriosToolStripMenuItem1.Text = "Funcionários";
			this.funcionáriosToolStripMenuItem1.Click += new System.EventHandler(this.FuncionáriosToolStripMenuItem1Click);
			// 
			// fornecedoresToolStripMenuItem1
			// 
			this.fornecedoresToolStripMenuItem1.Name = "fornecedoresToolStripMenuItem1";
			this.fornecedoresToolStripMenuItem1.Size = new System.Drawing.Size(145, 22);
			this.fornecedoresToolStripMenuItem1.Text = "Fornecedores";
			this.fornecedoresToolStripMenuItem1.Click += new System.EventHandler(this.FornecedoresToolStripMenuItem1Click);
			// 
			// produtosToolStripMenuItem1
			// 
			this.produtosToolStripMenuItem1.Name = "produtosToolStripMenuItem1";
			this.produtosToolStripMenuItem1.Size = new System.Drawing.Size(145, 22);
			this.produtosToolStripMenuItem1.Text = "Produtos";
			this.produtosToolStripMenuItem1.Click += new System.EventHandler(this.ProdutosToolStripMenuItem1Click);
			// 
			// estoqueToolStripMenuItem
			// 
			this.estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
			this.estoqueToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
			this.estoqueToolStripMenuItem.Text = "Estoque";
			// 
			// comprasToolStripMenuItem
			// 
			this.comprasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.cadastrarToolStripMenuItem,
									this.consultasToolStripMenuItem1,
									this.pedidosToolStripMenuItem,
									this.cancelarToolStripMenuItem});
			this.comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
			this.comprasToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
			this.comprasToolStripMenuItem.Text = "Compras";
			// 
			// cadastrarToolStripMenuItem
			// 
			this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
			this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
			this.cadastrarToolStripMenuItem.Text = "Cadastrar";
			this.cadastrarToolStripMenuItem.Click += new System.EventHandler(this.CadastrarToolStripMenuItemClick);
			// 
			// consultasToolStripMenuItem1
			// 
			this.consultasToolStripMenuItem1.Name = "consultasToolStripMenuItem1";
			this.consultasToolStripMenuItem1.Size = new System.Drawing.Size(126, 22);
			this.consultasToolStripMenuItem1.Text = "Consultas";
			// 
			// pedidosToolStripMenuItem
			// 
			this.pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
			this.pedidosToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
			this.pedidosToolStripMenuItem.Text = "Pedidos";
			this.pedidosToolStripMenuItem.Click += new System.EventHandler(this.PedidosToolStripMenuItemClick);
			// 
			// cancelarToolStripMenuItem
			// 
			this.cancelarToolStripMenuItem.Name = "cancelarToolStripMenuItem";
			this.cancelarToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
			this.cancelarToolStripMenuItem.Text = "Cancelar";
			this.cancelarToolStripMenuItem.Click += new System.EventHandler(this.CancelarToolStripMenuItemClick);
			// 
			// vendasToolStripMenuItem
			// 
			this.vendasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.cadastrarToolStripMenuItem1,
									this.consultarToolStripMenuItem,
									this.cancelarToolStripMenuItem1});
			this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
			this.vendasToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
			this.vendasToolStripMenuItem.Text = "Vendas";
			// 
			// cadastrarToolStripMenuItem1
			// 
			this.cadastrarToolStripMenuItem1.Name = "cadastrarToolStripMenuItem1";
			this.cadastrarToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
			this.cadastrarToolStripMenuItem1.Text = "Cadastrar";
			this.cadastrarToolStripMenuItem1.Click += new System.EventHandler(this.CadastrarToolStripMenuItem1Click);
			// 
			// consultarToolStripMenuItem
			// 
			this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
			this.consultarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.consultarToolStripMenuItem.Text = "Consultar";
			this.consultarToolStripMenuItem.Click += new System.EventHandler(this.ConsultarToolStripMenuItemClick);
			// 
			// cancelarToolStripMenuItem1
			// 
			this.cancelarToolStripMenuItem1.Name = "cancelarToolStripMenuItem1";
			this.cancelarToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
			this.cancelarToolStripMenuItem1.Text = "Cancelar";
			this.cancelarToolStripMenuItem1.Click += new System.EventHandler(this.CancelarToolStripMenuItem1Click);
			// 
			// sairToolStripMenuItem
			// 
			this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
			this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
			this.sairToolStripMenuItem.Text = "Sair";
			this.sairToolStripMenuItem.Click += new System.EventHandler(this.SairToolStripMenuItemClick);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// produtos
			// 
			this.produtos.BackColor = System.Drawing.Color.Transparent;
			this.produtos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.produtos.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.produtos.Location = new System.Drawing.Point(205, 203);
			this.produtos.Name = "produtos";
			this.produtos.Size = new System.Drawing.Size(352, 62);
			this.produtos.TabIndex = 4;
			this.produtos.Text = "Categoria de produtos";
			this.produtos.Click += new System.EventHandler(this.ProdutosClick);
			// 
			// ico_fornecedores
			// 
			this.ico_fornecedores.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.ico_cliente,
									this.ico_funcionario,
									this.ico_fornecedor,
									this.ico_produtos,
									this.ico_compra,
									this.ico_vendas,
									this.ico_exit});
			this.ico_fornecedores.Location = new System.Drawing.Point(0, 24);
			this.ico_fornecedores.Name = "ico_fornecedores";
			this.ico_fornecedores.Size = new System.Drawing.Size(736, 25);
			this.ico_fornecedores.TabIndex = 5;
			this.ico_fornecedores.Text = "toolStrip1";
			// 
			// ico_cliente
			// 
			this.ico_cliente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.ico_cliente.Image = ((System.Drawing.Image)(resources.GetObject("ico_cliente.Image")));
			this.ico_cliente.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.ico_cliente.Name = "ico_cliente";
			this.ico_cliente.Size = new System.Drawing.Size(23, 22);
			this.ico_cliente.Text = "Cadastrar Cliente";
			this.ico_cliente.Click += new System.EventHandler(this.Ico_clienteClick);
			// 
			// ico_funcionario
			// 
			this.ico_funcionario.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.ico_funcionario.Image = ((System.Drawing.Image)(resources.GetObject("ico_funcionario.Image")));
			this.ico_funcionario.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.ico_funcionario.Name = "ico_funcionario";
			this.ico_funcionario.Size = new System.Drawing.Size(23, 22);
			this.ico_funcionario.Text = "Cadastrar funcionário";
			this.ico_funcionario.Click += new System.EventHandler(this.Ico_funcionarioClick);
			// 
			// ico_fornecedor
			// 
			this.ico_fornecedor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.ico_fornecedor.Image = ((System.Drawing.Image)(resources.GetObject("ico_fornecedor.Image")));
			this.ico_fornecedor.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.ico_fornecedor.Name = "ico_fornecedor";
			this.ico_fornecedor.Size = new System.Drawing.Size(23, 22);
			this.ico_fornecedor.Text = "Cadastrar fornecedor";
			this.ico_fornecedor.Click += new System.EventHandler(this.Ico_fornecedorClick);
			// 
			// ico_produtos
			// 
			this.ico_produtos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.ico_produtos.Image = ((System.Drawing.Image)(resources.GetObject("ico_produtos.Image")));
			this.ico_produtos.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.ico_produtos.Name = "ico_produtos";
			this.ico_produtos.Size = new System.Drawing.Size(23, 22);
			this.ico_produtos.Text = "Cadastrar produtos";
			this.ico_produtos.Click += new System.EventHandler(this.Ico_produtosClick);
			// 
			// ico_compra
			// 
			this.ico_compra.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.ico_compra.Image = ((System.Drawing.Image)(resources.GetObject("ico_compra.Image")));
			this.ico_compra.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.ico_compra.Name = "ico_compra";
			this.ico_compra.Size = new System.Drawing.Size(23, 22);
			this.ico_compra.Text = "Cadastrar compra";
			this.ico_compra.Click += new System.EventHandler(this.Ico_compraClick);
			// 
			// ico_vendas
			// 
			this.ico_vendas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.ico_vendas.Image = ((System.Drawing.Image)(resources.GetObject("ico_vendas.Image")));
			this.ico_vendas.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.ico_vendas.Name = "ico_vendas";
			this.ico_vendas.Size = new System.Drawing.Size(23, 22);
			this.ico_vendas.Text = "Cadastrar vendas";
			this.ico_vendas.Click += new System.EventHandler(this.Ico_vendasClick);
			// 
			// ico_exit
			// 
			this.ico_exit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.ico_exit.Image = ((System.Drawing.Image)(resources.GetObject("ico_exit.Image")));
			this.ico_exit.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.ico_exit.Name = "ico_exit";
			this.ico_exit.Size = new System.Drawing.Size(23, 22);
			this.ico_exit.Text = "Sair";
			this.ico_exit.Click += new System.EventHandler(this.Ico_exitClick);
			// 
			// pro_nac
			// 
			this.pro_nac.Image = ((System.Drawing.Image)(resources.GetObject("pro_nac.Image")));
			this.pro_nac.Location = new System.Drawing.Point(53, 255);
			this.pro_nac.Name = "pro_nac";
			this.pro_nac.Size = new System.Drawing.Size(119, 135);
			this.pro_nac.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pro_nac.TabIndex = 6;
			this.pro_nac.TabStop = false;
			this.pro_nac.Click += new System.EventHandler(this.Pro_nacClick);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label1.Location = new System.Drawing.Point(40, 395);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(145, 30);
			this.label1.TabIndex = 7;
			this.label1.Text = "Nacionais";
			// 
			// tip_europeu
			// 
			this.tip_europeu.Image = ((System.Drawing.Image)(resources.GetObject("tip_europeu.Image")));
			this.tip_europeu.Location = new System.Drawing.Point(248, 255);
			this.tip_europeu.Name = "tip_europeu";
			this.tip_europeu.Size = new System.Drawing.Size(119, 135);
			this.tip_europeu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.tip_europeu.TabIndex = 8;
			this.tip_europeu.TabStop = false;
			this.tip_europeu.Click += new System.EventHandler(this.Tip_europeuClick);
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label2.Location = new System.Drawing.Point(238, 390);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(145, 30);
			this.label2.TabIndex = 9;
			this.label2.Text = "Europeus";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label3.Location = new System.Drawing.Point(40, 578);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(145, 30);
			this.label3.TabIndex = 11;
			this.label3.Text = "Feminino";
			// 
			// tip_feminino
			// 
			this.tip_feminino.Image = ((System.Drawing.Image)(resources.GetObject("tip_feminino.Image")));
			this.tip_feminino.Location = new System.Drawing.Point(53, 438);
			this.tip_feminino.Name = "tip_feminino";
			this.tip_feminino.Size = new System.Drawing.Size(119, 135);
			this.tip_feminino.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.tip_feminino.TabIndex = 10;
			this.tip_feminino.TabStop = false;
			this.tip_feminino.Click += new System.EventHandler(this.Tip_femininoClick);
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label4.Location = new System.Drawing.Point(235, 578);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(170, 30);
			this.label4.TabIndex = 13;
			this.label4.Text = "Acessórios";
			// 
			// tip_acessorios
			// 
			this.tip_acessorios.Image = ((System.Drawing.Image)(resources.GetObject("tip_acessorios.Image")));
			this.tip_acessorios.InitialImage = ((System.Drawing.Image)(resources.GetObject("tip_acessorios.InitialImage")));
			this.tip_acessorios.Location = new System.Drawing.Point(248, 438);
			this.tip_acessorios.Name = "tip_acessorios";
			this.tip_acessorios.Size = new System.Drawing.Size(119, 135);
			this.tip_acessorios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.tip_acessorios.TabIndex = 12;
			this.tip_acessorios.TabStop = false;
			this.tip_acessorios.Click += new System.EventHandler(this.Tip_acessoriosClick);
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label5.Location = new System.Drawing.Point(418, 393);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(113, 30);
			this.label5.TabIndex = 15;
			this.label5.Text = "Inverno";
			// 
			// tip_inverno
			// 
			this.tip_inverno.Image = ((System.Drawing.Image)(resources.GetObject("tip_inverno.Image")));
			this.tip_inverno.Location = new System.Drawing.Point(418, 255);
			this.tip_inverno.Name = "tip_inverno";
			this.tip_inverno.Size = new System.Drawing.Size(119, 135);
			this.tip_inverno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.tip_inverno.TabIndex = 14;
			this.tip_inverno.TabStop = false;
			this.tip_inverno.Click += new System.EventHandler(this.Tip_invernoClick);
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label6.Location = new System.Drawing.Point(405, 578);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(145, 30);
			this.label6.TabIndex = 17;
			this.label6.Text = "Para jogo";
			// 
			// tip_jogo
			// 
			this.tip_jogo.Image = ((System.Drawing.Image)(resources.GetObject("tip_jogo.Image")));
			this.tip_jogo.Location = new System.Drawing.Point(418, 438);
			this.tip_jogo.Name = "tip_jogo";
			this.tip_jogo.Size = new System.Drawing.Size(119, 135);
			this.tip_jogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.tip_jogo.TabIndex = 16;
			this.tip_jogo.TabStop = false;
			this.tip_jogo.Click += new System.EventHandler(this.Tip_jogoClick);
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label7.Location = new System.Drawing.Point(540, 395);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(196, 30);
			this.label7.TabIndex = 19;
			this.label7.Text = "Sul Americanos";
			// 
			// tip_americas
			// 
			this.tip_americas.Image = ((System.Drawing.Image)(resources.GetObject("tip_americas.Image")));
			this.tip_americas.Location = new System.Drawing.Point(571, 255);
			this.tip_americas.Name = "tip_americas";
			this.tip_americas.Size = new System.Drawing.Size(119, 135);
			this.tip_americas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.tip_americas.TabIndex = 18;
			this.tip_americas.TabStop = false;
			this.tip_americas.Click += new System.EventHandler(this.Tip_americasClick);
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label8.Location = new System.Drawing.Point(558, 578);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(145, 30);
			this.label8.TabIndex = 21;
			this.label8.Text = "Seleções";
			// 
			// tip_selecao
			// 
			this.tip_selecao.Image = ((System.Drawing.Image)(resources.GetObject("tip_selecao.Image")));
			this.tip_selecao.Location = new System.Drawing.Point(571, 438);
			this.tip_selecao.Name = "tip_selecao";
			this.tip_selecao.Size = new System.Drawing.Size(119, 135);
			this.tip_selecao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.tip_selecao.TabIndex = 20;
			this.tip_selecao.TabStop = false;
			this.tip_selecao.Click += new System.EventHandler(this.Tip_selecaoClick);
			// 
			// frm_menu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(736, 620);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.tip_selecao);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.tip_americas);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.tip_jogo);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.tip_inverno);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.tip_acessorios);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.tip_feminino);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tip_europeu);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pro_nac);
			this.Controls.Add(this.ico_fornecedores);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.logo);
			this.Controls.Add(this.produtos);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "frm_menu";
			this.Text = "Menu";
			this.Load += new System.EventHandler(this.Frm_menuLoad);
			((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ico_fornecedores.ResumeLayout(false);
			this.ico_fornecedores.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pro_nac)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tip_europeu)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tip_feminino)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tip_acessorios)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tip_inverno)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tip_jogo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tip_americas)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tip_selecao)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.PictureBox tip_selecao;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.PictureBox tip_americas;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.PictureBox tip_jogo;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.PictureBox tip_inverno;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.PictureBox tip_acessorios;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.PictureBox tip_feminino;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox tip_europeu;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pro_nac;
		private System.Windows.Forms.ToolStripButton ico_exit;
		private System.Windows.Forms.ToolStripButton ico_vendas;
		private System.Windows.Forms.ToolStripButton ico_compra;
		private System.Windows.Forms.ToolStripButton ico_produtos;
		private System.Windows.Forms.ToolStripButton ico_fornecedor;
		private System.Windows.Forms.ToolStripButton ico_funcionario;
		private System.Windows.Forms.ToolStripButton ico_cliente;
		private System.Windows.Forms.ToolStrip ico_fornecedores;
		private System.Windows.Forms.Label produtos;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cancelarToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cancelarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pedidosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem estoqueToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem fornecedoresToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem funcionáriosToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fornecedoresToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem funcionáriosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.PictureBox logo;
	}
}
