using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class ShowScore : MonoBehaviour
{
    public TMPro.TextMeshProUGUI m_TextMeshPro;
    // Start is called before the first frame update
    void Start()
    {
        if (File.Exists("temp.txt"))
        {
            m_TextMeshPro.text = System.Int32.Parse(File.ReadAllText("temp.txt")).ToString();
            File.Delete("temp.txt");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
