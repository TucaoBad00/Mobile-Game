using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public Transform levelContainer;

    public List<GameObject> level;

    public int _index;

    private GameObject currentLevel;

    public List<LevelPathBase> LevelPaths;
    private List<LevelPathBase> SpawnedPaths;
    public int PathsNumber;
    private void Awake()
    {
        //SpawNextLevel();
        CreateLevelPaths();
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
            ResetLevel();
        }
        currentLevel = Instantiate(level[_index], levelContainer);
        currentLevel.transform.localPosition = Vector3.zero;
    }
    private void ResetLevel()
    {
        _index = 0;
    }


    private void CreateLevelPath()
    {
        var path = LevelPaths[Random.Range(0, LevelPaths.Count)];
        var spawnedPath = Instantiate(path, levelContainer);
        if(SpawnedPaths.Count > 0)
        {
            var lastPath = SpawnedPaths[SpawnedPaths.Count - 1];
            spawnedPath.transform.position = lastPath.endPath.position;
        }
        SpawnedPaths.Add(spawnedPath);
    }

    private void CreateLevelPaths()
    {
        SpawnedPaths = new List<LevelPathBase>();

        for(int i = 0; i < PathsNumber; i++)
        {
            CreateLevelPath();
        }
    }
}
    