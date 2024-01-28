using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Controller : MonoBehaviour
{
    public Transform[] TargetList;
    public NavMeshAgent NavMeshAgent;

    private int TargetInd;

    private Transform CurrentTarget { get { return TargetList[TargetInd]; } }

    // Start is called before the first frame update
    void Start()
    {
        TargetInd = SelectTarget();
    }

    // Update is called once per frame
    void Update()
    {
        NavMeshAgent.destination = CurrentTarget.position;
        if(NavMeshAgent.remainingDistance < 0.5f)
        {
            TargetInd = SelectTarget();
        }
        
    }

    private int SelectTarget()
    {
        return Random.Range(0, TargetList.Length);
    }
}
