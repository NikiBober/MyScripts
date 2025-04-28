using System;

/// <summary>
/// Crosspoint for events.
/// </summary>
public static class EventManager
{
    //public static event Action<GameObject> OnIncreaseStack;
    public static event Action OnTimerEnd;
    public static event Action OnVictory;

    public static void TimerEnd() => OnTimerEnd?.Invoke();
    public static void Victory() => OnVictory?.Invoke();

    //public static void IncreaseStack(GameObject cube)
    //{
    //    OnIncreaseStack?.Invoke(cube);
    //}

}
