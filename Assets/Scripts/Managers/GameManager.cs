using UnityEngine;

public class GameManager : MonoBehaviour
{
    // References
    public static GameManager instance;

    int _targetFPS = 60;

    public int employees = 1;
    public int timeOfDay = 1; //1-morning 2-noon 3-afternoon 4-evening 5-night 6-midnight
    public int weekDay = 1; //1to7, 1 is monday
    public int currentWeek = 1;
    public int currentMonth = 1;
    static public int money = 100;

    private void Awake()
    {
        if (GameManager.instance != null)
        {
            Destroy(this);
            return;
        }

        PlayerPrefs.DeleteAll();
        instance = this;
        DontDestroyOnLoad(this.gameObject);
    }

    void Start()
    {
        Application.targetFrameRate = _targetFPS; // the framerate of the game.
    }

    // Floating text
    public void ShowText(string msg, int fontSize, Color color, Vector3 position, Vector3 motion, float duration)
    {
        SayManager.instance.Show(msg, fontSize, color, position, motion, duration);
    }

    static public void Money(int value) { money += value; }
    public string Money() { return money.ToString(); }
    public string Popularity() { return TableManager.Popularity().ToString(); }
    public string Customers() { return TableManager.GetQtyCustomers().ToString(); }
    public string Tables() { return TableManager.Tables().ToString(); }
}
