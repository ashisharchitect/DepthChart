using Service.Models;

namespace Service.BLL;
public interface ICreateDepthChart
{
    public string AddPlayerToDepthChart(string position, Player player, int? positionDepth);    
}
