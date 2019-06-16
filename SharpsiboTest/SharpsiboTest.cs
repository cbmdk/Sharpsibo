using System.Runtime.InteropServices.ComTypes;
using NUnit.Framework;
using Sharpsibo.Models;

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

        [Test]
        public void GetHistory()
        {
            var history = sharpsibo.GetReadings(4, "eyy7htpx");
            if (history.status == "succress")
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }
    }
}