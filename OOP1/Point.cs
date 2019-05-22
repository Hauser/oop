namespace OOP1
{
	public struct Point
	{
		public int m_X { get; set; }
		public int m_Y { get; set; }

		public static readonly Point Zero = new Point(0, 0);

		public Point(int aX, int aY)
			=> (m_X, m_Y) = (aX, aY);

		public static implicit operator System.Drawing.Point(Point p)
			=> new System.Drawing.Point(p.m_X, p.m_Y);
	}
}
