using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;
namespace SEEDCAFE.Models
{
    public class Order
    {
        [BindNever]
        public int OrderID { get; set; }
        [BindNever]
        public ICollection<CartLine> Lines { get; set; }
        [Required(ErrorMessage = "Vui lòng để lại Tên ")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Vui lòng để lại Họ ")]
        public string Line1 { get; set; }
        [Required(ErrorMessage = "Vui lòng để lại tên Tỉnh/ Thành phố ")]
        public string Line2 { get; set; }
        [Required(ErrorMessage = "Vui lòng để lại tên Quận/ Thị xã/ Huyện  ")]
        public string City { get; set; }
        [Required(ErrorMessage = "Vui lòng để lại Phường/ Xã/ Thị trấn")]
        public string State { get; set; }
        public string Zip { get; set; }
        [Required(ErrorMessage = "Vui lòng để lại tên Quốc gia ")]
        public string Country { get; set; }
        [BindNever]
        public bool Shipped { get; set; }
    }
}
