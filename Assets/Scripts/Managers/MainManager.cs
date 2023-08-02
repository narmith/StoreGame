using UnityEngine;

public class MainManager : MonoBehaviour
{
    // References
    public static MainManager instance;
    FloatingTextManager floatingTextManager;

    int _targetFPS = 61;

    public int employees = 1;
    public int timeOfDay = 1; //1-morning 2-noon 3-afternoon 4-evening 5-night 6-midnight
    public int weekDay = 1; //1to7, 1 is monday
    public int currentWeek = 1;
    public int currentMonth = 1;
    static public int money = 100;

    private void Awake()
    {
        if (MainManager.instance != null)
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
        floatingTextManager = GetComponent<FloatingTextManager>();
    }

    // Floating text
    public void ShowText(string msg, int fontSize, Color color, Vector3 position, Vector3 motion, float duration)
    {
        floatingTextManager.Show(msg, fontSize, color, position, motion, duration);
    }

    static public void Money(int value) { money += value; }
    public string Money() { return money.ToString(); }
    public string Popularity() { return LoungeManager.Popularity().ToString(); }
    public string Customers() { return LoungeManager.GetQtyCustomers().ToString(); }
    public string Tables() { return LoungeManager.Tables().ToString(); }
}
