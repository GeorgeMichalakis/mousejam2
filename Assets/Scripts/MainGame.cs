using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGame : MonoBehaviour
{
    [SerializeField]
    int numberOfReplicas = 5;
    [SerializeField]
    int desiredNumberOfCharacters = 5;
    [SerializeField]
    GetGridPositions getGridPositionScript;
    [SerializeField]
    CharacterManipulation characterManipulationScript;
    private void Start()
    {
        int[] indexesOfCharacters = ReturnCharacterIndexes(getGridPositionScript.GetPositions().Length, desiredNumberOfCharacters);
        characterManipulationScript.ChooseTheCorrectCharacter(indexesOfCharacters.Length, numberOfReplicas);
        characterManipulationScript.EnableGameCharacters(indexesOfCharacters);
        characterManipulationScript.PaintAllCharactersBlack(indexesOfCharacters);
        characterManipulationScript.AssignCollidersToDetectClick(indexesOfCharacters);
        characterManipulationScript.AssignMouseDetectorScript(indexesOfCharacters);
    }
    private int[] ReturnCharacterIndexes(int maxNumberofCharacters, int desiredNumberOfCharacters)
    {
        if (desiredNumberOfCharacters > maxNumberofCharacters)
        {
            desiredNumberOfCharacters = maxNumberofCharacters;
        }
        else if(desiredNumberOfCharacters < 0)
        {
            desiredNumberOfCharacters = 0;
        }
        List<int> arrayToChoseFrom=new List<int>();
        for (int _ = 0; _ < maxNumberofCharacters; _++)
        {
            arrayToChoseFrom.Add(_);
        }
        int[] actualPositions = new int[desiredNumberOfCharacters];
        for (int _ = 0; _ < desiredNumberOfCharacters; _++)
        {
            int val = arrayToChoseFrom[Random.Range(0, arrayToChoseFrom.Count)];
            actualPositions[_] = val;
            arrayToChoseFrom.Remove(val);
        }
        return actualPositions;
    }
}
