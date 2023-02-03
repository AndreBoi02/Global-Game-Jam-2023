using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantUpgrade : MonoBehaviour
{
    public GameObject[] levels;
    int currentLevel = 0;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Upgrade();
        }
    }
    public void Upgrade()
    {
        if (currentLevel < levels.Length - 1)
            currentLevel++;
            switchLevel(currentLevel);
    }

    void switchLevel(int lvl)
    {
        for (int i = 0; i < levels.Length; i++)
        {
            if (i == lvl)
                levels[i].SetActive(true);
            else
                levels[i].SetActive(false);
        }
    }
}
