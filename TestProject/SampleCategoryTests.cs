namespace TestProject
{
    using System;
    using Xunit;
    
    [Trait("Category", "Example category")]
    public class SampleCategoryTests
    {
        [Fact]
        public void Test0 () {
            Assert.True (false);
        }

        [Fact]
        public void Test1 () {
            Assert.True (true);
        }

        [Fact]
        public void Test3 () {
            Assert.True (false);
        }

        [Fact]
        public void Test4 () {
            Assert.True (true);
        }

        [Fact]
        public void Test5 () {
            Assert.True (false);
        }
    }
}