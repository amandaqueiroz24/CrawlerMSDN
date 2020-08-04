using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;

namespace CrawlerMsdn
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void bntAtualizar_Click(object sender, EventArgs e)
		{
			var wc = new WebClient();
			string pagina = wc.DownloadString("https://social.msdn.microsoft.com/Forums/pt-BR/home");

			var htmtDocument = new HtmlAgilityPack.HtmlDocument();
			htmtDocument.LoadHtml(pagina);

			dataGridView1.Rows.Clear();

			string id = string.Empty;
			string titulo = string.Empty;
			string postagem = string.Empty;
			string exibicao = string.Empty;
			string resposta = string.Empty;
			string link = string.Empty;

			foreach(HtmlNode node in htmtDocument.GetElementbyId("threadList").ChildNodes)
			{
				if(node.Attributes.Count > 0)
				{
					id = node.Attributes["data-threadid"].Value;
					link = "social.msdn.microsoft.com/Forums/pt-BR/" + id;
					titulo = node.Descendants().First(x => x.Id.Equals("threadTitle_" + id)).InnerText;
					postagem = WebUtility.HtmlDecode( node.Descendants().First(x => x.Attributes["class"] != null && x.Attributes["class"].Value.Equals("lastpost")).InnerText.Replace("\n", "").Replace("  ",""));
					exibicao = WebUtility.HtmlDecode( node.Descendants().First(x => x.Attributes["class"] != null && x.Attributes["class"].Value.Equals("viewcount")).InnerText);
					resposta = WebUtility.HtmlDecode( node.Descendants().First(x => x.Attributes["class"] != null && x.Attributes["class"].Value.Equals("replycount")).InnerText);

					if (!string.IsNullOrEmpty(titulo))
					{
						dataGridView1.Rows.Add(titulo, postagem, exibicao, resposta, link);
					}
				}
			}
		}
	}
}
