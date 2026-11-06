using System.ComponentModel.DataAnnotations;

namespace CDEProj.API.Models
{
    public class Product
        {
                public int Id { get; set; }

                        [Required]
                                [StringLength(150)]
                                        public string Name { get; set; } = string.Empty;

                                                [StringLength(1000)]
                                                        public string? Description { get; set; }

                                                                [Required]
                                                                        public decimal Price { get; set; }

                                                                                public int StockQuantity { get; set; }

                                                                                        [StringLength(500)]
                                                                                                public string? ImageUrl { get; set; }

                                                                                                        public bool IsActive { get; set; } = true;

                                                                                                                public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
                                                                                                                    }
                                                                                                                    }