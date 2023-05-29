using BookKeeper.Service.Implementations;
using BookKeeper.Service.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace BookKeeper.Service
{
    public class BookKeeperExtenssionCollection
    {
        public  IServiceCollection AddService(IServiceCollection service)
        {
            service.AddScoped<IAccountCategoryService, AccountCategoryService>();
            service.AddScoped<IAccountService, AccountService>();
            service.AddScoped<IJournalEntryService, JournalEntryService>();
            return service;
        }
    }
}
