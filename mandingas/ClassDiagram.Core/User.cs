namespace ClassDiagram.Core
{
    public class User
    {
        private int _idUser;
        private int _document;
        private string _name;
        private string _surname;
        private string _phone;
        private string _address;
        private string _email;
        private int _idRol;

        public int IdUser { get; set; }
        public int Document { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public int IdRol { get; set; }
    }
}
