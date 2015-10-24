using UnityEngine;
using System.Collections;

public class Item_Base : MonoBehaviour {

    public    int num_Uses  { get; set; }

    protected int num_Slots { get; set; }
    
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    // Use is called when an object is used
    protected void Use () {
        if (num_Uses > 0)
            num_Uses--;
    }
}
