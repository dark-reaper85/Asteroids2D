using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeChecker : MonoBehaviour
{
    public int CurrentLives;
    public int MaxLivesCount;
    public Image[] Lives;

    private void Update()
    {
        if (CurrentLives > MaxLivesCount)
        {
             CurrentLives = MaxLivesCount;
        }

        for (int i = 0; i < Lives.Length; i++)
        {
            if (i < CurrentLives)
            {
                Lives[i].enabled = true;
            }
            else
            {
                Lives[i].enabled = false;
            }
        }
    }
}
