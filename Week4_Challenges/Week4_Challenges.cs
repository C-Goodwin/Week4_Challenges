using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_Challenges
{
    abstract class OwnerInfo
    {
        public string OwnerName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public int NumberOfPets {get; set;}

        public OwnerInfo() { }

        public OwnerInfo(string ownerName, string address, string phoneNumber,
          string email, int numOfPets)
        {
            OwnerName = ownerName;
            Address = address;
            PhoneNumber = phoneNumber;
            Email = email;
            NumberOfPets = numOfPets;
        }
    }
    
    class PetInfo : OwnerInfo
    {
        public string PetName { get; set; }
        public string Species { get; set; }
        public string Breed { get; set; }
        public string Color { get; set; }
        public bool IsChipped { get; set; }
        public bool IsFixed { get; set; }

        public PetInfo() { }
        public PetInfo(string ownerName, string address, string phoneNumber,
          string email, int numOfPets, string petName, string species, string breed, string color,
            bool isChipped, bool isFixed)
            :base(ownerName,address,phoneNumber, email, numOfPets)
        {
            PetName = petName;
            Species = species;
            Breed = breed;
            Color = color;
            IsChipped = isChipped;
            IsFixed = isFixed;
        }
    }
    public enum MethodOfPayment
    {
            Cash = 1,
            Check,
            CreditCard,
            DebitCard

    }
    class BillingInfo : OwnerInfo
    {
        public MethodOfPayment MethodOfPayment { get; set; }
        public long CardNumber { get; set; }
        public string ExpirationDate { get; set; }
        public int CVV { get; set; }

        public BillingInfo() { }
        public BillingInfo(string ownerName, string address, string phoneNumber,
          string email, int numOfPets, MethodOfPayment method, long cardNum, string expDate, int cvv)
            :base(ownerName, address, phoneNumber, email, numOfPets)
        {
            MethodOfPayment = method;
            CardNumber = cardNum;
            ExpirationDate = expDate;
            CVV = cvv;
        }
    }
}
