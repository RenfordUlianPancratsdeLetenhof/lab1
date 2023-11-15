using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WpfApp1;  

[TestClass]
public class BuildingTests
{
    [TestMethod]  
    public void TestDisplayInfo()
    {
    
        Building office = new Office { Name = "Office Building", NumberOfFloors = 10 };
        Building factory = new Factory { Name = "Factory Building", NumberOfWorkshops = 5 };

        string officeInfo = office.DisplayInfo();
        string factoryInfo = factory.DisplayInfo();

     
        string expectedOfficeInfo = "Building: Office Building\nType: Office | Number of Floors: 10";
        string expectedFactoryInfo = "Building: Factory Building\nType: Factory | Number of Workshops: 5";

        Assert.AreEqual(expectedOfficeInfo, officeInfo);
        Assert.AreEqual(expectedFactoryInfo, factoryInfo);
    }

    [TestMethod]  
    public void TestCalculateFoundationHeight()
    {
       
        Building office = new Office { Name = "Office Building", NumberOfFloors = 10 };
        Building factory = new Factory { Name = "Factory Building", NumberOfWorkshops = 5 };

    
        double officeFoundationHeight = office.CalculateFoundationHeight();
        double factoryFoundationHeight = factory.CalculateFoundationHeight();


        Assert.AreEqual(0.05 * 10, officeFoundationHeight);
        Assert.AreEqual(0.000002 * 5, factoryFoundationHeight);
    }
}