using UnityEngine;

public class Movement : MonoBehaviour
{
    // Setting player ship objects
    public Transform PlayerShip;
    public Rigidbody r;
    // Player ship speed
    public float turnSpeed = 60f;
    public float forwardSpeed = 45f;
    public float boostSpeed = 70f;
    public Vector2 turn;
    public Vector3 deltaMove;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        // Locks the cursor into the middle of the screen
        Cursor.lockState = CursorLockMode.Locked;
        // Assigns rigidbody to the variable "r"
        r = GetComponent<Rigidbody>();
        // Turns off the rigidbody gravity for the player ship
        r.useGravity = false;
    }
    // Update is called once per physics frame
    void FixedUpdate()
    {
        // Calls the thrust and turn functions

        Turn();
        Thrust();
    }

    //Controls the turning of the player ship
    void Turn(){
        // Creates the variable roll based on the turn speed timesed by the turn speed, then timesed by the input key set to "Rotate"
        float roll = turnSpeed * Time.deltaTime*Input.GetAxis("Rotate");
        // Sets the user mouse movement from both axis to variables
        turn.x += Input.GetAxis("Mouse X") * turnSpeed * Time.deltaTime;
        turn.y -= Input.GetAxis("Mouse Y") * turnSpeed * Time.deltaTime;
        // Clamps the players Y movement so that they cant go upside down and invert the controls
        turn.y = Mathf.Clamp(turn.y, -90f, 90f);
        // Moves the player ship based on the variables set above
        Quaternion targetRotation = Quaternion.Euler(turn.y, turn.x, roll);
        //moves the rigidbody based on the above variable
        r.MoveRotation(targetRotation);
    }

    //Controls the forward/backward of the player ship
    void Thrust(){
        // Controls the player ships forward movement based on the variable set for speed and the input button for the throttle
        PlayerShip.position += PlayerShip.forward*forwardSpeed*Time.deltaTime*Input.GetAxis("Throttle");
        PlayerShip.position += PlayerShip.forward*boostSpeed*Time.deltaTime*Input.GetAxis("Boost");
    }
}
// Jamie