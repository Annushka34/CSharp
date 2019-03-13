using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IRooming
    {
        bool AddRoom(object room);
        bool RemoveRoom(string name);
        void ShowAll();
        void ShowRoomByName(string name);
    }
}
