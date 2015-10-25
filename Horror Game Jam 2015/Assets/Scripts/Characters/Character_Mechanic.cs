using UnityEngine;
using System.Collections;

public class Character_Mechanic : Character_Base {

	// Use this for initialization
	void Awake () {
        bravery = 7;
        ldrship = 2;
        mov_Spd = 4;
        survive = 6;

        sprintTimer = 1.0f;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
