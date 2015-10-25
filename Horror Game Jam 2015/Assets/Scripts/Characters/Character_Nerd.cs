using UnityEngine;
using System.Collections;

public class Character_Nerd : Character_Base {

	// Use this for initialization
	void Awake () {
        bravery = 5;
        ldrship = 5;
        mov_Spd = 4;
        survive = 4;

        sprintTimer = 1.0f;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
