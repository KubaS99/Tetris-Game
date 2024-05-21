using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisGraficzny
{
    [Serializable]
    class T : Brick
    {
        public T() : base(5)
        {
            shape[1, 2] = 1;
            shape[2, 1] = 1;
            shape[2, 2] = 1;
            shape[2, 3] = 1;
            kolor = 7;
        }
    }
}
