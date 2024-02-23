using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InfoPanel : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI m_name;
    [SerializeField] private TextMeshProUGUI m_info;
    // Start is called before the first frame update

    void Start()
    {
        DisplayInfo("Name", 0, 0, 0);
    }

    public void DisplayInfo(string name, int vertices, int edges, int faces)
    {
        m_name.text = name;
        if (vertices > 0) m_info.text = faces + " faces, " + vertices + " verties, " + edges + " edges.";
        else m_info.text = "";
    }

}
