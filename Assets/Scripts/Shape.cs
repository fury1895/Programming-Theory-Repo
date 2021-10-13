using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape : MonoBehaviour
{
    public static float force { get; private set; }
    public float torque = 1000.0f;
    public bool isGrounded;

    private void Start()
    {
        force = 5.0f;
    }
    
    public virtual void OnMouseDown()
    {
        Debug.Log("I will get overridden :-)");
    }

    public virtual void Jump()
    {
        if (isGrounded == true)
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * force, ForceMode.Impulse);
            isGrounded = false;
        }
    }

    public void PrintText()
    {

    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Plane")
        {
            isGrounded = true;
        }
    }
}