using UnityEngine;

public class Movement : MonoBehaviour
{
    public Transform PlayerShip;
    public Rigidbody r;
    //player ship speed
    public float turnSpeed = 60f;
    public float forwardSpeed = 45f;
    public Vector2 turn;
    public Vector3 deltaMove;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        r = GetComponent<Rigidbody>();
        r.useGravity = false;
    }
    // Update is called once per physics frame
    void FixedUpdate()
    {
        Turn1();
        Thrust();
    }

    //Controls the turning of the player ship
    void Turn1(){
        float roll = turnSpeed * Time.deltaTime*Input.GetAxis("Rotate");
        turn.x += Input.GetAxis("Mouse X") * turnSpeed * Time.deltaTime;
        turn.y -= Input.GetAxis("Mouse Y") * turnSpeed * Time.deltaTime;
        Quaternion targetRotation = Quaternion.Euler(turn.y, turn.x, roll);
        r.MoveRotation(targetRotation);
    }

    //Controls the forward/backward of the player ship
    void Thrust(){
        PlayerShip.position += PlayerShip.forward*forwardSpeed*Time.deltaTime*Input.GetAxis("Throttle");
    }
}
