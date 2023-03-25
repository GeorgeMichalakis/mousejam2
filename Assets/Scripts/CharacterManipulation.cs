using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterManipulation : MonoBehaviour
{
    [SerializeField]
    Material whiteMaterial;
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
    public int AssignCollidersToDetectClick(int[] indexToEnable)
    {
        Vector2 offset = new Vector2(0f, 0.7f);
        Vector2 size = new Vector2(1.75f, 2f);
        for (int _ = 0; _ < indexToEnable.Length; _++)
        {
            gameObject.transform.GetChild(indexToEnable[_]).gameObject.AddComponent<BoxCollider2D>();
            gameObject.transform.GetChild(indexToEnable[_]).gameObject.GetComponent<BoxCollider2D>().offset = offset;
            gameObject.transform.GetChild(indexToEnable[_]).gameObject.GetComponent<BoxCollider2D>().size = size;
        }
        return 0;
    }
    public int AssignMouseDetectorScript(int[] indexToEnable)
    {

        for (int _ = 0; _ < indexToEnable.Length; _++)
        {
            gameObject.transform.GetChild(indexToEnable[_]).gameObject.AddComponent<MouseDetector>();
            gameObject.transform.GetChild(indexToEnable[_]).gameObject.
                GetComponent<MouseDetector>().characterManipulationScript=gameObject.GetComponent<CharacterManipulation>();
        }
        return 0;
    }
    public int PaintCharacterNormal(GameObject character)
    {
        int amountOfChildren = character.transform.childCount;
        if (character.GetComponent<SpriteRenderer>() != null)
        {
            character.GetComponent<SpriteRenderer>().material = whiteMaterial;
        }
        for (int _ = 0; _ < amountOfChildren; _++)
        {
            if (character.transform.GetChild(_).GetComponent<SpriteRenderer>() != null)
            {
                character.transform.GetChild(_).GetComponent<SpriteRenderer>().material = whiteMaterial;
            }
        }
        return 0;
    }
}
