using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisGraficzny
{
    [Serializable]
    class Brick
    {
        public int kolor;
        int posY, posX; //polozenie klocka
        protected int[,] shape;//definicja kształtu
        public int PosX { get { return posY; } } //Podmienione, ponieważ bardziej intuicyjny był dla mnie układ kartezjański.
        public int PosY { get { return posX; } }
        public int[,] Shape { get { return shape; } }

        public Brick(int size)
        {
            posY = 4;
            posX = 4;
            shape = new int[size, size];
        }

        public int[,] Rotate(bool clockDirection)
        {
            int[,] wyjsciowa = new int[shape.GetLength(0), shape.GetLength(0)];
            if (clockDirection)
            {
                for (int i = 0; i < shape.GetLength(0); i++)
                {
                    for (int j = 0; j < shape.GetLength(1); j++)
                    {
                        wyjsciowa[i, j] = shape[shape.GetLength(0) - j - 1, i];
                    }
                }
            }
            else
            {
                for (int i = 0; i < shape.GetLength(0); i++)
                {
                    for (int j = 0; j < shape.GetLength(1); j++)
                    {
                        wyjsciowa[i, j] = shape[j, shape.GetLength(0) - i - 1];
                    }
                }
            }
            return wyjsciowa;
        }
        public void Show(int[,] tablica)
        {
            for (int i = 0; i < tablica.GetLength(0); i++)
            {
                for (int j = 0; j < tablica.GetLength(1); j++)
                {
                    Console.Write(tablica[i, j]);
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }

        public void Przepisz(int[,] tablica)
        {
            shape = tablica;
        }
        public void Down()
        {
            posY += 1;
        }
        public void Right()
        {
            posX += 1;
        }
        public void Left()
        {
            posX -= 1;
        }
        public void Start(int x)
        {
            posX = x;
            posY = -1;
        }
    }
}
