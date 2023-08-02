using UnityEngine;

public class Say : MonoBehaviour
{
    public string whatToSay;
    MainManager mManager;

    private void Start()
    {
        mManager = MainManager.instance;
    }

    public void SaySomething()
    {
        mManager.ShowText(
            whatToSay,
            25, Color.yellow,
            transform.position,
            Vector3.up * 25,
            1.5f);
    }

    public void SayThis(string words)
    {
        mManager.ShowText(
            words,
            25, Color.yellow,
            transform.position,
            Vector3.up * 25,
            1.5f);
    }
}