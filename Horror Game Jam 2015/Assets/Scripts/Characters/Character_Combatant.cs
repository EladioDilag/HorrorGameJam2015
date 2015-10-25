using UnityEngine;
using System.Collections;

public class Character_Combatant : Character_Base {

	// Use this for initialization
	void Awake () {
        bravery = 8;
        ldrship = 7;
        mov_Spd = 5;
        survive = 7;

        sprintTimer = 2.0f;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
