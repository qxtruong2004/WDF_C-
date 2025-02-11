using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    public class User
    {
        public string Name { get; set; }
        private int _Age;
        public int Age
        {
            get => _Age;
            set
            {
                if (value > 0)
                {
                    _Age = value;
                }
                else throw new Exception("Tuổi phải lớn hơn 0");
            }
        }
        public string GioiTinh { get; set; }

    }
}
