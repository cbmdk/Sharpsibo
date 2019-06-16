using System.Runtime.InteropServices.ComTypes;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        private Sharpsibo.Sharpsibo sharpsibo = null;
        [SetUp]
        public void Setup()
        {
             this.sharpsibo = new Sharpsibo.Sharpsibo("EOKJtzZmbgKQe3ZXOMu9MlCjkorbTc");
        }

        [Test]
        public void GetHttpStatusCodeOk()
        {
            var pods = sharpsibo.GetPods();
            if (pods.status == "success")
            {
                Assert.Pass();
            }
            else Assert.Fail();
        }
    }
}