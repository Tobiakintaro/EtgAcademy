using EtgAcademy2025.Models.DataBase;
using EtgAcademy2025.Models.DataBase.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtgAcademy2025
{
    static public class DbOps
    {



        static public void GetTransactions()
        {
            using (var context = new DataContext())
            {
                var transactions = context.TransactionTb.AsNoTracking()
                    .Where(t => t.Amount > 1000)
                    .OrderByDescending(t => t.TransactionDate)
                    .ToList();

                foreach (var transaction in transactions)
                {
                    Console.WriteLine($"ID: {transaction.TransactionId}, Date: {transaction.TransactionDate}, Amount: {transaction.Amount}");
                }
            }

        }


        static public void AddTransaction(string transactionId)
        {
            using (var context = new DataContext())
            {
                var newTransaction = new TransactionTb
                {
                    TransactionId = transactionId,
                    TransactionDate = DateTime.Now,
                    Amount = 1500.00m,
                    Description = "Sample Transaction",
                    AccountId = "ACC123456"
                };
                context.TransactionTb.Add(newTransaction);
                context.SaveChanges();
                Console.WriteLine("New transaction added successfully.");
            }
        }


        static public void UpdateTransactions(string transactionId)
        {
            using (var context = new DataContext())
            {


                // var transaction = from t in context.TransactionTb where t.TransactionId == transactionId select new { t.Amount, t.TransactionId };



                var transaction = context.TransactionTb.Where(t => t.TransactionId == transactionId).FirstOrDefault();
                if (transaction != null)
                {
                    transaction.Amount = 2000.00m;
                    context.SaveChanges();
                    Console.WriteLine("Transaction updated successfully.");
                }
                else
                {
                    Console.WriteLine("Transaction not found.");
                }
            }
        }

        static public void DeleteTransaction(string transactionId)
        {
            using (var context = new DataContext())
            {
                var transaction = context.TransactionTb
                    .FirstOrDefault(t => t.TransactionId == transactionId);
                if (transaction != null)
                {
                    context.TransactionTb.Remove(transaction);
                    context.SaveChanges();
                    Console.WriteLine("Transaction deleted successfully.");
                }
                else
                {
                    Console.WriteLine("Transaction not found.");
                }
            }
        }


    }
}
