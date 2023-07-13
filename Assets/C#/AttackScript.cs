using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackScript : MonoBehaviour
{
    Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            animator.SetBool("IsAttack", true);
        }
        if (Input.GetMouseButtonDown(1))
        {
            animator.SetBool("IsAttack3", true);
        }
    }
}
