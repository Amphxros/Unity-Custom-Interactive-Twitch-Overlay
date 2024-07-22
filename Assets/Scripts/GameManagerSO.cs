using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObj/GameManager")]
public class GameManagerSO : ScriptableObject
{
    [SerializeField] public ThemeSprites currentTheme;
    [SerializeField] List<ThemeSprites> allThemeSprites_;

    List<BoxController> allGO;
    
    public void addGameObject(BoxController go)
    {
        allGO.Add(go);
    }
    public void setCurrentTheme(ThemeId id)
    {

    }
}
