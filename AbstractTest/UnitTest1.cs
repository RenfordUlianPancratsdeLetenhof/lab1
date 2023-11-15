using Microsoft.VisualStudio.TestTools.UnitTesting;
using WpfApp1;  // Add the appropriate namespace

[TestClass]
public class BuildingTests
{
    [TestMethod]  // Use [TestMethod] instead of [Test]
    public void TestDisplayInfo()
    {
        // Arrange
        Building office = new Office { Name = "Office Building", NumberOfFloors = 10 };
        Building factory = new Factory { Name = "Factory Building", NumberOfWorkshops = 5 };

        // Act
        string officeInfo = office.DisplayInfo();
        string factoryInfo = factory.DisplayInfo();

        // Assert
        string expectedOfficeInfo = "Building: Office Building\nType: Office | Number of Floors: 10";
        string expectedFactoryInfo = "Building: Factory Building\nType: Factory | Number of Workshops: 5";

        Assert.AreEqual(expectedOfficeInfo, officeInfo);
        Assert.AreEqual(expectedFactoryInfo, factoryInfo);
    }

    [TestMethod]  // Use [TestMethod] instead of [Test]
    public void TestCalculateFoundationHeight()
    {
        // Arrange
        Building office = new Office { Name = "Office Building", NumberOfFloors = 10 };
        Building factory = new Factory { Name = "Factory Building", NumberOfWorkshops = 5 };

        // Act
        double officeFoundationHeight = office.CalculateFoundationHeight();
        double factoryFoundationHeight = factory.CalculateFoundationHeight();

        // Assert
        Assert.AreEqual(0.05 * 10, officeFoundationHeight);
        Assert.AreEqual(0.000002 * 5, factoryFoundationHeight);
    }
}