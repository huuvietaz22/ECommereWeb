namespace ECommereWeb.ViewModels
{
    public class HangHoaVM
    {
        public int MaHh { get; set; }
        public string TenHh { get; set; } = string.Empty;
        public double DonGia { get; set; }
        public string Hinh { get; set; } = string.Empty;
        public string MoTaNgan { get; set; } = string.Empty;
        public string TenLoai { get; set; }
    }


    public class ChiTietHangHoaVM
    {
        public int MaHh { get; set; }
        public string TenHh { get; set; } = string.Empty;
        public double DonGia { get; set; }
        public string Hinh { get; set; } = string.Empty;
        public string MoTaNgan { get; set; } = string.Empty;
        public string TenLoai { get; set; }
        public string ChiTiet
        {
            get; set;
        }
        public int DiemDanhGia { get; set; }
        public int SoLuongTon { get; set; }
    }
}