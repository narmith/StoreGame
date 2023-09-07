using UnityEngine;

public class CameraView : MonoBehaviour
{
    void FixedUpdate()
    {
        if (Input.GetMouseButtonDown(0))
        {
            
        }

        if (Input.GetMouseButtonDown(1))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                if (hit.collider.gameObject.TryGetComponent(out GivesInfo isInfoGiver))
                {
                    isInfoGiver.DoAction();
                }
                else if (hit.collider.gameObject.TryGetComponent(out Toilet isToilet))
                {
                    isToilet.OpenCloseDoor();
                }
            }
        }

        if (Input.GetMouseButtonDown(2))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                if (hit.collider.gameObject.TryGetComponent(out Say say))
                {
                    say.SayAnything();
                }
                else if (hit.collider.gameObject.TryGetComponent(out GivesInfo info))
                {
                    Debug.Log(info.StoredInformation());
                }
            }
        }
    }
}
