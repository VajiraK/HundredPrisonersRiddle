namespace HundredPrisonersRiddle
{
    public interface IBox
    {
        int Inside { get; set; }
        int Outside { get; set; }
        void Print();
    }
}