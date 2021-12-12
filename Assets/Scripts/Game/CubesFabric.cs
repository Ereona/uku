using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubesFabric : MonoBehaviour
{
    [SerializeField]
    private Cube _cubePrefab;
    [SerializeField]
    private Transform _cubesParent;
    [SerializeField]
    private CubeColorProvider _colorProvider;

    public GameObject CreateCube()
    {
        Cube cube = Instantiate(_cubePrefab, _cubesParent);
        cube.SetColor(_colorProvider.GetColor());
        return cube.gameObject;
    }
}
