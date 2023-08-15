using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public Transform levelContainer;
    public List<GameObject> level;
    public int _index;
    private GameObject currentLevel;
    private void Awake()
    {
        SpawNextLevel();
    }
    public void SpawNextLevel()
    {
        

        if( currentLevel != null)
        {
            Destroy(currentLevel);
            _index++;
        }
        if (_index >= level.Count)
        {
            _index = 0;
        }
        currentLevel = Instantiate(level[_index], levelContainer);
        currentLevel.transform.localPosition = Vector3.zero;
    }
    private void ResetLevel()
    {

    }
}
