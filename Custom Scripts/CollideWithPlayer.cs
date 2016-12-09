using UnityEngine;
using System.Collections;

public class CollideWithPlayer : MonoBehaviour {

    void OnCollisionEnter(Collision c)
    {
        // The force the object will be pushed
        float force = 100;

        // Check the identity of the object the player has come in contact with
        if (c.gameObject.tag == "ObjectPushed")
        {
            // Find the angle we have contacted the object, based on the collion point and the player
            Vector3 dir = c.contacts[0].point - transform.position;
            // We then get the opposite (-Vector3) and normalize it
            dir = -dir.normalized;
            // And finally we add force in the direction of dir and multiply it by force. 
            // This will push back the object
            c.gameObject.GetComponent<Rigidbody>().AddForce(dir * force);
        }

    }
}
