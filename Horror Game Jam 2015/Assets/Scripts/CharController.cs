using UnityEngine;
using System.Collections;

public class CharController : MonoBehaviour {

    public int walkSpeed;
    public int sprintSpeed;

    private int currentSpeed;

    private float sprintCntDwn;
    private float cooldownDelay;
    public Rigidbody2D body;
    public Character_Base charStats;

    private Animator anim;

    void Awake() {
        body = GetComponentInParent<Rigidbody2D>();
        charStats = GetComponentInParent<Character_Base>();
        anim = GetComponent<Animator>();
    }

    void Start()
    {
        walkSpeed = charStats.mov_Spd;
        sprintSpeed = walkSpeed * 2;

        sprintCntDwn = charStats.sprintTimer;

        currentSpeed = walkSpeed;

        cooldownDelay = 0.0f;
    }

	// Update is called once per frame
	void Update () {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        anim.SetFloat("horizontalInput", horizontal);
        anim.SetFloat("verticalInput", vertical);

        // Switch between sprinting and walking speeds
        if (Input.GetKey (KeyCode.LeftShift) && sprintCntDwn > 0.0f) {
            currentSpeed = sprintSpeed;
            sprintCntDwn -= Time.deltaTime;

            cooldownDelay = 2.0f;
        }
        else {
            currentSpeed = walkSpeed;

            if (cooldownDelay > 0.0f)
                cooldownDelay -= Time.deltaTime;
            if(cooldownDelay <= 0.0f) {
                if (sprintCntDwn < charStats.sprintTimer)
                    sprintCntDwn += Time.deltaTime;
                else
                    sprintCntDwn = charStats.sprintTimer;
            }
        }

        body.velocity = new Vector2(Mathf.Lerp(0, (horizontal), 1),
                                    Mathf.Lerp(0, (vertical), 1)).normalized * currentSpeed;
    }
}
