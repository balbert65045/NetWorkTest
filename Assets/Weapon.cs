using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {

    // Use this for initialization
    bool AttackStateEnabled = false;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SetAttackState(bool value)
    {
        AttackStateEnabled = value;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (AttackStateEnabled)
        {
            if (other.GetComponentInChildren<Weapon>() != this)
            {
                Debug.Log("Triggered with " + other.name);
            }
        }
    }
}
