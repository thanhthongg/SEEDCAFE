using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
namespace SEEDCAFE.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            CafeDbContext context =
           app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService < CafeDbContext > ();
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            if (!context.Books.Any())
            {
                context.Books.AddRange(
                new Book
                {
                    TenLoaiHat = "Arabica S18",
                    AnhHienThi = "Arabica có thể chinh phục những con người sành điệu ẩm thực nhất. Mùi hương của Arabica rất thanh tao, quý phái.",
                    GioiThieu = "Arabica S18, Cà Phê Nguyên Chất",  
                    Gia = 140.98m
                },
                new Book
                {
                    TenLoaiHat = "Cà Phê Moka",
                    AnhHienThi = "Cà phê Moka cầu đất thuộc dòng Arabica cao cấp, được mệnh danh là nữ hoàng cà phê, là một trong những thương hiệu cà phê nguyên chất nổi tiếng trên thế giới. Tại Việt Nam thì loại cà phê Moka này hiện còn rất ít, nguyên nhân chính dẫn đến điều này là vì năng suất của cây Moka rất thấp, sức chống chọi với sâu bệnh kém, nên giá thành của loại cà phê Moka này rất cao trên thị trường.",
                    GioiThieu = "Cà Phê Nguyên Chất, Cà Phê Moka, MOKA CẦU ĐẤT",
                    Gia = 170.8m
                },
                new Book  
                {
                    TenLoaiHat = "CAFE Phối trộn công thức",
                    AnhHienThi = "Sự phối trộn giữa Robusta, Arabica và Culi Robusta đặc biệt tạo nên sự cân bằng và phong phú cho tách cà phê của bạn.",
                    GioiThieu = "Cà Phê Nguyên Chất, Cà Phê Nguyên Chất, CF Phối trộn",
                    Gia = 90.8m
                },
                new Book
                {
                    TenLoaiHat = "Culi S18 ",
                    AnhHienThi = "Culi Robusta  không phải là một giống cà phê riêng biệt nào, mà nó là  giống cà phê đột biến từ dòng cà phê Robusta. Thông thường, cà phê sẽ có 2 nhân, hình dáng thằng dẹt, nhưng Culi là dòng đột biến, chỉ phát triển 1 nhân,  vậy nên hạt có hình tròn như hạt đậu, mọi người hay gọi là cà phê Bi hay cà phê Culi.",
                    GioiThieu = "Cà Phê Nguyên Chất, Culi Robusta, Culi Robusta S18",
                    Gia = 85.46m
                },
                new Book
                {
                    TenLoaiHat = "Espresso Pha Máy",
                    AnhHienThi = "Espresso thuộc dòng cafe Ý hiện đại, được nhiều người yêu chuộng và lựa chọn làm thức uống hằng ngày. Cách chiết xuất cafe bằng cách dùng nước nóng nén dưới áp suất cao, đi qua bột cà phê được xay mịn thành từng dòng cafe nguyên chất, trung bình mỗi shot khoảng 25 – 30ml. cafe Espresso sau khi pha chế thường tách ra làm hai lớp được gọi là crema và liquid. Nhờ vậy mà Espresso sẽ có vị rất đậm và thơm mà không đắng ngắt. Cách thưởng thức Espresso không phải nhâm nhi như cafe truyền thống bạn hay uống, mà như đúng tên gọi của nó là “Espresso: nhanh, tức thời” nghĩa là bạn chỉ nên uống trong vòng 1 phút.Vì nếu để lâu trong không khí, cafe sẽ bị giảm hương vị.",
                    GioiThieu = "Cà Phê Nguyên Chất, Espresso",
                    Gia = 110.41m
                },
                new Book
                {
                    TenLoaiHat = "Robusta Honey Đặc Sản",
                    AnhHienThi = "ROBUSTA HONEY (RH) được chế biến theo phương pháp mật ong là dòng sản phẩm mới của Phadin Coffee Roasters. Đây là phương pháp chế biến cà phê mới xuất hiện vài năm gần đây và rất được ưa chuộng bởi dễ thực hiện, thân thiện với môi trường và tiết kiệm chi phí đầu tư. Dòng sản phẩm Robusta Honey (RH) của Uyên Phương Coffee được chế biến từ 100% cà phê Robusta cao cấp của vùng đất Buôn Ma Thuột (Dak Lak). Mang đến cho các tín đồ cà phê một tách cà phê thơm ngọt nhẹ mùi mật ong với độ đắng vừa và vị chua nhẹ cực kỳ ấn tượng. ",  
                    GioiThieu = "Cà Phê Nguyên Chất, Robusta Honey",
                    Gia = 135.69m
                },
                new Book
                {
                    TenLoaiHat = "Robusta S18",
                    AnhHienThi = "Cà Phê Robusta hay còn gọi là cà phê Vối, là loại cà phê được dùng làm nguyên liệu chủ yếu cho cà phê pha ở Việt Nam. Gần 90% diện tích cà phê ở Việt Nam được trồng là cà phê Robusta, đặc biệt là vùng Tây nguyên, Buôn Ma Thuột và Việt Nam là nước xuất khẩu Robusta lớn nhất thế giới.",
                    GioiThieu = "Cà Phê Nguyên Chất, Robusta, Robusta S18",
                    Gia = 80.26m
                },
                new Book
                {
                    TenLoaiHat = "Hạt cà phê Cherry",
                    AnhHienThi = "Trên thực tế thì café Cherry được trồng rất hạn chế do nhu cầu thấp, thường thì hạt café Cherry được trộn chung với Robusta, Arabica để tăng mùi hương thơm, tăng vị chua giảm vị đắng tùy nhu cầu của người uống.",
                    GioiThieu = "Hạt cà phê Cherry, Cherry, Cà Phê Nguyên Chất",
                    Gia = 122.98m
                }
                );
                context.SaveChanges();
            }
        }
    }
}
