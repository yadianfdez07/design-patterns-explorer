using Models;
using Newtonsoft.Json;
using System.IO;
using System.Reflection;

namespace StrategyPattern
{
    public class JsonOrderStrategy : IOrderFileSavingStrategy
    {
        public void SaveOrderToFile(Order orderToSave)
        {
            var orderToJson = JsonConvert.SerializeObject(orderToSave);

            using (var writer = new StreamWriter($@"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}\order_{orderToSave.Id}.json"))
            {
                writer.Write(orderToJson);
            }
        }
    }
}
