using UnityEngine;
using System.Collections;

public class CharacterController : MonoBehaviour {

    public float walkSpeed;
    public float sprintSpeed;
    public float sprintDuration = 1000;
    public float staminaGain = 1;
    public float staminaLoss = 2;
    public float minimumStamina = 50;

    private float currentSpeed;
    private Rigidbody2D body;
    private bool sprintReady;
    private bool playerIsSprinting;
    private float lastSprintUsed;
    private float sprintStamina;

    void Start() {
        body = GetComponent<Rigidbody2D>();
        currentSpeed = walkSpeed;
        lastSprintUsed = Time.deltaTime;
    }

	// Update is called once per frame
	void Update () {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // Switch between sprinting and walking speeds
        if (Input.GetKey (KeyCode.LeftShift) && sprintStamina >= 0)
        {
            playerIsSprinting = true;
            currentSpeed = sprintSpeed;
        }
        else
        {
            currentSpeed = walkSpeed;
            playerIsSprinting = false;
        }

        // When shit hits the fan
        if (playerIsSprinting)
        {
            sprintStamina -= staminaLoss; 
        }
        else if (sprintStamina < sprintDuration && Input.GetKey(KeyCode.LeftShift) == false)
        {
            sprintStamina += staminaGain;
        }
        
        body.velocity = new Vector2(Mathf.Lerp(0, (horizontal), 1),
                                    Mathf.Lerp(0, (vertical), 1)).normalized * currentSpeed;
    }
}
