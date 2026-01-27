using System;

class EventTrackerMain
{
    static void Main()
    {
        UserActions actions = new UserActions();

        EventTrackerUtility.TrackEvents(actions);
    }
}
