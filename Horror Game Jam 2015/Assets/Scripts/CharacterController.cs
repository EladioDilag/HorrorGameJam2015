using UnityEngine;
using System.Collections;

public class CharacterController : MonoBehaviour {

    public float walkSpeed;
    public float sprintSpeed;

    private float currentSpeed;
    private Rigidbody2D body;

    void Start() {
        body = GetComponent<Rigidbody2D>();
        currentSpeed = walkSpeed;
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


        body.velocity = new Vector2(Mathf.Lerp(0, (horizontal * currentSpeed), 1), 
                                    Mathf.Lerp(0, (vertical * currentSpeed), 1));
    }
}
