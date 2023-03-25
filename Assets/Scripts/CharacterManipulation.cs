using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterManipulation : MonoBehaviour
{
    public int EnableGameCharacters(int[] indexToEnable)
    {
        for (int _ = 0; _ < indexToEnable.Length; _++)
        {
            gameObject.transform.GetChild(indexToEnable[_]).gameObject.SetActive(true);
        }
        return 0;
    }
}
