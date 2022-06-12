using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace SEEDCAFE.Models
{
    public class Book
    {
        public long BookID { get; set; }
        [Required(ErrorMessage = "Xin hãy điền tên loại hạt ")]
        public string TenLoaiHat { get; set; }
        [Required(ErrorMessage = "Gửi ảnh ví dụ (nếu có)")]
        public string AnhHienThi { get; set; }
        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "Xin hãy nhập giá ")]
        [Column(TypeName = "decimal(8, 2)")]
        public decimal Gia { get; set; }
        [Required(ErrorMessage = "Nêu vài lời giới thiệu về hạt")]
        public string GioiThieu { get; set; }
    }
}