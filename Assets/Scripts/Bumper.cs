using System;
using UnityEngine;

public class Bumper : MonoBehaviour
{
    public Vector3 force;
    public float strength = 100;
    public int pointsValue = 100;
    public Animation animation;
    private void OnCollisionEnter(Collision collision)
    {
        force = (collision.transform.position - transform.position).normalized*strength;
        collision.rigidbody.AddForce(force, ForceMode.Impulse);
        
        animation.Play();

        ScoreManager.instance.GainPoint(100);
    }
}
