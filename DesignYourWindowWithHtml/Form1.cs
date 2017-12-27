using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignYourWindowWithHtml
{
	using NetDimension.NanUI;

	public partial class Form1 : Formium
	{
		public Form1()
			: base("http://res.app.local/asserts/index.html")
		{
			InitializeComponent();

			LoadHandler.OnLoadStart += LoadHandler_OnLoadStart;


			GlobalObject.AddFunction("showDialog").Execute += (_, args) =>
			{
				this.RequireUIThread(() =>
				{
					var form2 = new Form2();
					form2.ShowDialog(this);
				});
			};

			GlobalObject.AddFunction("showWindow").Execute += (_, args) =>
			{
				this.RequireUIThread(() =>
				{
					var form2 = new Form2();
					form2.Show(this);
				});
			};

		}

		private void LoadHandler_OnLoadStart(object sender, Chromium.Event.CfxOnLoadStartEventArgs e)
		{
#if DEBUG
			Chromium.ShowDevTools();
#endif
		}
	}
}
