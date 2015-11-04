using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebMVCApplication.Models
{
    public class ShopBanGiayProEntity
    {
        public string MaGiay
        {
            get;
            set;
        }

        public float DonGia
        {
            get;
            set;
        }

        public int SoLuong
        {
            get;
            set;
        }

        public float ThanhTien
        {
            get;
            set;
        }

        public ShopBanGiayProEntity()
        {
        }

        public ShopBanGiayProEntity(string magiay, int soluong, float gia, float thanhtien)
        {
            this.MaGiay = magiay;
            this.SoLuong = soluong;
            this.DonGia = gia;
            this.ThanhTien = thanhtien;
        }
    }
}