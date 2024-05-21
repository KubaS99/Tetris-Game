using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisGraficzny
{
    [Serializable]
    class O : Brick
    {
        public O() : base(4)
        {
            shape[1, 1] = 1;
            shape[1, 2] = 1;
            shape[2, 1] = 1;
            shape[2, 2] = 1;
            kolor = 5;
        }
    }
}
