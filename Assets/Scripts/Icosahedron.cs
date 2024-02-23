using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Icosahedron : Polyhedron // INHERITANCE
{
    // Start is called before the first frame update

    private void Update()
    {
        SelfRotate(new Vector3(1, 1, 0));
        TransformColor(0.03f, 0.01f, 0.02f);
    }

    public override void SetInfo()
    {
        name = "Regular Icosahedron";
        vertices = 12;
        edges = 30;
        faces = 20;
    }

}
