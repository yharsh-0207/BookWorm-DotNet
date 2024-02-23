using BookWorm_DotNet.Models;

namespace BookWorm_DotNet.Repositories
{
    public interface IMyShelfRepository
    {
        ICollection<MyShelf> GetMyShelves();

        ICollection<MyShelf> GetMyShelvesByCustomerId(long customerId);

        MyShelf AddToShelf(MyShelf myShelf);

        MyShelf DeleteShelf(long shelfId);
    }
}
