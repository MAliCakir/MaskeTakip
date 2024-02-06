// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using Entities.Concrete;



Person person1 = new Person();
person1.FirstName = "Mehmet Ali";
person1.LastName = "ÇAKIR";
person1.DateOfBirthYear = 1982;
person1.NationalIdendity = 21427669122;


SelamVer(person1);
PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(person1);

static void SelamVer(Person person)
{
    Console.WriteLine("Merhaba " + person.FirstName + " Hoşgeldiniz.");
}
public class Vatandas
{
    public string Ad { get; set; }
    public string Soyad { get; set; }

    public int DogumYili { get; set; }
    public long TcNo { get; set; }

}
