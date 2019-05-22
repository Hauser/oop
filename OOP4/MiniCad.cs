using System.Collections.Generic;
using System.Drawing;
using OOP1;

namespace OOP4
{
	internal class MiniCad
	{
		public CadMode CurrentMode { get; set; }

		private List<Shape> _shapes { get; set; }
		private Pen _pen { get; set; }
		private Shape _draggedShape { get; set; }

		public static readonly int ShapeSize = 50;

		public MiniCad()
		{
			CurrentMode = CadMode.Create;
			_shapes = new List<Shape>();
			_pen = new Pen(Color.Black);
			_draggedShape = null;
		}

		public void Paint(Graphics gr)
		{
			using (gr)
			{
				foreach (var shape in _shapes)
				{
					shape.Draw(_pen, gr);
				}
			}
		}
		public void Create(Shape shape, OOP1.Point pos)
		{
			pos.m_X -= ShapeSize / 2;
			pos.m_Y -= ShapeSize / 2;

			switch (shape)
			{
				case OOP1.Rectangle _:
					_shapes.Add(new OOP1.Rectangle(pos, new OOP1.Point(pos.m_X + ShapeSize, pos.m_Y + ShapeSize)));
					break;
				case Circle _:
					_shapes.Add(new Circle(pos, ShapeSize / 2));
					break;
				case Triangle _:
					_shapes.Add(new Triangle(
						new OOP1.Point(pos.m_X + ShapeSize / 2, pos.m_Y),
						new OOP1.Point(pos.m_X, pos.m_Y + ShapeSize),
						new OOP1.Point(pos.m_X + ShapeSize, pos.m_Y + ShapeSize)));
					break;
				default:
					break;
			}
		}
		public void Delete(OOP1.Point pos)
		{
			_shapes.RemoveAll(s => s.IsHit(pos));
		}
		public bool Move(OOP1.Point pos)
		{
			if (_draggedShape != null)
			{
				if (_draggedShape is Triangle)
				{
					pos.m_X += ShapeSize / 2;
				}

				_draggedShape.Move(pos.m_X - ShapeSize / 2, pos.m_Y - ShapeSize / 2);
				return true;
			}
			return false;
		}
		public void StartMove(OOP1.Point pos)
			=> _draggedShape = _shapes.Find(s => s.IsHit(pos));
		public void EndMove()
			=> _draggedShape = null;
	}
}
