using BilgeAdam.AgentCommon.Enums;
using System;

namespace BilgeAdam.AgentCommon.Models
{
    public class Model
    {
        //isim verisini saklayacak nesne
        private string firstName;
        //isim verisini taşıyacak nesne
        public string FirstName // --> Full Property
        {
            get
            {
                if (string.IsNullOrEmpty(firstName))
                {
                    return "Tanımsız"; // firstname burada Tanımsız değerine sahip olmaz!!!!
                }
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }
        private string lastName;
        public string LastName // --> Full Property
        {
            get
            {
                return lastName.ToUpper();
            }
            set
            {
                if (value.Length < 2)
                {
                    throw new Exception("Soy isim 3 harften kısa olamaz");
                }
                lastName = value;
            }
        }
        private DateTime birthDate;
        public DateTime BirthDate // Auto property olarak yazılabilir. Çünkü özel bir durum belirtilmemiş
        {
            get { return birthDate; }
            set { birthDate = value; } //value bu değer setlenirken (değer atanırken) eşitliğin karşısındaki değer anlamına gelen keyword'dür
        }
        public string Country { get; set; } //Auto property
        public decimal Heigth { get; set; }
        public decimal Weigth { get; set; }
        public Gender Gender { get; set; }
        public MaritialStatus Status { get; set; }
        public Size Size { get; set; }
    }
}
