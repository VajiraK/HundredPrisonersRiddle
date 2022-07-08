namespace HundredPrisonersRiddle
{
    public delegate void Visited();  // delegate
    public interface IBox
    {
        event Visited BoxVisited;
        int Inside { get; set; }
        int Outside { get; set; }
        void Print();
        void InvokeBoxVisited();
    }
}