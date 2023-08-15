using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArtType : MonoBehaviour
{
    public enum Arttype
    {
        FOREST,
        HELL,
        HEAVEN
    }
    public List<ArtSetup> artSetups;
}
[System.Serializable]
public class ArtSetup
{
    public ArtType.Arttype arttype;
    public GameObject gameobject;
}
