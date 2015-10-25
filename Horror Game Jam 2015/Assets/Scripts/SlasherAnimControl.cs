using UnityEngine;
using System.Collections;

public class SlasherAnimControl : MonoBehaviour {

    private Rigidbody body;
    private Animator anim;

	// Use this for initialization
	void Start () {
        body = GetComponent<Rigidbody>();
        anim = GetComponentInChildren<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        float horizontal = body.velocity.x;
        float vertical = body.velocity.y;

        anim.SetFloat("horizontalInput", horizontal);
        anim.SetFloat("verticalInput", vertical);
    }
}
