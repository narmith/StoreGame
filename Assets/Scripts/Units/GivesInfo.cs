using UnityEngine;

public class GivesInfo : MonoBehaviour
{
    public string _info;

    public void Information(string _new) {_info = _new; }
    public void Information() { Debug.Log(_info); }

    public void Special() { Debug.Log(this.gameObject.name); }

    public void Action()
    {
        if(TryGetComponent<CookingStation>(out CookingStation cs))
        {
            cs.stationOnOff();
        }
    }
}