using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace Slime
{
    public class EnemyAttack : MonoBehaviour
    {
        public NavMeshAgent agent;
        public Transform player;
        public LayerMask whatisground, whatisplayer;

        //patrolling
        public Vector3 walkpoint;
        bool walkpointset;
        public float walkpointrange;

        //in range
        public float sightrange, attackrange;
        public bool playerinsight,playerinattackrange;

        private void Awake()
        {
            player = GameObject.Find("player").transform;
            agent = GetComponent<NavMeshAgent>();

        }
        private void Start()
        {
            FindObjectOfType<AudioManager>().Play("theme");
        }

        private void Update()
        {
            playerinsight = Physics.CheckSphere(transform.position, sightrange, whatisplayer);
            playerinattackrange = Physics.CheckSphere(transform.position, attackrange, whatisplayer);
            
            if(!playerinsight && !playerinattackrange)
            {
                Patrolling();
            }
            if(playerinsight&&!playerinattackrange)
                    {
                Chase();
            }
            if(playerinattackrange&&playerinsight)
            {
                Attack();
            }

        }

        private void Patrolling()
        {
            if (!walkpointset) SearchWalkPoint();
            if(walkpointset)
                {
                agent.SetDestination(walkpoint);

                Vector3 distancetothewalkpoint = transform.position - walkpoint;
                if(distancetothewalkpoint.magnitude<1f)
                {
                    walkpointset = false;
                }
            }
        }
        void SearchWalkPoint()
        {
            float randomZ = Random.Range(-walkpointrange, walkpointrange);
            float randomX = Random.Range(-walkpointrange, walkpointrange);
            walkpoint = new Vector3(transform.position.x + randomX, transform.position.y, transform.position.z + randomZ);
            if(Physics.Raycast(walkpoint,-transform.up,2f,whatisground))
            {
                walkpointset = true;
            }
        }
        private void Chase()
        {
            agent.SetDestination(player.position);
        }
        private void Attack()
        {
            
        }
        private void OnDrawGizmosSelected()
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(transform.position, attackrange);
            Gizmos.color = Color.green;
            Gizmos.DrawWireSphere(transform.position, sightrange); 
        }


    }
}
