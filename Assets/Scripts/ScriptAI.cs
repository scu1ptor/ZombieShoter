using UnityEngine;
using UnityEngine.AI;
public class ScriptAI : MonoBehaviour
{
    private NavMeshAgent AI_Agent;
    private GameObject Player;
    void Start()
    {
        AI_Agent = gameObject.GetComponent<NavMeshAgent>();
        Player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
       AI_Agent.SetDestination(Player.transform.position); 
    }
}
