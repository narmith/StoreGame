using UnityEngine;

public class GivesInfo : MonoBehaviour
{
    public string _info;

    public void SetInformation(string _new) {_info = _new; }
    public string StoredInformation() { return _info; }

    public void DoAction()
    {
        if(TryGetComponent<CookingStation>(out CookingStation cookingStation))
        {
            cookingStation.StationOnOff();
        }
    }
}