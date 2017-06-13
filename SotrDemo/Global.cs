using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SotrDemo
{
    public class SotrAlgItem
    {
        public string Name { get; set; }

    }
    public static class Global
    {
        public static int NumOfAlg = 0;

        public static Random random = new Random(unchecked((int)DateTime.Now.Ticks));
        public static double leftBorder { get; set; }
        public static double rightBorder { get; set; }
        public static int numOfElements{ get; set; }
        public static double[] array { get; set; }

    }
}
