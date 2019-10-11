using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Main
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		void NGameClick(object sender, EventArgs e)
		{
			Ngame novo = new Ngame();
			novo.Show();
			Hide();
		}
		
	}
}
