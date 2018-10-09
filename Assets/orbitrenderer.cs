using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(LineRenderer))]
public class orbitrenderer : MonoBehaviour {

    LineRenderer lr;
    public int segments;
    public Orbit orbitplayer;

    private void Awake()
    {
        lr = GetComponent<LineRenderer>();
     
    }
    void CalcORbit()
    {
        Vector3[] points = new Vector3[segments + 1];
        for(int i =0; i < segments; i++)
        {
            Vector2 pos2D =orbitplayer.Evaluate((float)i / (float)segments);
            points[i] = pos2D;
        }
        points[segments] = points[0];

        lr.positionCount = segments + 1;
        lr.SetPositions(points);
    }
    private void OnValidate()
    {
        if (Application.isPlaying && lr != null)
        {
            CalcORbit();
        }
    }
}
