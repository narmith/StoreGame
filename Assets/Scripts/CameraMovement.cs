using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    Transform playerPos;

    private void Start()
    {
        playerPos = GameObject.Find("Player").transform;
    }

    void FixedUpdate()
    {
        transform.LookAt(playerPos);

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                if (hit.collider.gameObject.TryGetComponent(out GivesInfo info))
                {
                    info.Information();
                }
            }
        }

        if (Input.GetMouseButtonDown(1))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                if (hit.collider.gameObject.TryGetComponent(out GivesInfo info))
                {
                    info.Action();
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
                    say.SaySomething();
                }
            }
        }
    }
}
