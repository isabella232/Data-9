using NUnit.Framework;
using Octopus.Data.Model;

namespace Tests
{
    [TestFixture]
    public class SensitiveStringTests
    {
        [Test]
        public void ComparingSensitiveStringsAreEqualWorks()
        {
            var a = "Test Value".ToSensitiveString();
            var b = "Test Value".ToSensitiveString();
            
            Assert.IsTrue(a == b);
        }

        [Test]
        public void ComparingSensitiveStringsAreNotEqualWorks()
        {
            var a = "Test Value".ToSensitiveString();
            var b = "Test Value2".ToSensitiveString();
            
            Assert.IsTrue(a != b);
        }
        
        [Test]
        public void ComparingSensitiveStringsToEqualStringWorks()
        {
            var a = "Test Value".ToSensitiveString();
            
            Assert.IsTrue(a == "Test Value");
        }
        
        [Test]
        public void ComparingSensitiveStringsToNotEqualStringWorks()
        {
            var a = "Test Value".ToSensitiveString();
            
            Assert.IsTrue(a != "Test Value2");
        }
    }
}