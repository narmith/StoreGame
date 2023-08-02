using System.Collections.Generic;
using UnityEngine;

public class LoungeManager : MonoBehaviour
{
    static List<Table> _tables = new();
    static int _totalClients;
    static int _popularity;

    void Start()
    {
        _popularity = 0;
        _totalClients = 0;
    }

    static public int AddTable(Table _newTable)
    {
        _tables.Add(_newTable);
        return _tables.Count;
    }
    static public void RemoveTable(int _tableId)
    {
        _tables.Remove(_tables[_tableId]);
    }

    static public void SpawnCustomerAtTable(int _id)
    {
        _tables[_id].Action();
    }

    static public void Popularity(int _num) { _popularity += _num; }
    static public int Popularity() { return _popularity; }
    static public void Customers(int _num) { _totalClients += _num; }
    static public int GetQtyCustomers() { return _totalClients; }
    static public int Tables() { return _tables.Count; }
}
