using System;
using System.Collections.Generic;
using System.Text;

namespace gameoflife
{
    public interface IGames
    {
        public void PlayGame(int rows, int columns);
        public void ToggleGridCell(int x, int y);
        public void Init();
        public int SetMaxGenerations(int generation);
    }
}
