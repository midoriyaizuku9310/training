
/*
using ConsoleApp02;
using System.Diagnostics;


class PersonBO2
{
    private List<PersonModel> people = new List<PersonModel> {
              new PersonModel { Id = 1, PName = "Anil", Gender = "Male", Age = 20 },
              new PersonModel { Id = 2, PName = "Bharathi", Gender = "Female", Age = 25 },
              new PersonModel { Id = 3, PName = "Charan", Gender = "Male", Age = 22 },
              new PersonModel { Id = 4, PName = "David", Gender = "Male", Age = 33 }
          };
    public List<PersonModel> GetAll()
    {
        return people;
    }
    public PersonModel? GetById(int id)
    {
        PersonModel? person = new PersonModel();
        for (int i = 0; i < people.Count; i++)
        {
            if (people[i].Id == id)
            {
                person = people[i];
                break;
            }
        }
        return person;
    }
    public void Add(PersonModel p)
    {
        people.Add(p);
    }
}

namespace ConsApp02
{
    class Program15
    {
        static PersonBO2 context = new PersonBO2();
        static int Menu()
        {
            Console.Write("Menu\n1.Display All People\n2.Search Person By Id\n3.Add Person\n6.Exit\nEnter choice: ");
            int ch = Convert.ToInt32(Console.ReadLine());
            return ch;
        }
        static void DisplayAllPeople()
        {
            List<PersonModel> people = context.GetAll();

            foreach (PersonModel p in people)
                Console.WriteLine($"{p.Id} {p.PName} {p.Gender} {p.Age}");
        }
        static void DisplayPersonById()
        {
            Console.Write("Enter id to serach: ");
            int id = Convert.ToInt32(Console.ReadLine());
            PersonModel? p = context.GetById(id);
            if (p is null)
                Console.WriteLine($"{id} not exist...");
            else
                Console.WriteLine($"{p.Id} {p.PName} {p.Gender} {p.Age}");
        }
        static PersonModel ReadPerson()
        {
            PersonModel p = new PersonModel();
            Console.Write("Enter id: ");
            p.Id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Person Name: ");
            p.PName = Console.ReadLine();
            Console.Write("Enter Gender: ");
            p.Gender = Console.ReadLine();
            Console.Write("Enter AGe: ");
            p.Age = Convert.ToInt32(Console.ReadLine());
            return p;
        }
        static void AddPerson()
        {
            context.Add(ReadPerson());
        }
        static void Main()
        {
            int ch = 0;
            do
            {
                ch = Menu();
                switch (ch)
                {
                    case 1:
                        DisplayAllPeople();
                        break;
                    case 2:
                        DisplayPersonById();
                        break;
                    case 3:
                        AddPerson();
                        break;
                    case 6:

                        break;
                    default:
                        Console.WriteLine("Invalid input choice...");
                        break;
                }
            } while (ch != 6);

        }
    }
}


public void EditPersonById(int id, PersonModel p)
{
    int index = 0;
    for (int i = 0; i < people.Count; i++)
    {
        if (p.Id == id)
        {
            index = i;
            break;
        }
    }
    if ( index!=0)
        people.RemoveAt(index);
}

static void EditPerson()
{
    PersonModel p = ReadPerson();
    context.EditPersonById(p.Id, p);
}
*/