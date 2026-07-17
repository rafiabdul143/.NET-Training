using System.ComponentModel.DataAnnotations;

namespace GeneralStoreApp.Models
{
    // This class represents ONE product in our store.
    // Every property here will become a COLUMN in a SQL table called "Products".
    public class Product
    {
        // Primary Key.
        // WHY: EF Core has a convention — any property named "Id" (or "<ClassName>Id")
        // is automatically treated as the table's PRIMARY KEY, and SQL Server
        // will auto-generate this value (IDENTITY column) for every new row.
        // We never set this manually when creating a product.
        public int Id { get; set; }

        [Required(ErrorMessage = "Product name is required")]
        [StringLength(100, ErrorMessage = "Product name cannot exceed 100 characters")]
        public string ProductName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Category is required")]
        [StringLength(50)]
        public string Category { get; set; } = string.Empty;

        [Required(ErrorMessage = "Brand is required")]
        [StringLength(50)]
        public string Brand { get; set; } = string.Empty;

        [Required]
        [Range(0.01, 100000, ErrorMessage = "Price must be between 0.01 and 100000")]
        public decimal Price { get; set; }

        [Required]
        [Range(0, 100000, ErrorMessage = "Quantity cannot be negative")]
        public int Quantity { get; set; }

        [Required(ErrorMessage = "Expiry date is required")]
        [DataType(DataType.Date)]
        public DateTime ExpiryDate { get; set; }

        [Required(ErrorMessage = "Supplier name is required")]
        [StringLength(100)]
        public string SupplierName { get; set; } = string.Empty;
    }
}