using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    public class HoaDon
    {
        public string Name { get; set; }
        public double Old { get; set; }
        private double _new;
        public double New
        {
            get => _new;
            set
            {
                if (value >= Old)
                    _new = value;
                else
                    throw new Exception("Chỉ số mới phải lớn hơn hoặc bằng chỉ số cũ!");
            }
        }
        public double Spend => New - Old;
        public double Total_Pay => Spend > 50 ? 500 * 50 + (Spend -50) * 1000 : 500 * Spend;
        public double SpendUnder => Spend < 50 ? Spend : 50;
        public double SpendOver => Spend > 50 ? Spend - 50 : 0;
        
    }
}
