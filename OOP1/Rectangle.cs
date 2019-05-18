using System.Drawing;

namespace OOP1
{
	public class Rectangle : Shape
	{
		public Point m_P2 { get; protected set; }

		public Rectangle()
			: this(Point.Zero, Point.Zero)
		{
		}
		public Rectangle(Point aP1, Point aP2)
			: base(aP1)
		{
			m_P2 = aP2;
		}
		public override void Move(int aDx, int aDy)
		{
			var w = m_P2.m_X - m_P.m_X;
			var h = m_P2.m_Y - m_P.m_Y;
			m_P = new Point(aDx, aDy);
			m_P2 = new Point(aDx + w, aDy + h);
		}
		public override void Draw(Pen pen, Graphics gr)
		{
			gr.FillRectangle(pen.Brush, m_P.m_X, m_P.m_Y, System.Math.Abs(m_P.m_X - m_P2.m_X), System.Math.Abs(m_P.m_Y - m_P2.m_Y));
		}
		public override bool HitInRadius(Point aP)
		{
			return aP.m_X >= m_P.m_X && aP.m_X <= m_P2.m_X
				&& aP.m_Y >= m_P.m_Y && aP.m_Y <= m_P2.m_Y;
		}

		public override string ToString() => typeof(Rectangle).Name;
	}
}
