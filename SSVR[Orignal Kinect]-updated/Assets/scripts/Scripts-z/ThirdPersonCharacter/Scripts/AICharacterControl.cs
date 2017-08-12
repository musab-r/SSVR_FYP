using System;
using UnityEngine;

namespace UnityStandardAssets.Characters.ThirdPerson
{
    [RequireComponent(typeof (NavMeshAgent))]
    [RequireComponent(typeof (ThirdPersonCharacter))]
    public class AICharacterControl : MonoBehaviour
    {
        public NavMeshAgent agent { get; private set; } // the navmesh agent required for the path finding
        public ThirdPersonCharacter character { get; private set; } // the character we are controlling
        public Transform target;
		//public float distance_test;

        // Use this for initialization
        private void Start()
        {
            // get the components on the object we need ( should not be null due to require component so no need to check )
            agent = GetComponentInChildren<NavMeshAgent>();
            character = GetComponent<ThirdPersonCharacter>();
			//obj = GameObject.Find ("testing_gunner");
	        agent.updateRotation = false;
	        agent.updatePosition = true;
        }


        // Update is called once per frame
        private void Update()
        {
            if (target != null)
            {

				//if (obj.GetComponent<AiContorlar> ().dist > 4) {

					Vector3 pos = target.position;
					//pos.x -= 10;
					//pos.z -= 10;


				if (this.GetComponent<AiContorlar> ().dist < 10) {
						agent.Stop ();
					} else {
						agent.Resume ();
						agent.SetDestination (pos);
					}
					character.Move(agent.desiredVelocity, false, false);

				//} else {
					//agent.updatePosition = false;
					//agent.SetDestination (null);
					//agent.SetDestination(SUpreTarg.position);
					//agent.Stop();
				//}

				
                // use the values to move the character

					


            }
            else
            {
				 

					//agent.SetDestination();
					//character.Move(Vector3.zero, false, false);
				

					
                // We still need to call the character's move function, but we send zeroed input as the move param.
                
            }

        }


        public void SetTarget(Transform target)
        {
            this.target = target;
        }
    }
}
