using System;
using System.Windows.Forms;
using OOP1;

namespace OOP4
{
	public partial class Main : Form
	{
		private MiniCad _cad = new MiniCad();

		public Main() => InitializeComponent();

		private void OnLoad_frmMain(object sender, EventArgs e)
		{
			_cbxShape.Items.Add(new Rectangle());
			_cbxShape.Items.Add(new Circle());
			_cbxShape.Items.Add(new Triangle());
			_cbxShape.SelectedIndex = 0;

			_lblMode.Text = _cad.CurrentMode.ToString();
		}

		private void OnPaint_pPanel(object sender, PaintEventArgs e)
		{
			_cad.Paint(e.Graphics);
		}

		private void OnMouseClick_pPanel(object sender, MouseEventArgs e)
		{
			if (e.Button.HasFlag(MouseButtons.Left))
			{
				var pos = new Point(e.X, e.Y);

				switch (_cad.CurrentMode)
				{
					case CadMode.Create:
						_cad.Create(_cbxShape.SelectedItem as Shape, pos);
						_pPanel.Invalidate();
						break;
					case CadMode.Delete:
						_cad.Delete(pos);
						_pPanel.Invalidate();
						break;
					case CadMode.Move:
						_cad.EndMove();
						break;
					default:
						break;
				}
			}
			else if (e.Button.HasFlag(MouseButtons.Right))
			{
				if (_cad.CurrentMode == CadMode.Last)
				{
					_cad.CurrentMode = 0;
				}
				else
				{
					++_cad.CurrentMode;
				}
				_lblMode.Text = _cad.CurrentMode.ToString();
			}
		}

		private void OnMouseDown_pPanel(object sender, MouseEventArgs e)
		{
			if (_cad.CurrentMode == CadMode.Move)
			{
				_cad.StartMove(new Point(e.X, e.Y));
			}
		}

		private void OnMouseMove_pPanel(object sender, MouseEventArgs e)
		{
			if (_cad.CurrentMode == CadMode.Move)
			{
				if (_cad.Move(new Point(e.X, e.Y)))
				{
					_pPanel.Invalidate();
				}
			}
		}
	}
}
