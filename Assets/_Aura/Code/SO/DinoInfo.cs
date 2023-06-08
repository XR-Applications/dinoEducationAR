using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName ="dinoInfo",menuName ="New Dino Info")]
public class DinoInfo : ScriptableObject
{
    public Image backGroundImage;
    public string tite;
    public string details;
    public string linkToWiki;
}
