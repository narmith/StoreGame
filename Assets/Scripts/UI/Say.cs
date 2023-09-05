using UnityEngine;

public class Say : MonoBehaviour
{
    public string whatToSay;

    public void SayAnything()
    {
        GameManager.instance.ShowText(
            whatToSay,
            25, Color.yellow,
            transform.position,
            Vector3.up * 25,
            1.5f);
    }

    public void SayThis(string _whatToSay)
    {
        GameManager.instance.ShowText(
            _whatToSay,
            25, Color.yellow,
            transform.position,
            Vector3.up * 25,
            1.5f);
    }
}