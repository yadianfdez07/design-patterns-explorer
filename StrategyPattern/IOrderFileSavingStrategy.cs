using Models;

namespace StrategyPattern
{
    public interface IOrderFileSavingStrategy
    {
        void SaveOrderToFile(Order orderToSave);
    }
}
