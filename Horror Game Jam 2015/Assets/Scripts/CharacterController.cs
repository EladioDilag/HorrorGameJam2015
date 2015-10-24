using UnityEngine;
using System.Collections;

public class CharacterController : MonoBehaviour {
    public float walkSpeed;
    public float sprintSpeed;

    private float currentSpeed;
    private Rigidbody2D body;
    private Light playerLight;
    private float playerX;
    private float playerY;

    void Start() {
        body = GetComponent<Rigidbody2D>();
        playerLight = GetComponent<Light>();
        currentSpeed = walkSpeed;
        //playerX = body.position.x;
        //playerY = body.position.y;
    }

	// Update is called once per frame
	void Update () {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // Switch between sprinting and walking speeds
        if (Input.GetKey (KeyCode.LeftShift))
        {
            currentSpeed = sprintSpeed;
        }
        else
        {
            currentSpeed = walkSpeed;
        }

        if (Input.GetKey(KeyCode.A))
        {
            //playerLight.transform.position = new Vector3(playerLight.transform.position.x-1, playerLight.transform.position.y, playerLight.transform.position.z);
        }
            body.velocity = new Vector2(Mathf.Lerp(0, (horizontal), 1),
                                    Mathf.Lerp(0, (vertical), 1)).normalized * currentSpeed;
    }
}
