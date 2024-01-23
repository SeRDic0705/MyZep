using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum CharacterType
{
    Penguin,
    Knight
}

[System.Serializable]
public class Character
{
    public CharacterType characterType;
    public Sprite sprite;
    public RuntimeAnimatorController animatorController;
}


public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public List<Character> characterList = new List<Character>();

    public Animator animator;
    public Text playerName;

    private void Awake()
    {
        if(Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    public void SetCharacter(CharacterType characterType, string name)
    {
        var character = GameManager.Instance.characterList.Find(item => item.characterType == characterType);

        animator.runtimeAnimatorController = character.animatorController;
        playerName.text = name;
    }

}
