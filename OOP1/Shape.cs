using System.Drawing;

namespace OOP1
{
	public abstract class Shape
	{
		public Point m_P { get; protected set; }

		public Shape(Point aP)
			=> m_P = aP;

		public virtual void Move(int aDx, int aDy)
			=> m_P = new Point(aDx, aDy);

		public abstract void Draw(Pen pen, Graphics gr);
		public abstract bool IsHit(Point aP);
	}
}
