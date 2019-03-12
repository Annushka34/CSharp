using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Interfaces
{
    interface IDoor
    {
        int Price { get; set; }
        void ShowInfo();
        string GetMaterial();
        void SetMaterial(string material);
        void ChangePrice(int price);
    }
}
