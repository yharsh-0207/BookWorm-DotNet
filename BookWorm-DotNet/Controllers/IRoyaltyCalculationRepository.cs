using BookWorm_DotNet.Models;

namespace BookWorm_DotNet.Controllers
{
    public interface IRoyaltyCalculationRepository
    {
        RoyaltyCalculation AddRoyaltyCalculation(RoyaltyCalculation royaltyCalculation);
    }
}
