using UnityEngine;
using System.Collections;

public class CollideWithPlayer : MonoBehaviour {



    void Start()
    {

    }

    void Update()
    {
        
    }

    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        float force = 10;
        Rigidbody body = hit.collider.attachedRigidbody;
        if (body == null || body.isKinematic) return;
        if (hit.moveDirection.y < -0.3f) return;
        Vector3 pushDir = new Vector3(hit.moveDirection.x, 0, hit.moveDirection.z);
        body.velocity = pushDir * force;

    }
}
