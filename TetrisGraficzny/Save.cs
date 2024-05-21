using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisGraficzny
{
    [Serializable]
    class Save
    {
        public Plansza board;
        public int wynik;
        public Brick brick;
        public bool sound;
    }
}
