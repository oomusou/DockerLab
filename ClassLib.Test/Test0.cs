using System.IO;
using DockerLib;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;

namespace ClassLib.Test
{
    [SetUpFixture]
    public class Test0
    {
        private const string ProjectDir = "/Users/oomusou/Code/CSharp/DockerLab/";
        private const string MigrationPath = ProjectDir + "ClassLib.Test/Migration.sql";
        private const int CommandTimeout = 500;

        [OneTimeSetUp]
        public void GlobalSetup() => Dockery.Migration = RunMigration;

        [OneTimeTearDown]
        public void GlobalTearDown() => Dockery.CleanContainer();

        private static void RunMigration(Container container)
        {
            var sqlScript = File.ReadAllText(MigrationPath);
            var crmDbContext = new CrmDbContext(container.Port);
            crmDbContext.Database.SetCommandTimeout(CommandTimeout);
            crmDbContext.Database.ExecuteSqlCommand(sqlScript);
        }
    }
}