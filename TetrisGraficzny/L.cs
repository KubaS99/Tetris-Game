using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisGraficzny
{
    [Serializable]
    class L : Brick
    {
        public L() : base(5)
        {
            shape[1, 1] = 1;
            shape[2, 1] = 1;
            shape[3, 1] = 1;
            shape[3, 2] = 1;
            kolor = 4;
        }
    }
}
