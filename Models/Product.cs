namespace MyInitApi_6adb681ac5c44c3686fbe2f4d46f11f6.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
 = 0;        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
 = String.Empty;        [Required]
        [Precision(2, 10)]
        public decimal Price { get; set; }
 = 0.0m;        [MaxLength(500)]
        public string? Description { get; set; }
        [Required]
        public bool InStock { get; set; }
 = false;    }
}
