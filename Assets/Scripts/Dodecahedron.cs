using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dodecahedron : Polyhedron // INHERITANCE
{
    // Start is called before the first frame update
    private void Update()
    {
        SelfRotate(new Vector3(0, 1, 1));
        TransformColor(0.02f, 0.03f, 0.01f);
    }

public override void SetInfo()
    {
        name = "Regular Dodecahedron";
        vertices = 20;
        edges = 30;
        faces = 12;
    }
}
