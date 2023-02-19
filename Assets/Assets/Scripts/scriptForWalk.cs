using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class scriptForWalk : MonoBehaviour
{


    public Transform Tujuan1;
   NavMeshAgent Player;
    // Start is called before the first frame update
    void Start()
    {
        Player = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        Player.SetDestination(Tujuan1.position);
    }
}
