namespace CrawlerMsdn
{
	partial class Form1
	{
		/// <summary>
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpar os recursos que estão sendo usados.
		/// </summary>
		/// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código gerado pelo Windows Form Designer

		/// <summary>
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Postagem = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Exibicao = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Respostas = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Link = new System.Windows.Forms.DataGridViewLinkColumn();
			this.bntAtualizar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Titulo,
            this.Postagem,
            this.Exibicao,
            this.Respostas,
            this.Link});
			this.dataGridView1.Location = new System.Drawing.Point(12, 49);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(846, 389);
			this.dataGridView1.TabIndex = 0;
			// 
			// Titulo
			// 
			this.Titulo.HeaderText = "Titulo";
			this.Titulo.Name = "Titulo";
			this.Titulo.Width = 150;
			// 
			// Postagem
			// 
			this.Postagem.HeaderText = "Postagem";
			this.Postagem.Name = "Postagem";
			// 
			// Exibicao
			// 
			this.Exibicao.HeaderText = "Exibicao";
			this.Exibicao.Name = "Exibicao";
			// 
			// Respostas
			// 
			this.Respostas.HeaderText = "Respostas";
			this.Respostas.Name = "Respostas";
			// 
			// Link
			// 
			this.Link.HeaderText = "Link";
			this.Link.Name = "Link";
			this.Link.Width = 350;
			// 
			// bntAtualizar
			// 
			this.bntAtualizar.Location = new System.Drawing.Point(13, 13);
			this.bntAtualizar.Name = "bntAtualizar";
			this.bntAtualizar.Size = new System.Drawing.Size(87, 23);
			this.bntAtualizar.TabIndex = 1;
			this.bntAtualizar.Text = "Atualizar";
			this.bntAtualizar.UseVisualStyleBackColor = true;
			this.bntAtualizar.Click += new System.EventHandler(this.bntAtualizar_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(870, 450);
			this.Controls.Add(this.bntAtualizar);
			this.Controls.Add(this.dataGridView1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
		private System.Windows.Forms.DataGridViewTextBoxColumn Postagem;
		private System.Windows.Forms.DataGridViewTextBoxColumn Exibicao;
		private System.Windows.Forms.DataGridViewTextBoxColumn Respostas;
		private System.Windows.Forms.DataGridViewLinkColumn Link;
		private System.Windows.Forms.Button bntAtualizar;
	}
}

