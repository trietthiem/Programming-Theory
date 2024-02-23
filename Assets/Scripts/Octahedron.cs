using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Octahedron : Polyhedron // INHERITANCE
{
    // Start is called before the first frame update

    private void Update()
    {
        SelfRotate(new Vector3(1, 0, 1));
        TransformColor(0.01f, 0.02f, 0.03f);
    }
    public override void SetInfo()
    {
        name = "Regular Octahedron"; // POLYMORPHISM
        vertices = 6;
        edges = 12;
        faces = 8;
    }
}
