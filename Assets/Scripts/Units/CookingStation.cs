using UnityEngine;

public class CookingStation : MonoBehaviour
{
    //int cleanIndex = 10; //0 to 10. 10 is clean.
    public bool isBroken = false;
    public bool hasGas = true;
    public bool isCooking = false;

    //Station
    public Light _upperLight1;
    public Light _upperLight2;
    public Light _upperLight3;
    public Light _upperLight4;

    //Oven
    public Light _innerLight;
    public bool doorIsClosed = false;
    Door ovenDoor;

    void Start()
    {
        ovenDoor = GetComponentInChildren<Door>();
        if (!_upperLight1) { Debug.Log(this.gameObject.name + "has no _upperLight1 asociated!"); }
        if (!_upperLight2) { Debug.Log(this.gameObject.name + "has no _upperLight2 asociated!"); }
        if (!_upperLight3) { Debug.Log(this.gameObject.name + "has no _upperLight3 asociated!"); }
        if (!_upperLight4) { Debug.Log(this.gameObject.name + "has no _upperLight4 asociated!"); }
        if (!_innerLight) { Debug.Log(this.gameObject.name + "has no _innerLight asociated!"); }
    }

    void FixedUpdate()
    {
        ovenDoor.state = doorIsClosed;

        if (isBroken == true || hasGas == false)
        { isCooking = false; }
        else if (isCooking)
        { /*TODO: Add sound effect if isCooking == true.*/ }
        
        _upperLight1.enabled = isCooking;
        _upperLight2.enabled = isCooking;
        _upperLight3.enabled = isCooking;
        _upperLight4.enabled = isCooking;
        _innerLight.enabled = isCooking;
    }

    public void stationOnOff()
    {
        isCooking = !isCooking;
    }

    public void ovenOnOff()
    {
        
    }

    public void OpenCloseDoor()
    {
        doorIsClosed = !doorIsClosed;
        //TODO: Add sound effect.
    }
}
