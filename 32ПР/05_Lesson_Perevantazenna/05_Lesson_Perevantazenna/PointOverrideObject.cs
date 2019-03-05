using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Lesson_Perevantazenna
{
    public partial class Point
    {
        #region OverrideBool
        public override string ToString()
        {
            return String.Format("X = {0} Y = {1}", X, Y);
        }
        public override bool Equals(object obj)
        {
            return ((Point)obj).X == this.X && ((Point)obj).Y == this.Y;
        }
        public override int GetHashCode()
        {
            return (X.ToString() + Y.ToString()).GetHashCode();
        }
        #endregion
    
    }
}
