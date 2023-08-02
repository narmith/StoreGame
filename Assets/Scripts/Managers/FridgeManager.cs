using UnityEngine;

public class FridgeManager : MonoBehaviour
{
    public bool doorIsClosed = true;
    public SingleDoor _door;
    //int cleanIndex = 10; //0 to 10. 10 is clean.
    public bool isBroken = false;
    public bool isPowered = true;
    public int _temp = -5;
    public bool isCold = true;

    void Start()
    {
        _door = GetComponentInChildren<SingleDoor>();
    }

    void Update()
    {
        _door.state = doorIsClosed;
    }
}
