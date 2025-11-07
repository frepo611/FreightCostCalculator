using FreightCostCalculator.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreightCostCalculator.Tests
{
    public class CentimeterTests
    {
        [Fact]
        public void CompareTo_Null_ReturnsOne()
        {
            var cm = new Centimeter(10);

            int actual = cm.CompareTo((Centimeter?)null);

            Assert.Equal(1, actual);
        }

        [Fact]
        public void CompareTo_OtherSmaller_ReturnsPositive()
            
        {
            var cm = new Centimeter(10);
            var other = new Centimeter(5);

            var actual = cm.CompareTo(other);

            Assert.True(actual > 0);
                }
        [Fact]
        public void CompareTo_OtherLarger_ReturnsNegative()
        {
            var cm = new Centimeter(5);
            var other = new Centimeter(10);

            var actual = cm.CompareTo(other);

            Assert.True(actual < 0);
        }

        [Fact]
        public void CompareTo_Equal_ReturnsZero()
        {
            var cm = new Centimeter(10);
            var other = new Centimeter(10);

            var actual = cm.CompareTo(other);

            Assert.Equal(0, actual);
        }

        [Fact]
        public void IComparable_CompareTo_ObjectCentimeter_MatchesGeneric()
        {
            var cm = new Centimeter(10);
            var other = new Centimeter(5);

            var expected = cm.CompareTo(other);
            var actual = ((IComparable)cm).CompareTo(other);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void IComparable_CompareTo_Null_ReturnsOne()
        {
            var cm = new Centimeter(10);

            var actual = ((IComparable)cm).CompareTo(null);

            Assert.Equal(1, actual);
        }

        [Fact]
        public void IComparable_CompareTo_WrongType_ThrowsArgumentException()
        {
            var cm = new Centimeter(10);

            Assert.Throws<ArgumentException>(() => ((IComparable)cm).CompareTo("not a centimeter"));
        }
    }

}

