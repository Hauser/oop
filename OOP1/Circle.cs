using System.Drawing;

namespace OOP1
{
	public class Circle : Shape
	{
		public int m_R { get; protected set; }

		public Circle()
			: this(Point.Zero, 0)
		{
		}
		public Circle(Point aP, int aR)
			: base(aP)
		{
			m_R = aR;
		}

		public override void Draw(Pen pen, Graphics gr)
		{
			gr.FillEllipse(pen.Brush, m_P.m_X, m_P.m_Y, m_R * 2, m_R * 2);
		}
		public override bool IsHit(Point aP)
		{
			var x = m_P.m_X - aP.m_X + m_R;
			var y = m_P.m_Y - aP.m_Y + m_R;
			return System.Math.Sqrt(x * x + y * y) <= m_R;
		}

		public override string ToString()
			=> typeof(Circle).Name;
	}
}
