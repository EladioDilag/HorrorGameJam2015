using UnityEngine;
using System.Collections;

public class Character_Geek : Character_Base {

	// Use this for initialization
	void Awake () {
        bravery = 1;
        ldrship = 1;
        mov_Spd = 6;
        survive = 2;

        sprintTimer = 2.0f;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
