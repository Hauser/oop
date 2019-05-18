using System.Drawing;

namespace OOP1
{
	public class Triangle : Shape
	{
		public Point m_P2 { get; protected set; }
		public Point m_P3 { get; protected set; }

		public Triangle()
			: this(Point.Zero, Point.Zero, Point.Zero)
		{
		}
		public Triangle(Point aP1, Point aP2, Point aP3)
			: base(aP1)
		{
			m_P2 = aP2;
			m_P3 = aP3;
		}
		public override void Move(int aDx, int aDy)
		{
			var w = m_P2.m_X - m_P.m_X;
			var h = m_P2.m_Y - m_P.m_Y;
			var w2 = m_P3.m_X - m_P.m_X;
			var h2 = m_P3.m_Y - m_P.m_Y;
			m_P = new Point(aDx, aDy);
			m_P2 = new Point(aDx + w, aDy + h);
			m_P3 = new Point(aDx + w2, aDy + h2);
		}
		public override void Draw(Pen pen, Graphics gr)
		{
			gr.FillPolygon(pen.Brush, new System.Drawing.Point[] { m_P, m_P2, m_P3 });
		}
		public override bool HitInRadius(Point aP)
		{
			var p = new { X = aP.m_X, Y = aP.m_Y };
			var p0 = new { X = m_P.m_X, Y = m_P.m_Y };
			var p1 = new { X = m_P2.m_X, Y = m_P2.m_Y };
			var p2 = new { X = m_P3.m_X, Y = m_P3.m_Y };

			// https://stackoverflow.com/a/20861130
			var s = p0.Y * p2.X - p0.X * p2.Y + (p2.Y - p0.Y) * p.X + (p0.X - p2.X) * p.Y;
			var t = p0.X * p1.Y - p0.Y * p1.X + (p0.Y - p1.Y) * p.X + (p1.X - p0.X) * p.Y;

			if ((s < 0) != (t < 0))
				return false;

			var A = -p1.Y * p2.X + p0.Y * (p2.X - p1.X) + p0.X * (p1.Y - p2.Y) + p1.X * p2.Y;
			return (A < 0) ? (s <= 0 && s + t >= A) : (s >= 0 && s + t <= A);
		}

		public override string ToString() => typeof(Triangle).Name;
	}
}
