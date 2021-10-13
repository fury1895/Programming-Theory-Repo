using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereShape : Shape
{
    public override void OnMouseDown()
    {
        Jump();
    }
}
