using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshController : MonoBehaviour
{

    Transform target;
    NavMeshAgent agent;

    public Transform[] destinationPoints;
    int destinationIndex = 0;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("target 1").transform;
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(transform.position, target.position) <5)
        {
            
            agent.destination = target.position;
            Debug.Log("Detras de ti imbesil");
             if(Vector3.Distance(transform.position, target.position) <1)
             {
                 Debug.Log("Te voy a matarrrrrrrrr");
             }else{Debug.Log("Puedes corer pero no puedes escondir");}

        }else{
        
            //la IA va a los puntos de patrulla
        agent.destination = destinationPoints[destinationIndex].position;

        if(Vector3.Distance(transform.position, destinationPoints[destinationIndex].position) <0.5f)
        {
            if(destinationIndex < destinationPoints.Length -1)
            {
                //aumenta en 1 el index
                destinationIndex++;
            }else//si llegamos al maximo de puntos en el array nos devuelve el index al valor 0    
                {
                    destinationIndex = 0;
                }
        }
        }
    }
}
