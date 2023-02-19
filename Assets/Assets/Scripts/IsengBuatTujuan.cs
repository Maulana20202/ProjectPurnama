using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class IsengBuatTujuan : MonoBehaviour
{

    private NavMeshAgent Agent;
    public Transform Tujuan;
    // Start is called before the first frame update
    void Awake()
    {
       
     }
    
    void Start()
    {
        Agent = GetComponent<NavMeshAgent>();
        Agent.updateRotation = false;
        Agent.updateUpAxis = false; 
    }

    // Update is called once per frame
    void Update()
    {
        Agent.SetDestination(Tujuan.position);
    }
}
