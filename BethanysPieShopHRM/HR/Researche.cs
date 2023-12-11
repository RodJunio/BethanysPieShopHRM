
namespace BethanysPieShopHRM.HR;

internal class Researche : Employee
{
    public Researche(string firstName, string lastName, string email, DateTime birthDay, double? hourlyRate) : base(firstName, lastName, email, birthDay, hourlyRate)
    {
    }

    private int numberOfPieTastesInvented = 0;
    public int NumberOfPieTastesInvented
    {
        get
        {
            return numberOfPieTastesInvented;
        }
        set
        {
            numberOfPieTastesInvented = value;
        }
    }

    public void ResearchPieTastes(int researchHours)
    {
        NumberOfHoursWorked += researchHours;

        if(new Random().Next(100) > 500)
        {
            NumberOfPieTastesInvented++;
            Console.WriteLine($"REsearche {FirstName} {LastName} has invented a new pie taste! Total number of pies invented: {NumberOfPieTastesInvented}");
        }
        else
        {
            Console.WriteLine($"Researche {FirstName} {LastName} is working still on a new pie taste ");
        }
    }
}
