using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebMVCApplication.Models
{
    public class ShoppingCart
    {
        public List<ShopBanGiayProEntity> danhsach = new List<ShopBanGiayProEntity>();

        public float TongTien
        {
            get;
            set;
        }

        public ShoppingCart()
        {
        }

        public ShopBanGiayProEntity LuaChon(int ChiSo)
        {
            return danhsach[ChiSo];
        }

        public void AddToCart(string id)
        {
            bool daco = false;
            foreach (ShopBanGiayProEntity it in danhsach)
            {
                if (it.MaGiay == id)
                {
                    it.SoLuong += 1;
                    daco = true;
                    break;
                }
            }
            if (daco == false)
                danhsach.Add(new ShopBanGiayProEntity { MaGiay = id, SoLuong = 1 });
        }

        public void XoaItem(string magiay)
        {
            foreach (ShopBanGiayProEntity it in danhsach)
            {
                if (it.MaGiay == magiay)
                    danhsach.Remove(it);
            }
            return;
        }

        public void CapNhatGioHang(ShopBanGiayProEntity giay)
        {
            foreach (ShopBanGiayProEntity it in danhsach)
            {
                if (it.MaGiay == giay.MaGiay)
                {
                    it.SoLuong = giay.SoLuong;
                    if (giay.SoLuong == 0)
                        danhsach.Remove(it);
                    return;
                }
            }
        }
    }
}