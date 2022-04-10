using Service.Common;
using Service.Models;

namespace Service.BLL;
public class DeleteDepthChart : IDeleteDepthChart
{
    public string RemovePlayerFromDepthChart(string position, Player player)
    {
        var max = Utils.DepthChartValues.Max(x => x.PositionDepth);
        var pos = Utils.DepthChartValues.FindIndex(a => a.Position==position && a.Player.Name==player.Name && a.Player.Number==player.Number);

        if(pos>0)
            Utils.DepthChartValues.RemoveAt(pos-1);

        return "Success";
    }
}
