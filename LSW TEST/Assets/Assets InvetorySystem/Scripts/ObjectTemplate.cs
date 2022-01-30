using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu (fileName = "Object", menuName = "objectStore")]
public class ObjectTemplate : ScriptableObject
{
    public Sprite objectImage;
    public string objectName;
    public int objectPrice;

}
