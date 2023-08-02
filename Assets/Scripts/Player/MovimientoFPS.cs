using UnityEngine;

public class MovimientoFPS : MonoBehaviour
{
    private float movSpeed = 2.5f;
    private float gravity = -10f;
    CharacterController PlayerCC;
    private Vector3 move;
    private Vector3 rotate;

    void Start()
    {
        //Cursor.lockState = CursorLockMode.Locked;
        PlayerCC = GetComponent<CharacterController>();
    }

    void FixedUpdate()
    {
        move = Input.GetAxis("Vertical") * movSpeed * transform.forward;
        rotate = (Input.GetAxis("Horizontal") * 200) * transform.up;

        if (!PlayerCC.isGrounded) { PlayerCC.Move(gravity * Time.deltaTime * transform.up); }   //gravity check
        PlayerCC.Move(Time.deltaTime * move);                                                   //movement
        PlayerCC.transform.Rotate(Time.deltaTime * rotate);                                     //rotation
    }
}
