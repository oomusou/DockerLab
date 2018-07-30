using System.Collections.Generic;
using DockerLib;
using NUnit.Framework;

namespace ClassLib.Test
{
    public class DockerTest
    {
        private readonly Dictionary<string, Container> _containers = new Dictionary<string, Container>();
        private static string TestFullName => TestContext.CurrentContext.Test.FullName;

        [SetUp]
        public void Setup() => _containers[TestFullName] = Dockery.BeginTest();

        [TearDown]
        public void TearDown() => Dockery.EndTest(_containers[TestFullName]);
    }
}