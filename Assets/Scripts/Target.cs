using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.AI;

public class Target : MonoBehaviour
{
    public float health = 10f;
     public GameObject body;
    public Animator animator;
    public NavMeshAgent agent;
    public void TakeDamage(float amount)
    {
        health -= amount;
        if(health < 0f)
        {
            Die();
        }
    }
    void Die()
    {
       animator.SetBool("dead", true);
        agent.speed = 0;
        Invoke("DieDestroy",5);
       
    }
    void DieDestroy()
    {
        Destroy(gameObject);
        Destroy(body);
    }

}
