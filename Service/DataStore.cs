using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WalletManager.Service
{
    public class DataStore
    {
        public List<Transaction> Transactions { get; set; } = new List<Transaction>();
        public List<Tag> Tagss { get; set; } = new List<Tag>();
        public List<User> Users { get; set; } = new List<User>();
        public List<Credit> credits { get; set; } = new List<Credit>();

        public List<Debit> debits { get; set; } = new List<Debit>();

        public List<Debt> debts { get; set; } = new List<Debt>();
        public List<Currency> currency { get; set; } = new List<Currency>();

        public List<UserFile> userfiles { get; set; } = new List<UserFile>();




    }

}
