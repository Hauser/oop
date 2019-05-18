using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOP1;

namespace OOP1_Tests
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestInheritance()
		{
			var pos = new Point(10, 10);

			var rec = new Rectangle(pos, new Point(20, 20));
			var cir = new Circle(pos, 5);

			Assert.IsInstanceOfType(rec, typeof(Shape));
			Assert.IsInstanceOfType(cir, typeof(Shape));
		}

		[TestMethod]
		public void TestMove()
		{
			var pos = new Point(10, 10);

			var rec = new Rectangle(pos, new Point(20, 20));
			var cir = new Circle(pos, 5);

			Assert.AreEqual(rec.m_P, cir.m_P);

			rec.Move(30, 20);

			Assert.AreNotEqual(rec.m_P, cir.m_P);

			cir.Move(30, 20);

			Assert.AreEqual(rec.m_P, cir.m_P);
		}

		[TestMethod]
		public void TestHitInRadius()
		{
			var pos = new Point(10, 10);

			var rec = new Rectangle(pos, new Point(20, 20));
			var cir = new Circle(pos, 5);

			Assert.IsTrue(rec.HitInRadius(new Point(10, 10)));
			Assert.IsTrue(rec.HitInRadius(new Point(20, 20)));

			Assert.IsFalse(rec.HitInRadius(new Point(9, 9)));
			Assert.IsFalse(rec.HitInRadius(new Point(21, 21)));

			Assert.IsTrue(cir.HitInRadius(new Point(15, 15)));
			Assert.IsTrue(cir.HitInRadius(new Point(10, 15)));

			Assert.IsFalse(cir.HitInRadius(new Point(10, 10)));
			Assert.IsFalse(cir.HitInRadius(new Point(20, 20)));
		}
	}
}
