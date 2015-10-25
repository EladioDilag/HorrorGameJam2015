using UnityEngine;
using System.Collections;

public class Character_Rogue : Character_Base {

	// Use this for initialization
	void Awake () {
        bravery = 4;
        ldrship = 2;
        mov_Spd = 7;
        survive = 8;

        sprintTimer = 3.0f;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
