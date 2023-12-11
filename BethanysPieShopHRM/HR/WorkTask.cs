namespace BethanysPieShopHRM.HR
{
    internal struct WorkTask
    {
        public string description;
        public int hours;

        public void PerformaWorkTask()
        {
            Console.WriteLine($"Task {description} of {hours} hour(s) has been performed.");
        }
    }
}
