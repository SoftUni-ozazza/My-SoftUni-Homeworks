namespace Customer
{
    using System;
    using System.Collections.Generic;

    public class Customer : ICloneable, IComparable<Customer>
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private ulong id;
        private string address;
        private ulong mobile;
        private string email;
        private List<Payment> paymentsList;
        private Type type;

        public Customer()
        {
        }

        public Customer(string firstName, string middleName, string lastName,
                        ulong id, string address, ulong mobile, string email,
                        List<Payment> paymentList, Type type)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.Id = id;
            this.Address = address;
            this.Mobile = mobile;
            this.Email = email;
            this.PaymentsList = new List<Payment>();
            this.Type = new Type();
        }

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public ulong Id { get; set; }
        public string Address { get; set; }
        public ulong Mobile { get; set; }
        public string Email { get; set; }
        public List<Payment> PaymentsList { get; set; }
        public Type Type { get; set; }


        public override bool Equals(object param)
        {
            Customer customer = param as Customer;
            if (customer == null)
            {
                return false;
            }

            if (!Object.Equals(this.FirstName, customer.FirstName))
            {
                return false;
            }

            if (!Object.Equals(this.MiddleName, customer.MiddleName))
            {
                return false;
            }

            if (!Object.Equals(this.LastName, customer.LastName))
            {
                return false;
            }

            if (this.Id != customer.Id)
            {
                return false;
            }

            return true;
        }

        public override string ToString()
        {
            string customerPaymentList = String.Format("\n{0}'s Payment List:\n", this.FirstName);
            foreach (var payment in this.PaymentsList)
            {
                customerPaymentList += String.Format("{0} ${1:F2}\n",
                    payment.ProductName, payment.Price);
            }

            string customer = String.Format(
                "{0} {1} {2} \nID {3} \n{4} \nMobile {5} \n{6} \nType {7} \n{8}",
                this.FirstName,
                this.MiddleName,
                this.LastName,
                this.Id,
                this.Address,
                this.Mobile,
                this.Email,
                this.Type,
                customerPaymentList);

            return customer;
        }

        public override int GetHashCode()
        {
            int hash = this.FirstName.GetHashCode() ^
                       this.MiddleName.GetHashCode() ^
                       this.LastName.GetHashCode() ^
                       this.Id.GetHashCode() ^
                       this.Address.GetHashCode() ^
                       this.Mobile.GetHashCode() ^
                       this.Email.GetHashCode() ^
                       this.PaymentsList.GetHashCode() ^
                       this.Type.GetHashCode();

            return hash;
        }

        public static bool operator ==(Customer firstCustomer, Customer secondCustomer)
        {
            return Customer.Equals(firstCustomer, secondCustomer);
        }

        public static bool operator !=(Customer firstCustomer, Customer secondCustomer)
        {
            return !(Customer.Equals(firstCustomer, secondCustomer));
        }

        public object Clone()
        {
            Customer newCustomer = new Customer();
            newCustomer.PaymentsList = new List<Payment>();
            foreach (var payment in this.PaymentsList)
            {
                newCustomer.PaymentsList.Add(payment);
            }

            newCustomer.Type = new Type();

            return newCustomer;
        }

        public int CompareTo(Customer customer)
        {
            string fullNameThis = String.Format(this.FirstName + " " + this.MiddleName + " " + this.LastName);
            string fullNameCustomer = customer.FirstName + " " + customer.MiddleName + " " + customer.LastName;

            if (fullNameThis.CompareTo(fullNameCustomer) != 0)
            {
                return fullNameThis.CompareTo(fullNameCustomer);
            }

            return this.Id.CompareTo(customer.Id);
        }
    }
}
