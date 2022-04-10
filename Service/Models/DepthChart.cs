using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Models
{
    //Have team level depth chart properties
    public class DepthChart
    {
        public string Sports { get; set; } //Enum with more Sports names MLB, NHL, NBA etc
        public string TeamName { get; set; } //Enum with more Team names Team1, Team 2 etc.
        public string Position { get; set; }
        public Player Player { get; set; }
        public int? PositionDepth { get; set; }

    }
}
