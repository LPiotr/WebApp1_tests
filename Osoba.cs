namespace WebApp1
{
    public class Osoba
    {
        public int Id { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }

        public Osoba(int id, string imie, string nazwisko)
        {
            Id = id;
            Imie = imie;
            Nazwisko = nazwisko;
        }
    }
 
    public class OsobaService
    {
        public List<Osoba> GetOsoby()
        {
            return new List<Osoba>
            {
                new Osoba(1, "Jan", "Kowalski"),
                new Osoba(2, "Anna", "Nowak"),
                new Osoba(3, "Piotr", "Wiśniewski"),
                new Osoba(4, "Maria", "Dąbrowska"),
            };
        }
    }
}
