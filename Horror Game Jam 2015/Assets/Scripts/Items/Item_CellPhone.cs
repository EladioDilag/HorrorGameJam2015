using UnityEngine;
using System.Collections;

public class Item_CellPhone : Item_Base {

    public float light_Radius { get; set; }

	// Use this for initialization
	void Start () {
        num_Slots =  1;
        num_Uses  = -1;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    // Use is called when an object is used
    new void Use () {
        
    }
}
