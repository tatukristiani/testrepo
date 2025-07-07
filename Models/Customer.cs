namespace MyInitApi_6adb681ac5c44c3686fbe2f4d46f11f6.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
 = 0;        [Required]
        [MaxLength(100)]
        public string Email { get; set; }
 = String.Empty;        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }
 = String.Empty;        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }
 = String.Empty;        [Required]
        public DateTime CreatedAt { get; set; }
 = DateTime.UtcNow;    }
}
