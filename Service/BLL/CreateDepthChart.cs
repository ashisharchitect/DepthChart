using Service.Common;
using Service.Models;

namespace Service.BLL;
public class CreateDepthChart : ICreateDepthChart
{
    public string AddPlayerToDepthChart(string position, Player player, int? positionDepth)
    {
        DepthChart playerObj = new DepthChart{
            Position = position,
            PositionDepth = positionDepth,
            Player = player,
            Sports="NFL",
            TeamName = "TestTeam"
        };

        var max = Utils.DepthChartValues.Max(x => x.PositionDepth);        
        var pos = Utils.DepthChartValues.FindIndex(a => a.PositionDepth == max);

        if (positionDepth < max)
        {
            Utils.DepthChartValues.Insert(pos - 1, playerObj);

            //The added player would get priority. Anyone below that player in the depth chart would get moved down a position_depth
            for(int i=pos;i<Utils.DepthChartValues.Count;i++)
            {
                if (Utils.DepthChartValues[i].Position==position) //Check the current position name is same so that players under same position can be readjusted
                {
                    Utils.DepthChartValues[i].PositionDepth = Utils.DepthChartValues[i].PositionDepth + 1;
                }
            }
        }
        else
        {
            if (positionDepth == null)
                playerObj.PositionDepth = max + 1; //if position depth is null then add to the last

            Utils.DepthChartValues.Add(playerObj);
        }

        return "Success";
    }

}
