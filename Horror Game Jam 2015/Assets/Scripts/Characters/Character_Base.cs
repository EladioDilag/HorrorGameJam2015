using UnityEngine;
using System.Collections;

public class Character_Base : MonoBehaviour {

    public int bravery { get; set; }
    public int ldrship { get; set; }
    public int mov_Spd { get; set; }
    public int survive { get; set; }

    public bool isActivePlayer { get; set; }

    public float sprintTimer { get; set; }

	// Use this for initialization
	void Awake () {
        bravery = 1;
        ldrship = 1;
        mov_Spd = 1;
        survive = 1;

        isActivePlayer = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
