using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShirtAppMVC.Models.ViewModels
{
    public class TransactionIndexData
    {
        public IEnumerable<Transaction> Transactions { get; set; }
        public IEnumerable<Shirt> Shirts { get; set; }
    }
}
