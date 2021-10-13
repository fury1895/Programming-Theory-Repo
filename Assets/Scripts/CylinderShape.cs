using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderShape : Shape
{
    public override void OnMouseDown()
    {
        Jump();
    }
}
