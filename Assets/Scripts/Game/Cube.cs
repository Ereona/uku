using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    [SerializeField]
    private MeshRenderer _mesh;

    public void SetColor(Color color)
    {
        _mesh.material.SetColor("_BaseColor", color);
    }
}
