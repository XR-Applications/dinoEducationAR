using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName ="dinoInfo",menuName ="New Dino Info")]
public class DinoInfo : ScriptableObject
{
    public Sprite backGroundImage;
    public string tite;
    [TextArea(5,10)]public string details;
    public string linkToWiki;

   
}
