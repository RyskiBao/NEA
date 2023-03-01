using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlacementGen : MonoBehaviour
{
    public int width;
    public int height;

    [Range(0.01f, 10f)]
    public float scale;

    public GameObject treePrefab;
    [Range(0.01f, 10f)]
    public float acceptancePoint;

    public LayerMask groundLayer;

    void Start()
    {
        for(int y = 0; y < height; y++)
        {
            for(int x =0; x < width; x++)
            {
                float xValue = x/scale;
                float yValue = y/scale;

                float perlinValue = Mathf.PerlinNoise(xValue, yValue);

                if (perlinValue >= acceptancePoint)
                {
                    if(Physics.Raycast(new Vector3(x,100,y), Vector3.down, out RaycastHit hit, 200f, groundLayer))
                    {
                        float yPoint;
                        yPoint= hit.point.y;
                        Instantiate(treePrefab, new Vector3(x, yPoint, y), Quaternion.identity);
                    }
                }
            }
        }
    }
}
