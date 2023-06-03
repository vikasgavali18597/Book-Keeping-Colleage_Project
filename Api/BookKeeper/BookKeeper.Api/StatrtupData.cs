using AutoMapper.Configuration.Annotations;
using BookKeeper.Models;
using System.Runtime.CompilerServices;

namespace BookKeeper.Api
{
    public static class StatrtupData
    {
        
        public static List<AccountCategory> AccountCategories(this IServiceCollection services)
        {

            var currentAssets = new List<Account>()
            {
                new Account { Name = "Cash At Bank", ShortName = "CAB",  Description = "Cash at bank"},
                new Account { Name = "Sundry Debtors", ShortName = "SD",  Description = "Sundry debtors"},
                new Account { Name = "Inventory", ShortName = "Inv",  Description = "Inventory"},
                new Account { Name = "Perpaid Salary", ShortName = "PS",  Description = "PrePaid salary"},
            };

            var fixedAssets = new List<Account>()
            {
                new Account { Name = "Machinery", ShortName = "Machine",  Description = "Machinery"},
                new Account { Name = "Land And Building", ShortName = "LAB",  Description = "Land and building"}
            };


            var currentLiabilities = new List<Account>()
            {
                new Account { Name = "Sundry Creditors", ShortName = "SD",  Description = "Sundry creditors"},
                new Account { Name = "Long Term Loan", ShortName = "LTL",  Description = "Long term loan"}
            };

            var non_CurrentLiabilities = new List<Account>()
            {
                new Account { Name = "Short Term Loan", ShortName = "STL",  Description = "short term loan"}
            };


            var owners_Equity = new List<Account>()
            {
                new Account { Name = "Capital Account", ShortName = "CAP",  Description = "Capital account"}
            };

            var income = new List<Account>()
            {
                new Account { Name = "Product Sales", ShortName = "PS",  Description = "Product sale"},
                new Account { Name = "Service Revenue", ShortName = "SR",  Description = "Service revenue"},
                new Account { Name = "Intrest Income", ShortName = "Int",  Description = "intrest income"}
            };

            var costOfGoodSold = new List<Account>()
            {
                new Account { Name = "Cost Of Goods Sold", ShortName = "CODS",  Description = "Cost of good sold"},
                new Account { Name = "Purchase", ShortName = "P",  Description = "Purchase"}
            };

            var expenses = new List<Account>()
            {
                new Account { Name = "Rent Expense", ShortName = "RExp",  Description = "Rent expense"},
                new Account { Name = "Advertising Expense", ShortName = "AdvExp",  Description = "Advertisment expens"},
                new Account { Name = "Wages", ShortName = "WGS",  Description = "wages "},
                new Account { Name = "Internet and Telephone Expense", ShortName = "IATExp",  Description = "internet and telephone expense"},
                new Account { Name = "Utility Expense", ShortName = "UtilExp",  Description = "Utility expense"},
                new Account { Name = "Delivery and Freight Expense", ShortName = "DAFExp",  Description = "delivery and freight expense"},
                new Account { Name = "Insurence Expense", ShortName = "InsExp",  Description = "Insurence expense"},
            };

            


            var lst = new List<AccountCategory>()
            {
                new AccountCategory { Name = "CurrentAsset", ShortName = "CA", Description = "Current Asset", Accounts = currentAssets },
                new AccountCategory { Name = "Fixed Assets", ShortName = "FA", Description = "Fised Asset", Accounts = fixedAssets },
                new AccountCategory { Name = "Current Liability", ShortName = "CL", Description = "Current Liablilty", Accounts = currentLiabilities },
                new AccountCategory { Name = "Non-Current Liablility", ShortName = "NCL", Description = "Non Current Liablility", Accounts = non_CurrentLiabilities },
                new AccountCategory { Name = "Owner Equity", ShortName = "OE", Description = "Owner Equity", Accounts = owners_Equity },
                new AccountCategory { Name = "Income", ShortName = "Income", Description = "Income", Accounts = income },
                new AccountCategory { Name = "Cost Of Goods Sold", ShortName = "COGS", Description = "Cost of goods sold", Accounts = costOfGoodSold },
                new AccountCategory { Name = "Expense", ShortName = "Exp", Description = "Expense", Accounts = expenses },
            };


            return lst;
        }
    }
}
