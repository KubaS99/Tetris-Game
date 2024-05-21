using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisGraficzny
{
    [Serializable]
    class Z : Brick
    {
        public Z() : base(5)
        {
            shape[1, 1] = 1;
            shape[1, 2] = 1;
            shape[2, 2] = 1;
            shape[2, 3] = 1;
            kolor = 8;
        }
    }
}
