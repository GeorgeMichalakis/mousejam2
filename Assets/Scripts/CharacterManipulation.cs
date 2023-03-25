using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterManipulation : MonoBehaviour
{
    [SerializeField]
    Material hiddenMaterial;
    public int EnableGameCharacters(int[] indexToEnable)
    {
        for (int _ = 0; _ < indexToEnable.Length; _++)
        {
            gameObject.transform.GetChild(indexToEnable[_]).gameObject.SetActive(true);
        }
        return 0;
    }

    public int PaintAllCharactersBlack(int[] indexToEnable)
    {
        for (int _ = 0; _ < indexToEnable.Length; _++)
        {
            int amountOfChildren = gameObject.transform.GetChild(indexToEnable[_]).childCount;
            if (gameObject.transform.GetChild(indexToEnable[_]).GetComponent<SpriteRenderer>() != null)
            {
                gameObject.transform.GetChild(indexToEnable[_]).GetComponent<SpriteRenderer>().material = hiddenMaterial;
            }
            for (int __ = 0; __ < amountOfChildren; __++)
            {
                if (gameObject.transform.GetChild(indexToEnable[_]).GetChild(__).GetComponent<SpriteRenderer>() != null)
                {
                    gameObject.transform.GetChild(indexToEnable[_]).GetChild(__).GetComponent<SpriteRenderer>().material = hiddenMaterial;
                }
            }
        }
        return 0;
    }
}
