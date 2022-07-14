using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace TrxTesting
{
    [TestClass]
    public class UnitTest1
    {
        private const int programId = 123;

        public void NormalTestExample()
        {
            Assert.IsTrue(true);
        }

        [DataRow(1)]
        [DataRow(2)]
        public void DataTestMethodExample(int dataInt)
        {
            Assert.IsTrue(true);
        }

        [TestMethod]
        [DynamicData(nameof(DyanmicDataExample_SameSignaturePerTestRun_Data), DynamicDataSourceType.Method)]
        public void DyanmicDataExample_SameSignaturePerTestRun(EnergyProgram program, IReadOnlyAddress address, bool expected)
        {
            Assert.IsTrue(true);
        }

        private static IEnumerable<object[]> DyanmicDataExample_SameSignaturePerTestRun_Data()
        {
            var data = new List<object[]>();
            EnergyProgram program;
            string[] supportedZips;
            IReadOnlyAddress address;

            program = null;
            address = new Address("street1", "street2", "subcity", "city", "State", "Substate", "02144", 1);
            data.Add(new object[] { program, address, false });

            supportedZips = new string[] { };
            program = GreaterEnergyProgram.GreateEnergyProgram(programId: programId, eligiblePostalCodes: supportedZips);
            address = new Address("street1", "street2", "subcity", "city", "State", "Substate", "02144", 1);
            data.Add(new object[] { program, address, true });

            supportedZips = new string[] { "02144" };
            program = GreaterEnergyProgram.GreateEnergyProgram(programId: programId, eligiblePostalCodes: supportedZips);
            address = new Address("street1", "street2", "subcity", "city", "State", "Substate", "02144", 1);
            data.Add(new object[] { program, address, true });

            supportedZips = new string[] { "02144" };
            program = GreaterEnergyProgram.GreateEnergyProgram(programId: programId, eligiblePostalCodes: supportedZips);
            address = new Address("street1", "street2", "subcity", "city", "State", "Substate", "12345", 1);
            data.Add(new object[] { program, address, false });

            supportedZips = new string[] { "T2M" };
            program = GreaterEnergyProgram.GreateEnergyProgram(programId: programId, eligiblePostalCodes: supportedZips);
            address = new Address("street1", "street2", "subcity", "city", "State", "Substate", "T2M0E2", 1);
            data.Add(new object[] { program, address, true });

            supportedZips = new string[] { "T2M" };
            program = GreaterEnergyProgram.GreateEnergyProgram(programId: programId, eligiblePostalCodes: supportedZips);
            address = new Address("street1", "street2", "subcity", "city", "State", "Substate", "T5T3J4", 1);
            data.Add(new object[] { program, address, false });

            return data;
        }

        [DynamicData(nameof(DyanmicDataExample_DifferentPerTestRun_Data), DynamicDataSourceType.Method)]
        public void DyanmicDataExample_DifferentPerTestRun(int number, DateTime dateTime)
        {
            Assert.IsTrue(true);
        }

        private static IEnumerable<object[]> DyanmicDataExample_DifferentPerTestRun_Data()
        {
            return new List<object[]>()
            {
                new object[]
                {
                    1,
                    DateTime.Now,
                },
                new object[]
                {
                    2,
                    DateTime.Now,
                },
                new object[]
                {
                    3,
                    DateTime.Now,
                },
            };
        }
    }
}