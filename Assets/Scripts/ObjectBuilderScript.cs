using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class ObjectBuilderScript : MonoBehaviour
{
    [SerializeField] private GameObject tile;
    [SerializeField] private Transform parent;
    private int upperBound = 10;
    private int lowestBound = 0;


    public void GenerateMap()
    {
        for (int x = lowestBound; x <= upperBound; x++)
        {
            for (int z = lowestBound; z <= upperBound; z++)
            {
                var tilePosition = new Vector3(x, 0, z);
                GameObject.Instantiate(tile, tilePosition, Quaternion.identity, parent);
            }
        }
    }

    public void ClearMap()
    {
        var cubesToDestroy = new List<Transform>();
        foreach(Transform cube in parent.transform)
        {
            cubesToDestroy.Add(cube);
        }

        cubesToDestroy.ForEach(c => DestroyImmediate(c.gameObject));
    }
}
