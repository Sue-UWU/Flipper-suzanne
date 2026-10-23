using UnityEngine;

public class BumperCube : MonoBehaviour

{
    public Vector3 force;
    public float strength = 100;
    public Animation animation;
    
    void OnCollisionEnter(Collision collision)
    {
        force = -collision.contacts[0].normal;
        collision.rigidbody.AddForce(force, ForceMode.Impulse);

        animation.Play();
    }
}
