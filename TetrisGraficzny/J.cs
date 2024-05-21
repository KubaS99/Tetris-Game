using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisGraficzny
{
    [Serializable]
    class J : Brick
    {
        public J() : base(5)
        {
            shape[1, 3] = 1;
            shape[2, 3] = 1;
            shape[3, 3] = 1;
            shape[3, 2] = 1;
            kolor = 3;
        }
    }
}
