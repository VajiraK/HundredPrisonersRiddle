namespace HundredPrisonersRiddle
{
    public interface IPrison
    {
        void FillPrisoners();
        IPisoner GetPrisoner(int prisonerId);
    }
}