using System.Collections.Generic;

namespace HundredPrisonersRiddle
{
    public interface IPisoner
    {
        int PrisonerId { get; set; }
        bool FoundMyBox { set; }
        List<int> VisitedBoxes { get; set; }

        IBox FindYourBox(IRoom room, int allowedNoOfBoxes);
    }
}