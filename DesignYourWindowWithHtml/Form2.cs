﻿using System;
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

	public partial class Form2 : Formium
	{
		public Form2()
			: base("http://res.app.local/asserts/PopupWindow.html")
		{
			InitializeComponent();
		}
	}
}
