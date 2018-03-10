namespace Classes
{
    class Customer
    {
        // Property
        public int Id { get; set; }

        // Encapsulation - Impleme ntasyon Gizlenmesi
        private string _firstName;
        public string FirstName
        {
            get => "Mr." + _firstName;
            set => _firstName = value;
        }

        // Auto Property
        public string LastName { get; set; }
        public string City { get; set; }

        // Field
        public string Field;
    }
}