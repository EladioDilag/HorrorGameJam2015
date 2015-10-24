using UnityEngine;
using System.Collections;

public class Item_SmokeBomb : Item_Base {
    
	// Use this for initialization
	void Start () {
        stun_Dur  = 5.0f;
        num_Slots = 1;
        num_Uses  = 1;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    new void Use () {
        base.Use();
    }
}
