using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildController : MonoBehaviour
{
    [SerializeField]
    private CubesFabric _fabric;
    [SerializeField]
    private GameObject _planeObject;
    [SerializeField]
    private GameSettings _gameSettings;

    private float _cellSize;
    private int[,] _cubesCount;

    void Start()
    {
        EventsBus.MouseButtonDown += EventsBus_MouseButtonDown;

        _cellSize = _gameSettings.PlaneSize / _gameSettings.CellsCount;
        _planeObject.transform.localScale = Vector3.one * _gameSettings.PlaneSize * 0.1f;
        _cubesCount = new int[_gameSettings.CellsCount, _gameSettings.CellsCount];
    }

    private void EventsBus_MouseButtonDown(Vector3 pos)
    {
        RaycastHit hit;
        var ray = Camera.main.ScreenPointToRay(pos);
        if (Physics.Raycast(ray, out hit))
        {
            var transform = hit.collider.GetComponent<Transform>();
            if (transform)
            {
                int row = GetIndex(hit.point.x);
                if (row == -1)
                {
                    return;
                }
                int col = GetIndex(hit.point.z);
                if (col == -1)
                {
                    return;
                }
                CreateCube(row, col);
            }
        }
    }

    private int GetIndex(float pos)
    {
        int index = (int)((pos + _gameSettings.PlaneSize / 2) / _cellSize);
        if (index < 0 || index > _gameSettings.CellsCount)
        {
            return -1;
        }
        return index;
    }

    private void CreateCube(int row, int col)
    {
        GameObject cube = _fabric.CreateCube();
        cube.transform.localPosition = CalcPosition(row, col, _cubesCount[row, col]);
        cube.transform.localScale = Vector3.one * _cellSize;
        _cubesCount[row, col]++;
    }

    private Vector3 CalcPosition(int row, int col, int height)
    {
        float x = row * _cellSize - _gameSettings.PlaneSize / 2;
        float y = height * _cellSize;
        float z = col * _cellSize - _gameSettings.PlaneSize / 2;
        return new Vector3(x, y, z);
    }

    private void OnDestroy()
    {
        EventsBus.MouseButtonDown -= EventsBus_MouseButtonDown;
    }
}
