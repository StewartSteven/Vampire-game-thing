using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VericalPlatformer : MonoBehaviour
{
public class MovingDoor : MonoBehaviour
    {

        public Transform barrier;

        public Transform startTransform;

        public Transform endTransform;

        public float barrierSpeed;

        Vector3 direction;
        Transform destination;

        void Start()
        {
            SetDestination(startTransform);
        }

        void FixedUpdate()
        {
            barrier.GetComponent<Rigidbody>().MovePosition(barrier.position + direction * barrierSpeed * Time.fixedDeltaTime);

            if (Vector3.Distance(barrier.position, destination.position) < barrierSpeed * Time.fixedDeltaTime)
            {
                SetDestination(destination == startTransform ? endTransform : startTransform);
            }
        }

        void OnDrawGizmos()
        {
            Gizmos.color = Color.green;
            Gizmos.DrawWireCube(startTransform.position, barrier.localScale);

            Gizmos.color = Color.red;
            Gizmos.DrawWireCube(endTransform.position, barrier.localScale);
        }

        void SetDestination(Transform dest)
        {
            destination = dest;
            direction = (destination.position - barrier.position).normalized;
        }
    }
}
