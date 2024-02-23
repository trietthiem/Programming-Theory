using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Polyhedron : MonoBehaviour
{
    public new string name;

    public static Polyhedron Instance { get; private set; }

    private int m_vertices = 0;
    public int vertices  // ENCAPSULATION
    {
        get { return m_vertices; } 
        set
        {
            if (value < 0)
            {
                Debug.LogError("You can't set a negative number");
            }
            else
            {
                m_vertices = value; 
            }
        }
    }

    private int m_edges;
    public int edges
    {
        get { return m_edges; } 
        set
        {
            if (value < 0)
            {
                Debug.LogError("You can't set a negative number");
            }
            else
            {
                m_edges = value; 
            }
        }
    }

    private int m_faces;
    public int faces
    {
        get { return m_faces; } 
        set
        {
            if (value < 0)
            {
                Debug.LogError("You can't set a negative number");
            }
            else
            {
                m_faces = value; 
            }
        }
    }

    private float m_rotateSpeed = 50f;
    // Start is called before the first frame update

   
    void Start()
    {
        SetInfo();
    }


    // Update is called once per frame

    public void SelfRotate(Vector3 rotationAxis) // ABSTRACTION
    {
        transform.Rotate(rotationAxis, Time.deltaTime * m_rotateSpeed);
    }


    public virtual void TransformColor(float rSpeed, float gSpeed, float bSpeed) // ABSTRACTION
    {
        Renderer renderer = GetComponent<Renderer>();
        if (renderer != null)
        {
            Material material = renderer.material;
            material.color = new Color(ColorPlus(material.color.r, Time.deltaTime, rSpeed), ColorPlus(material.color.g, Time.deltaTime, rSpeed), ColorPlus(material.color.b, Time.deltaTime, rSpeed), 0.2f);
        }
        else
        {
            Debug.LogError("No Renderer component found!");
        }
    }
    
    private float ColorPlus(float color, float delta, float speed) // ABSTRACTION
    {
        float result = color + delta * speed;
        if (result > 1) result -= 1;
        return result;
    }

    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            FindObjectOfType<InfoPanel>().DisplayInfo(name, vertices, edges, faces);
        }
    }

    public virtual void SetInfo() // POLYMORPHISM
    {
        name = "";
        vertices = 0;
        edges = 0;
        faces = 0;
    }
}
