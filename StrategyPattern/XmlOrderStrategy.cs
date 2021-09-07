using Models;
using System.IO;
using System.Reflection;
using System.Xml.Serialization;

namespace StrategyPattern
{
    public class XmlOrderStrategy : IOrderFileSavingStrategy
    {
        public void SaveOrderToFile(Order orderToSave)
        {
            using (var writer = new StreamWriter($@"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}\order_{orderToSave.Id}.xml"))
            {
                var xmlSerializer = new XmlSerializer(orderToSave.GetType());

                xmlSerializer.Serialize(writer, orderToSave);
            }
        }
    }
}
