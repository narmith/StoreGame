using UnityEngine;

public class Toilet : MonoBehaviour
{
    public bool doorIsClosed = false;
    Door _door;
    //int cleanIndex = 10; //0 to 10. 10 is clean.
    public bool menAllowed = false;
    public bool staffOnly = false;
    public bool isBroken = false;
    public bool hasPaper = true;

    void Start()
    {
        _door = GetComponentInChildren<Door>();
    }

    void FixedUpdate()
    {
        
    }
}
