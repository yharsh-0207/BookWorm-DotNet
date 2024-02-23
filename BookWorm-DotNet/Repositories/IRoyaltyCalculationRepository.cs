using BookWorm_DotNet.Models;

namespace BookWorm_DotNet.Repositories
{
    public interface IRoyaltyCalculationRepository
    {
        RoyaltyCalculation AddRoyaltyCalculation(RoyaltyCalculation royaltyCalculation);
    }
}
