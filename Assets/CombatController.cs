using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatController : MonoBehaviour {

    // Use this for initialization
    Animator m_Animator;

	void Start () {
        m_Animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("MeleeAttack1"))
        {
            m_Animator.SetTrigger("MeleeAttack1");
        }
	}

    public void EnableAttack()
    {
        GetComponentInChildren<Weapon>().SetAttackState(true);
    }

    public void DisableAttack()
    {
        GetComponentInChildren<Weapon>().SetAttackState(false);
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, .7f);
    }
}
