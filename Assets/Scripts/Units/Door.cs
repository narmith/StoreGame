using UnityEngine;

public class Door : MonoBehaviour
{
    public bool state = false;
    MeshRenderer _mesh;
    Collider _coll;

    void Start()
    {
        _mesh = this.GetComponent<MeshRenderer>();
        _coll = this.GetComponent<Collider>();
    }

    void LateUpdate()
    {
        _mesh.enabled = state;
        _coll.enabled = state;
    }
}
