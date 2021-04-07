﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public List<FoodSO> foodList;
    public Button recipeSelect;
    public Text foodName;

    public int foodIndex = 0;

    static GameManager instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    private void Update()
    {
        recipeSelect.image.sprite = foodList[foodIndex].foodImage;
        foodName.text = foodList[foodIndex].iName;
    }

    public void ChangeRight()
    {
        foodIndex++;
        if (foodIndex > 2)
        {
            foodIndex = 0;
        }
    }

    public void ChangeLeft()
    {
        foodIndex--;
        if (foodIndex < 0)
        {
            foodIndex = 2;
        }
    }

}
