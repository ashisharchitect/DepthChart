using Newtonsoft.Json;
using Service.Common;
using Service.Models;

namespace Service.BLL;
public class GetDepthChart: IGetDepthChart
{
    public string GetBackups(string position, Player player)
    {
        List<DepthChart> backUps=new List<DepthChart>();

        var pos = Utils.DepthChartValues.FindIndex(a => a.Position == position && a.Player.Name == player.Name && a.Player.Number == player.Number);

        if (pos > 0)
        {
            //For a given player and position, we want to see all players that are “Backups”, those with a lower position_depth
            for (int i = pos; i < Utils.DepthChartValues.Count; i++)
            {
                backUps.Add(Utils.DepthChartValues[i]);
            }
        }

        var output = JsonConvert.SerializeObject(backUps);

        return output;
    }

    public string GetFullDepthChart()
    {
        var output = JsonConvert.SerializeObject(Utils.DepthChartValues);

        return output;
    }
}
