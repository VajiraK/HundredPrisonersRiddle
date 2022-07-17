namespace HundredPrisonersRiddle
{
    public interface IRiddle
    {
        bool Run();
        void Initialize(int allowedNoOfBoxes);

        IRoom GetRoom();
    }
}