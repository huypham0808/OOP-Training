using System;

namespace OOP
{
    class Product
    {
        public double Price { get; set; }
        public virtual void ProductInfor() => Console.WriteLine($"Hien thi gia san pham la: {Price}");
        public void Test() => ProductInfor();
    }
    class IPhone: Product
    {
        public IPhone () => Price = 500;
        public override void ProductInfor ()
        {
            Console.WriteLine($"Dien thoai Iphone");
            base.ProductInfor();
        }
    }
    //abstract class
    abstract class Product2 
    {
        public double Price2 { get; set; }
        public abstract void Product2Infor ();
    }
    class SamSung : Product2 
    {
        public SamSung () => Price2 = 400;
        public override void Product2Infor()
        {
            Console.WriteLine($"Hien thi gia san pham Samsung la: {Price2}");
        }
    }
    //Interface
    interface IHinhHoc
    {
        public double TinhChuVi();
        public double TinhDienTich();
    }
    class HinhChuNhat : IHinhHoc
    {
        private double _chieuRong { get; set; }
        private double _chieuDai { get; set; }
        public HinhChuNhat (double chieuRong, double chieuDai)
        {
            _chieuRong = chieuRong;
            _chieuDai = chieuDai;
        }
        public double TinhChuVi() => (_chieuDai + _chieuRong) * 2;
        public double TinhDienTich() => (_chieuDai * _chieuRong);
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------Vi du Virtual------");
            IPhone iphone14 = new IPhone();
            iphone14.Test();
            Console.WriteLine("------Vi du abstract class------");
            SamSung samSung = new SamSung();
            samSung.Product2Infor();  
            Console.WriteLine("------Vi du Interface------");
            IHinhHoc hinhChuNhat = new HinhChuNhat(4,5);
            Console.WriteLine($"Chu vi hinh chu nhat la: {hinhChuNhat.TinhChuVi()} \n Dien tich hinh chu nhat la : {hinhChuNhat.TinhDienTich()}");
        }
    }
}