namespace BethanysPieShopHRM.HR;

internal interface IEmployee
{
    double ReceiveWage(bool resetHours = true);
    void GiveBonus();
    void PerformWork();
    void PerformWork(int numberofHours);
    void DisplayEmployeeDetails();
    void GiveCompliment();
}
