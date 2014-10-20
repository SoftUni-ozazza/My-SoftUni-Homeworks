namespace Customer
{
    using System;
    using System.Collections.Generic;

    class CustomerMain
    {
        static void Main()
        {
            List<Payment> paymentsJoro = new List<Payment>();
            paymentsJoro.Add(new Payment("shirt", 22.99m));
            paymentsJoro.Add(new Payment("shorts", 30.29m));
            paymentsJoro.Add(new Payment("shoes", 72.99m));

            Customer customerJoro = new Customer();
            customerJoro.FirstName = "Joro";
            customerJoro.MiddleName = "M.";
            customerJoro.LastName = "Sharanov";
            customerJoro.Type = Type.Regular;
            customerJoro.Id = 122345667;
            customerJoro.Email = "dzan@bran.cran";
            customerJoro.Mobile = 0123456789;
            customerJoro.Address = "Bulgaria, Sofia";
            customerJoro.PaymentsList = paymentsJoro;

            Customer customerAna = (Customer)customerJoro.Clone();

            Console.WriteLine(customerJoro);
            Console.WriteLine("\nCustomer Ana after cloning from Joro:\n" + customerAna);

            customerAna.FirstName = "Ana";
            customerAna.MiddleName = "D.";
            customerAna.LastName = "Shavlieva";
            customerAna.Id = 987654321;
            customerAna.Mobile = 0112345678;
            customerAna.Email = "ana@gbg.bg";
            customerAna.Address = "Bulgaria, Sofia";
            customerAna.Type = Type.Diamond;

            List<Payment> paymentAna = new List<Payment>();
            paymentAna.Add(new Payment("Gold Jewelry Ring", 712.99m));
            paymentAna.Add(new Payment("Hat", 206.99m));
            customerAna.PaymentsList = paymentAna;

            Console.WriteLine("Equality of the two customers: {0}", customerJoro.Equals(customerAna));
            Console.WriteLine("Hash code Ana: {0}", customerAna.GetHashCode());
            Console.WriteLine("Compare Joro to Ana: {0}", customerJoro.CompareTo(customerAna));
            Console.WriteLine("\nAna as Customer: \n{0}", customerAna);
        }
    }
}
