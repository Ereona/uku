using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "SO/GameSettings")]
public class GameSettings : ScriptableObject
{
    [SerializeField]
    [Range(1, 100)]
    private int _cellsCount = 10;
    [SerializeField]
    private float _planeSize = 20;

    public int CellsCount
    {
        get
        {
            return _cellsCount;
        }
    }

    public float PlaneSize
    {
        get
        {
            return _planeSize;
        }
    }
}
