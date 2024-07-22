using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum ThemeId
{
    SimpleBoxes,
    Pikmin,
    HollowKnight

}

[CreateAssetMenu(menuName = "ScriptableObj/ThemeSprites")]
public class ThemeSprites : ScriptableObject
{
    public ThemeId id;

    public Sprite[] sprite;
    public Sprite[] moderatorSprite;
    public Sprite[] hostSprite;
    public Sprite[] subSprite;

   
}
