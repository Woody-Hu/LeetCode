namespace LeetCode;

public class determine_if_two_events_have_conflict
{
    public bool HaveConflict(string[] event1, string[] event2)
    {
        return !(event1[1].CompareTo(event2[0]) < 0 || event2[1].CompareTo(event1[0]) < 0);

    }
}