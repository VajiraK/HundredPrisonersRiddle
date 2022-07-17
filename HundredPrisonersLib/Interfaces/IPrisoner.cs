using System.Collections.Generic;

namespace HundredPrisonersRiddle
{
    public interface IPrisoner
    {
        int PrisonerId { get; set; }
        int BoxQuota { get; set; }
        bool FoundMyBox { set; }
        List<int> VisitedBoxes { get; set; }
        IBox FindYourBox(IRoom room);
    }
}