using UnityEngine;
public delegate void Notify();
public delegate void NotifyFloat(float value);
public delegate void NotifyBool(bool value);
public delegate void NotifyInt(int value);
public delegate void NotifyTupla(int value, int value2);
public delegate void NotifyString(string value);
public class EventManager
{
    public event Notify OnPauseGame;
    public event Notify OnResumeGame;

    private static EventManager _instance;
    public static EventManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new EventManager();
            }
            return _instance;
        }
    }


    public void EventPauseGame()
    {
        OnPauseGame?.Invoke();
    }

    public void EventResumeGame()
    {
        OnResumeGame?.Invoke();
    }
}
