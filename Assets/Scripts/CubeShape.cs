using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeShape : Shape // INHERITANCE
{
    public override void OnMouseDown() // POLYMORPHISM
    {
        Jump();
    }

    public override void Jump() // ABSTRACTION
    {
        if (isGrounded == true)
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * force, ForceMode.Impulse);
            GetComponent<Rigidbody>().AddTorque(Vector3.up * torque);
            isGrounded = false;
        }
    }
}
