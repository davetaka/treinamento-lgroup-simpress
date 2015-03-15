using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Simpress.CodeFirst.DataAnnotations.DataAccess;

namespace Simpress.CodeFirst.DataAnnotations.Test.DataAccess
{
    [TestFixture]
    public class ConnectionTest
    {
        [Test]
        public void Test_Create_Database()
        {
            var connection = new Connection();
            connection.CreateDatabase();
        }

        [Test]
        public void Test_Drop_Database()
        {
            var connection = new Connection();
            connection.DropDatabase();

        }

    }
}
