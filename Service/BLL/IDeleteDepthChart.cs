using Service.Models;
namespace Service.BLL;
public interface IDeleteDepthChart
{
    public string RemovePlayerFromDepthChart(string position, Player player);
}
