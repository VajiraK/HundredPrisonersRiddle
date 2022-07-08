namespace HundredPrisonersRiddle
{
    public interface IRiddle
    {
        bool Run(int allowedNoOfBoxes);
        void Initialize();

        IRoom GetRoom();
    }
}