namespace HundredPrisonersRiddle
{
    public interface IPisoner
    {
        int PrisonerId { get; set; }

        IBox FindYourBox(IRoom room, int allowedNoOfBoxes);
    }
}