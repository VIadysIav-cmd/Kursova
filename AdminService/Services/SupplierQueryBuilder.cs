using AdminService.Interfaces;
using System.Windows.Forms;
using System;

namespace AdminService.Services
{
    public class SupplierQueryBuilder : IGetQueryBuilder
    {
        public string GetPublicQuery() =>
        "SELECT Parts.Name AS Товар, Suppliers.Name AS Постачальник FROM PartSuppliers JOIN Parts ON Parts.PartID = PartSuppliers.PartID JOIN Suppliers ON Suppliers.SupplierID = PartSuppliers.SupplierID";
        public string GetAllCateroryNamesQuery() =>
        "SELECT Name FROM Suppliers";
        public string GetAllProductNamesQuery() =>
        "SeLECT Name FROM Parts";
        

        
        public string InsertSupplierQuery() =>
        "INSERT INTO Suppliers (Name, Phone, Email) VALUES (@Suppliername, @Phone, @Email)";
        public string InsertContractQuery() =>
        "INSERT INTO PartSuppliers (PartID, SupplierID) VALUES (@part, @supplier)";
        

        public string DeleateSupplierQuery() =>
        "DELETE FROM Suppliers WHERE Name = @SupplierName";
        public string DeleateContractQuery() =>
        "DELETE FROM PartSuppliers WHERE SupplierID = @supplier AND PartID = @part";
        

        public string SupplierIdByNameQuery() =>
        "SELECT SupplierID FROM Suppliers WHERE Name = @SupplierName";
        public string ProductIdByNameQuery() =>
        "SELECT PartID FROM Parts WHERE Name = @ProductName";
        public string GetCheckContractQuery() =>
        "SELECT * FROM PartSuppliers WHERE PartID = @IDpart AND SupplierID = @IDsupplier";
        
    }
}
