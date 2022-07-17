namespace HundredPrisonersRiddle
{
    public interface IPrison
    {
        void FillPrisoners(int allowedNoOfBoxes);
        IPrisoner GetPrisoner(int prisonerId);
    }
}