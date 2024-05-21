using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisGraficzny
{
    [Serializable]
    class I : Brick
    {
        
        public I() : base(7)
        {
            shape[1, 2] = 1;
            shape[2, 2] = 1;
            shape[3, 2] = 1;
            shape[4, 2] = 1;
            kolor = 2;
            
        }
    }
}
