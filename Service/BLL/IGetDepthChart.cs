using Service.Models;
namespace Service.BLL;
public interface IGetDepthChart
{
    public string GetBackups(string position, Player player);
    public string GetFullDepthChart();
}
