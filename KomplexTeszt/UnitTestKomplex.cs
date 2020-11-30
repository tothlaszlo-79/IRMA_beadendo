using System;
using KomplexSzamitas;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KomplexTeszt
{
	[TestClass]
	public class UnitTestKomplex
	{
		[TestMethod]
		[TestCategory("Konstruktor")]
		public void KonstruktorTeszt()
		{
			var k = new Komplex(1, 2);
			Assert.IsNotNull(k);
		}
		[TestMethod]
		[TestCategory("ToString")]
		public void ToStringTeszt()
		{
			var s = new Komplex(1, 2).ToString();
			var ElvártÉrték = "1+i*2";
			Assert.AreEqual(ElvártÉrték,s);
		}
		[TestMethod]
		[TestCategory("Aritmetika")]
		public void ÖsszeadásTeszt1()
		{
			var k1 = new Komplex(1, 2);
			var k2 = new Komplex(3, 4);
			var k3 = k1 + k2;
			var ElvártÉrték = "4+i*6";
			Assert.AreEqual(ElvártÉrték,k3.ToString());
		}
		[TestMethod]
		[TestCategory("Aritmetika")]
		public void ÖsszeadásTeszt2()
		{
			var k1 = new Komplex(1, 2);
			var k2 = new Komplex(3, 4);
			var k3 = k1 + k2;
			Assert.IsInstanceOfType(k3, 
				typeof(Komplex));
		}
	}
}
