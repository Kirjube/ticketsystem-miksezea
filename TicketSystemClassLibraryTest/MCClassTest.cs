namespace TicketSystemTest
{
    /// <summary>
    /// Tests af MC klassen
    /// </summary>
    [TestClass]
    public class MCClassTests
    {
        /// <summary>
        /// Tester at metoden Price() giver 125
        /// </summary>
        /// <param name="value">Pris</param>
        [DataRow(125)]
        [TestMethod]
        public void Price_AreEqual_125(double value)
        {
            // Arrange
            var mc = new MC("test");

            // Act
            double price = mc.Price();

            // Assert
            Assert.AreEqual(value, price);
        }

        /// <summary>
        /// Tester at metoden Price() fejler n�r pris ikke er 125
        /// </summary>
        /// <param name="value">Pris</param>
        [DataRow(126)]
        [DataRow(0)]
        [TestMethod]
        public void Price_AreNotEqual_125(double value)
        {
            // Arrange
            var mc = new MC("test");

            // Act
            double price = mc.Price();

            // Assert
            Assert.AreNotEqual(value, price);
        }

        /// <summary>
        /// Tester at metoden VehicleType() giver MC
        /// </summary>
        /// <param name="value">K�ret�jstype</param>
        [DataRow("MC")]
        [TestMethod]
        public void VehicleType_AreEqual_MC(string value)
        {
            // Arrange
            var mc = new MC("test");

            // Act
            string vehicleType = mc.VehicleType();

            // Assert
            Assert.AreEqual(value, vehicleType);
        }

        /// <summary>
        /// Tester at metoden VehicleType() fejler hvis type ikke er MC
        /// </summary>
        /// <param name="value">K�ret�jstype</param>
        [DataRow("Car")]
        [DataRow("")]
        [TestMethod]
        public void VehicleType_AreNotEqual_MC(string value)
        {
            // Arrange
            var mc = new MC("test");

            // Act
            string vehicleType = mc.VehicleType();

            // Assert
            Assert.AreNotEqual(value, vehicleType);
        }

        /// <summary>
        /// Tester at v�rdien for MC's property "licenseplate" ikke feljer ved korrekt v�rdi
        /// </summary>
        /// <param name="value">Licenseplate v�rdi</param>
        /// <param name="correctValue">Korrekte licenseplate v�rdi</param>
        [DataRow("1234567", "1234567")]
        [DataRow("1", "1")]
        [DataRow("1a2bX", "1a2bX")]
        [TestMethod]
        public void MC_LicensePlate_AreEqual_Between_1_And_7(string value, string correctValue)
        {
            // Arrange
            var mc = new MC(value);

            // Act
            string result = mc.Licenseplate;

            // Assert
            Assert.AreEqual(correctValue, result);
        }
    }
}
