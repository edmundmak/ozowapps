using System;

namespace gameoflife
{
    public class Cell
    {

        public Boolean IsAlive { get; set; }

        public Cell(Boolean isAlive)
        {
            IsAlive = isAlive;
        }
        /// <summary>
        /// ToString implementation of cell
        /// </summary>
        /// <returns>retuns string representation of cell</returns>
        public override string ToString()
        {
            return (IsAlive ? " X " : " - ");
        }
    }
}
