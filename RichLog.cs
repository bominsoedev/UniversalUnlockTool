using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversalUnlockTool
{
	public static class RichLog
	{
		public static void Invoke(this Control control, Action action)
		{
			if (control.InvokeRequired)
			{
				control.Invoke(new MethodInvoker(action.Invoke), null);
			}
			else
			{
				action();
			}
		}

		public static void RichLogs(string msg, Color colour, bool isBold, bool NextLine = false)
		{
			Form1.main.richTextBox1.Invoke(delegate
			{
				Form1.main.richTextBox1.SelectionStart = Form1.main.richTextBox1.Text.Length;
				Color selectionColor = Form1.main.richTextBox1.SelectionColor;
				Form1.main.richTextBox1.SelectionColor = colour;
				if (isBold)
				{
					Form1.main.richTextBox1.SelectionFont = new Font(Form1.main.richTextBox1.Font, FontStyle.Bold);
				}
				Form1.main.richTextBox1.AppendText(msg);
				Form1.main.richTextBox1.SelectionColor = selectionColor;
				Form1.main.richTextBox1.SelectionFont = new Font(Form1.main.richTextBox1.Font, FontStyle.Regular);
				if (NextLine && Form1.main.richTextBox1.TextLength > 0)
				{
					Form1.main.richTextBox1.AppendText("\r\n");
				}
			});
		}
	}
}
