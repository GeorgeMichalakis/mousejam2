using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetGridPositions : MonoBehaviour
{
    private Vector3[] positions;
    void Start()
    {
        int length = gameObject.transform.parent.childCount;
        positions = new Vector3[length];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
