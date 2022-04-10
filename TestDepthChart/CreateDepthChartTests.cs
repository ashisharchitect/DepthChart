using Service.BLL;
using Service.Models;
using Xunit;

namespace TestDepthChart
{
    public class CreateDepthChartTests
    {

        [Fact]
        public void AddPlayerToDepthChartTest()
        {
            ICreateDepthChart objTest = new CreateDepthChart();

            //1
            string position1 = "QB";
            Player player1 = new Player
            {
                Name = "Tom Brady",
                Number = 12,

            };

            int positionDepth1 = 0;

            var result = objTest.AddPlayerToDepthChart(position1, player1, positionDepth1);
        
            //2
            string position2 = "QB";
            Player player2 = new Player
            {
                Name = "Blaine Gabbert",
                Number = 11,

            };

            int positionDepth2 = 1;

            objTest.AddPlayerToDepthChart(position2, player2, positionDepth2);
        

            //3
            string position3 = "QB";
            Player player3 = new Player
            {
                Name = "Kyle Trask",
                Number = 2,

            };

            int positionDepth3 = 2;

            objTest.AddPlayerToDepthChart(position3, player3, positionDepth3);


            //4
            string position4 = "QB";
            Player player4 = new Player
            {
                Name = "Mike Evans",
                Number = 13,

            };

            int positionDepth4 = 0;

            objTest.AddPlayerToDepthChart(position4, player4, positionDepth4);

            //5
            string position5 = "LWR";
            Player player5 = new Player
            {
                Name = "Jaelon Darden",
                Number = 1,

            };

            int? positionDepth5 = null;

            objTest.AddPlayerToDepthChart(position5, player5, positionDepth5);
        
            //6
            string position6 = "LWR";
            Player player6 = new Player
            {
                Name = "Scott Miller",
                Number = 10,

            };

            int? positionDepth6 = null;

            objTest.AddPlayerToDepthChart(position6, player6, positionDepth6);
        }


        [Fact]
        public void GetBackupsTest()
        {
            //GetBackUps
            IGetDepthChart objGetBackups = new GetDepthChart();
            string position = "QB";
            Player player = new Player
            {
                Name = "Tom Brady",
                Number = 12,
            };

            objGetBackups.GetBackups(position, player);
        }

        [Fact]
        public void GetFullDepthChartTest()
        {
            //GetFullDepthChart
            IGetDepthChart objGetFullDepthChart = new GetDepthChart();

            objGetFullDepthChart.GetFullDepthChart();
        }


        [Fact]
        public void RemovePlayerFromDepthChartTest()
        {
            //Delete Operation
            IDeleteDepthChart objDelete = new DeleteDepthChart();

            string position = "QB";
            Player player = new Player
            {
                Name = "Tom Brady",
                Number = 12,
            };

            objDelete.RemovePlayerFromDepthChart(position, player);
        }

    }
}