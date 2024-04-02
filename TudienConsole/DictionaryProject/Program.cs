using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryProject
{
    public class Program
    {
        private static Dictionary<string, string> dic = new Dictionary<string, string>();
        static void Main(string[] args)
        {
            while (true)
            {
                Menu();
                Console.WriteLine("Ban co muon tiep tuc: c/k");
                string kq = Console.ReadLine();
                if (kq == "k")
                    break;
            }
            Console.WriteLine("BYE BYE");
            Console.ReadKey();
        }
        private static void Menu()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Tu dien Anh - Viet");
            Console.WriteLine("1. Them tu");
            Console.WriteLine("2. Sua tu");
            Console.WriteLine("3. Tra cuu");
            Console.WriteLine("4. Xoa tu");
            int chooseOption = Int16.Parse(Console.ReadLine());
            switch (chooseOption)
            {
                case 1:
                    ThemTu();
                    break;
                case 2:
                    SuaTu();
                    break;
                case 3:
                    TraCuu();
                    break;
                case 4:
                    XoaTu();
                    break;
                default:
                    Console.WriteLine("Please try again!");
                    break;
            }
        }
        private static void XoaTu()
        {
            throw new NotImplementedException();
        }

        private static void TraCuu()
        {
            throw new NotImplementedException();
        }

        private static void SuaTu()
        {
            throw new NotImplementedException();
        }

        private static void ThemTu()
        {
            Console.WriteLine("Nhap tu Tieng Anh:");
            string ta = Console.ReadLine();
            if (dic.ContainsKey(ta))
            {
                Console.WriteLine("Tu [0] da ton tai", ta);
            }
            else
            {
                Console.WriteLine("Nhap tu Tieng Viet:");
                string tv = Console.ReadLine();
            }
        }
    }
}
