using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class Tima : MonoBehaviour
{
    public Transform target;
    float distance;
    public NavMeshAgent myAgent;
    public Animator anim;

  
    void Start()
    {
        
    }

  
    void FixedUpdate()
    {

     
        distance = Vector3.Distance(transform.position, target.transform.position);
        if (distance > 18f)
          
        {
            myAgent.enabled = true;
            myAgent.SetDestination(target.position);
            anim.SetBool("idle",false);
            anim.SetBool("run", true);
        }
        if (distance <= 18f)
        {
    
            myAgent.enabled = false;
           
    anim.SetBool("idle", true);
            anim.SetBool("run", false);
           

        }
    }
   

   
    }


