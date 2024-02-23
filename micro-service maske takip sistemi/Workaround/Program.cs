using Business.Concrete;
using Entities.Concreate;

namespace Workaround
{
    class Program
    {
        static void Main(string[] args)

        {
            Person person1 = new Person();
            person1.FirstName = "SEMANUR";
            person1.LastName = "ORHAN";
            person1.DateOfBirthYear = 2004;
            person1.NationalIdentity = 123;


            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);



        }
    }
}
