using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorfixer : MonoBehaviour
{
    public Material mat1, mat2, mat3, mat4, mat5, mat6;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mat1.color = (new Color(1f, 0.9215686274509804f, 0.23137254901960784f, 25) * 3);
        mat2.color = (new Color(1f, 0.9215686274509804f, 0.23137254901960784f, 25) * 3);
        mat3.color = (new Color(0.256862745098f, 0.1725490196078f, 0.6549019607843f, 25) * 3);
        mat4.color = (new Color(0.256862745098f, 0.1725490196078f, 0.6549019607843f, 25) * 3);
        mat5.color = (new Color(0.12568627451f, 0.8862745098039f, 0.1490196078431f, 25) * 3);
        mat6.color = (new Color(0.12568627451f, 0.8862745098039f, 0.1490196078431f, 25) * 3);
    }
}
