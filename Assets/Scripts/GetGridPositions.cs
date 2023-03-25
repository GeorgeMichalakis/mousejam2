using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetGridPositions : MonoBehaviour
{
    public Vector2[] GetPositions()
    {
        int length = gameObject.transform.childCount;
        Vector2[] positions = new Vector2[length];
        for (int _ = 0; _ < length; _++)
        {
            Vector3 pos = gameObject.transform.GetChild(_).transform.localPosition;
            positions[_] = new Vector2(pos.x,pos.y);
        }
        return positions;
    }
}
