using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIControl : MonoBehaviour
{
    public UnityEngine.AI.NavMeshAgent agent;
    // Use this for initialization
    void Start()
    {
        agent = this.GetComponent<UnityEngine.AI.NavMeshAgent>();
    }
}