using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeColorProvider : MonoBehaviour
{
    public Color GetColor()
    {
        return new Color(Random.value, Random.value, Random.value);
    }
}
