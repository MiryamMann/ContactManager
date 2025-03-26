using CreationalPatterns;
using CreationalPatterns.Builder;
using CreationalPatterns.FactoryFolder;
using CreationalPatterns.Prototype;
using CreationalPatterns.Singleton;


ContactList contactsList = new ContactList();
Registry registry = new Registry();
SimBuilder simBuilder = new SimBuilder();
PhoneBuilder phonBuilder = new PhoneBuilder();
ContactDirector director = new ContactDirector(phonBuilder);

contactsList.AddContactPerson("Rachel", "0583250828", Groups.Friends, new FactoryPhon());
contactsList.AddContactPerson("Batya", "0504105613", Groups.Family, new FactorySIM());

ContactPerson contactFamily = (PhoneContact)registry.GetType(Groups.Family);
contactFamily.Name = "Ayala";
contactFamily.PhoneNumber = "0548505273";
contactFamily.Properties["email"] = "ayalag5273@mail.com";
contactFamily.Properties["birthday"] = "20/12/02";
contactsList.AddContactPerson(contactFamily);

ContactPerson contactWork = (PhoneContact)registry.GetType(Groups.Work);
contactWork.Name = "Nechami";
contactWork.PhoneNumber = "0533145746";
contactWork.Properties["email"] = "nechami5273@mail.com";
contactsList.AddContactPerson(contactWork);



ContactPerson simContact = director.SetContact1("Hadas", "0546285471", Groups.Friends, "Destry", "Magenta");
contactsList.AddContactPerson(simContact);
director.ChangeBuilder(simBuilder);

ContactPerson phoneContact = director.SetContact2("Aba", "0527638593", Groups.Family, "07/12/78", "myf031@gmail.com");
contactsList.AddContactPerson(phoneContact);


phonBuilder.Reset("Hadassah", "0504108541", Groups.Work);
phonBuilder.AddColor("Brown");
phonBuilder.AddEmail("hadasa3281@gmail.com");
phonBuilder.AddBirthday("17/03/05");
phonBuilder.AddRington("destry");
ContactPerson phone = phonBuilder.Save();
contactsList.AddContactPerson(phone);


void FindByName()
{
    Console.WriteLine("enter the name:");
    string name = Console.ReadLine();
    ContactPerson findContact = contactsList.findContacPersonByName(name);
    if (findContact != null)
        ColorPrinting.Printer.Print("The contact:", findContact);
    else Console.WriteLine("No results.");
}
void FindByPhone()
{
    Console.WriteLine("enter the phone Number:");
    string phone = Console.ReadLine();
    ContactPerson findContact = contactsList.findContacPersonByNumber(phone);
    if (findContact != null)
        ColorPrinting.Printer.Print("The contact:", findContact);
    else Console.WriteLine("No results.");
}
void printAllContact()
{
    for (int i = 0; i < contactsList.contactList.Count(); i++)
    {
        ColorPrinting.Printer.Print($"The contact:{i}", contactsList.contactList[i]);
    }
}

while (true)
{
    Console.WriteLine("Select the desired option (enter number): ");
    Console.WriteLine("1. Search contact by name");
    Console.WriteLine("2. Search contact by phone number");
    Console.WriteLine("3. Print all contacts");

    var choice = Console.ReadLine();
    switch (choice)
    {
        case "1":
            FindByName();
            break;

        case "2":
            FindByPhone();
            break;

        case "3":
            printAllContact();
            break;

        default:
            Console.WriteLine("Invalid choice. Please try again.");
            break;
    }
}