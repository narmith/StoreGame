using UnityEngine;

public class Table : MonoBehaviour
{
    //private Menu menu;
    GivesInfo _etc;
    public GameObject _dummyNPC1;
    public GameObject _dummyNPC2;
    public GameObject _dummyNPC3;
    public GameObject _dummyNPC4;

    int _clientsQty = 0;
    public int _id = -1;
    //int _maxChairs = 4;
    //int _availableChairs = 4;
    //bool _clientSatisfaction = false;
    //bool _receiptAsked = false;
    //bool _takeOut = false;
    //int _menueElection = 0;
    
    void Start()
    {
        _etc = GetComponent<GivesInfo>();
        if (!_dummyNPC1) { Debug.Log("Table has no Dummy1 defined."); }
        if (!_dummyNPC2) { Debug.Log("Table has no Dummy2 defined."); }
        if (!_dummyNPC3) { Debug.Log("Table has no Dummy3 defined."); }
        if (!_dummyNPC4) { Debug.Log("Table has no Dummy4 defined."); }
        _id = LoungeManager.AddTable(this);
        SitNPCs();
    }

    void SitNPCs()
    {
        _dummyNPC1.gameObject.SetActive((_clientsQty > 0));
        _dummyNPC2.gameObject.SetActive((_clientsQty > 1));
        _dummyNPC3.gameObject.SetActive((_clientsQty > 2));
        _dummyNPC4.gameObject.SetActive((_clientsQty > 3));
    }
    void ResetTable()
    {
        if (_clientsQty >= 1) { LoungeManager.Customers(-_clientsQty); }
        _clientsQty = ((int)Random.Range(0f, 4f));
        if (_clientsQty >= 1) { LoungeManager.Customers(_clientsQty); }

        SitNPCs();
    }
    void ClientAskReceipt() { MainManager.Money(10 * _clientsQty); LoungeManager.Popularity(1 * _clientsQty); }
    public int ClientsQty() { return _clientsQty; }

    //Player actions
    public void Information() { Debug.Log("Table with " + _clientsQty + " clients."); }
    public void Action() { ResetTable(); }
    public void Special() { ClientAskReceipt(); ResetTable(); }
}
