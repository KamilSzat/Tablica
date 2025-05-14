using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie5
{
    [TestClass]
    public class Zadanie5Test
    {
        [TestMethod]

        public void Reverse_Array_ReturnReversed()
        {
            var z = new Zadanie5();
            var input = new[] { 1, 2, 3 };
            var result = z.Reverse(input);

            CollectionAssert.AreEqual(new[] { 3, 2, 1 }, result);
        }
    }
}
