using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public Transform player;
    public float attackDistance = 1f;
    public float moveSpeed = 2f;
    public float followDistance = 5f; // Distancia a la que el enemigo comenzará a seguir al jugador

    private Animator animator;
    private bool isAttacking = false;
    [SerializeField] float attackTime = 1;
    float currentAttackTime = 0;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (isAttacking)
        {
            currentAttackTime += Time.deltaTime;
            if (currentAttackTime > attackTime)
            {
                isAttacking = false;
            }
            return;
        }

        float distanceToPlayer = Vector2.Distance(transform.position, player.position);

        if (distanceToPlayer <= attackDistance)
        {
            animator.SetBool("IsAttack", true);
            currentAttackTime = 0;
            isAttacking = true;
        }
        else if (distanceToPlayer <= followDistance) // Verificar si el jugador está dentro de la distancia de seguimiento
        {
            animator.SetBool("IsWalk", true);
            transform.position = Vector3.MoveTowards(transform.position, player.position, moveSpeed * Time.deltaTime);

            if (player.position.x < transform.position.x)
                transform.localScale = new Vector3(Mathf.Abs(transform.localScale.x) * -1, transform.localScale.y, transform.localScale.z);
            else
                transform.localScale = new Vector3(Mathf.Abs(transform.localScale.x), transform.localScale.y, transform.localScale.z);
        }
        else
        {
            animator.SetBool("IsWalk", false);
        }
    }

    public void TakeDamage()
    {
        animator.SetBool("IsHurt", true);
    }
}
