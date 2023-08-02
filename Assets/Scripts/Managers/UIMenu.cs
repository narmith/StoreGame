using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIMenu : MonoBehaviour
{
    public static UIMenu instance;
    MainManager mManager;

    public Text _storeName;
    public Text fpsText;
    public Text clients;
    public Text currentDay;
    public Text popularity;
    public Text money;
    public Text _info;
    float _infoTimer;
    float deltaTime;
    float fps;

    void Start()
    {
        if (UIMenu.instance != null)
        {
            Destroy(this);
            return;
        }
        instance = this;
        DontDestroyOnLoad(this.gameObject);

        mManager = MainManager.instance;

        _storeName = GetComponent<Text>();
        deltaTime = 0f;
        fps = 1.0f;

    }

    void Update()
    {
        deltaTime += (Time.deltaTime - deltaTime) * 0.1f;
        fps = 1.0f / deltaTime;
    }

    private void FixedUpdate()
    {
        if(_infoTimer<=0) { _info.gameObject.SetActive(false); }
        else _infoTimer -= 1 * Time.deltaTime;

        fpsText.text = "FPS: " + Mathf.Ceil(fps).ToString();
        clients.text = mManager.Customers() + " - " + mManager.Tables() + " tables";
        popularity.text = mManager.Popularity();
        //money.text = mManager.Money();
    }

    public void SpawnCustomer(int _tableId)
    {
        if(_tableId==0) { _tableId=((int)Random.Range(0f, 6f)); }
        LoungeManager.SpawnCustomerAtTable(_tableId);
    }

    public void ShowInfo(string _text)
    {
        if (!_info.gameObject.activeSelf) { _info.gameObject.SetActive(true); }
        _info.text = _text;
        _infoTimer = 2f;
    }


    public void NewGame()
    {
        SceneManager.LoadScene(1);
    }
    public void LoadGame()
    {
        SceneManager.LoadScene(1);
        // + load state from HDD
    }
    public void SaveGame()
    {
        //if(SceneManager == 1)
        // then Save state to HDD
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}

public class MainMenu : MonoBehaviour
{
    public bool GodMode = false;

    public void Start()
    {
        Cursor.lockState = CursorLockMode.None;
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("Nivel1");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void LoadLevel(string menu)
    {
        SceneManager.LoadScene(menu);
    }

    public void GodModeOption()
    {
        if (!GodMode) //enables the option
        {
            GodMode = true;
        }
        else if (GodMode) //disables the option
        {
            GodMode = false;
        }
    }



    public void LoungeMenu()
    {
        int cleanIndex = 0;
    }
    public void KitchenMenu()
    {
        int cleanIndex = 0;
    }
    public void StoreroomMenu()
    {
        int cleanIndex = 0;
    }
    public void BathroomMenu()
    {
        int cleanIndex = 0;
    }
    public void EmployeeMenu()
    {

    }
    public void BusinessMenu()
    {

    }
    public void Main()
    {

    }
}