using UnityEngine;

public class Toilet : MonoBehaviour
{

    public bool doorIsClosed = false;
    SingleDoor _door;
    //int cleanIndex = 10; //0 to 10. 10 is clean.
    public bool menAllowed = false;
    public bool staffOnly = false;
    public bool isBroken = false;
    public bool hasPaper = true;

    void Start()
    {
        _door = GetComponentInChildren<SingleDoor>();
    }

    void Update()
    {
        _door.state = doorIsClosed;
    }

    public void OpenCloseDoor()
    {
        doorIsClosed = !doorIsClosed;
        //TODO: Add sound effect.
    }
}
