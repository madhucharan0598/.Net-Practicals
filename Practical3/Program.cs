using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical3
{
    class Expense
    {
        public int ExpenseID;
        public string Category;
        public double Amount;
        public string PaymentMode;
        public DateTime ExpenseDate;

        public void AddExpense()
        {
            Console.Write("Enter Expence ID: ");
            ExpenseID = Convert.ToInt16(Console.ReadLine());

            Console.Write("Enter Expence Category: ");
            Category = Console.ReadLine();

            Console.Write("Enter Expense Amount: ");
            Amount = Convert.ToDouble(Console.ReadLine());

            if (Amount <= 0)
            {
                throw new Exception("Amount should be above 0");
            }

            Console.Write("Enter Payment Mode (Cash/UPI/Card): ");
            PaymentMode = Console.ReadLine();

            ExpenseDate = DateTime.Now;
        }

        public void DisplayExpense()
        {
            Console.WriteLine("==============================================");
            Console.WriteLine("                 Expense Details              ");
            Console.WriteLine("==============================================");
            Console.WriteLine("Expense ID              :" + ExpenseID);
            Console.WriteLine("Expense Category        :" + Category);
            Console.WriteLine("Expence Amount          :" + Amount);
            Console.WriteLine("Payment Mode            :" + PaymentMode);
            Console.WriteLine("Expense Added Date      :" + ExpenseDate);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Expense> e1 = new List<Expense>();

            int choice = 0;

            do
            {
                Console.WriteLine("\n------------------------------------------");
                Console.WriteLine("            Expense Tracking Module         ");
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("1.   Add Expense");
                Console.WriteLine("2.   View All Expenses");
                Console.WriteLine("3.   View Total Expense");
                Console.WriteLine("4.   Exit");
                Console.WriteLine("------------------------------------------");

                try
                {
                    Console.WriteLine("Enter Your Choice: ");
                    choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            try
                            {
                                Expense e = new Expense();
                                e.AddExpense();

                                e1.Add(e);

                                Console.WriteLine("\nExpense added successfully.");
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Error while adding expense: " + ex.Message);
                            }
                            break;

                        case 2:
                            Console.WriteLine("\n========= All Expenses =========");

                            if (e1.Count == 0)
                            {
                                Console.WriteLine("No expenses found.");
                            }
                            else
                            {
                                foreach (Expense expense in e1)
                                {
                                    expense.DisplayExpense();
                                }
                            }
                            break;

                        case 3:
                            double total = 0;

                            foreach (Expense expense in e1)
                            {
                                total += expense.Amount;
                            }

                            Console.WriteLine("Total Amount Spent: " + total);
                            break;

                        case 4:
                            Console.WriteLine("Thank You for Using Expense Tracker.");
                            break;

                        default:
                            Console.WriteLine("Invalid Choice.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            while (choice != 4);
        }
    }
}
