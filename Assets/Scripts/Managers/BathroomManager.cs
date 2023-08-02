using UnityEngine;

public class BathroomManager : MonoBehaviour
{
    public GameObject toiletBoot1;
    public GameObject toiletBoot2;
    public GameObject toiletBoot3;
    public GameObject toiletBoot4;

    public GameObject toiletBoot5;
    public GameObject toiletBoot6;
    public GameObject toiletBoot7;
    public GameObject toiletBoot8;

    bool toiletBootOcuppied(GameObject toilet)
    {
        //TODO check if this boot is currently occupied and return the sate
        bool _status = false;
        return _status;
    }

    bool allMenToiletsOccupied()
    {
        //TODO use toiletBootOcuppied() from 1 to 4 and return if true or false
        bool _status = false;
        return _status;
    }

    bool allWomenToiletsOccupied()
    {
        //TODO use toiletBootOcuppied() from 5 to 8 and return if true or false
        bool _status = false;
        return _status;
    }
}
