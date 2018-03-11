﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CategoryButton : MonoBehaviour, PointableObject {

	[SerializeField] private Image categoryIcon;
	[SerializeField] private Color defaultColor;
	[SerializeField] private Color highlightColor;
	[SerializeField] private Color selectedColor;

	[SerializeField] string categoryName;


	// Use this for initialization
	void Start () {
		categoryIcon.color = defaultColor;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void PointerEnter()
	{
		categoryIcon.color = highlightColor;
	}

	public void PointerClick()
	{
		CategoryManager manager = CategoryManager.GetInstance();
		if (manager.CheckIfSelected(categoryName))
			categoryIcon.color = selectedColor;
		else
			categoryIcon.color = defaultColor;

		manager.ToggleSelected(categoryName);
	}

	public void PointerExit()
	{
		if (CategoryManager.GetInstance().CheckIfSelected(categoryName))
			categoryIcon.color = selectedColor;
		else
			categoryIcon.color = defaultColor;
	}
}