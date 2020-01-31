﻿ using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PLY_HealthComponent : MonoBehaviour
{
    // Programmer: Ron
    // Additional Programmer: Danish
    // Description: Modular component to manage Health for all applicable entities.

    [Header("Variables")]
    public float currentHealth;
    public float maxHealth;
    public float defValue;
    public float CurrSpirit;
    public float maxSpirit;

	public Image HPBar;
	public Image SpiritBar;
	public Color HPGlowColor;
	public Image HPGlow;
	public Color SpiritGlowColor;
	public Image SpiritGlow;

    // Code to Initialize Health Component
    public void Init(int _maxHealth, float _defValue, int _maxSpirit)
    {
        // Cache the _maxHealth value in a local variable
        maxHealth = _maxHealth;

        // Set currentHealth equal to the cached maxHealth value
        currentHealth = maxHealth;

        // Cache the _defValue in a local variable
        defValue = _defValue;
        maxSpirit = _maxSpirit;
        CurrSpirit = maxSpirit;


    }

    // Code to Add Health 
    public void AddHealth(float value)
    {
       // If currentHealth plus value is greater than maxHealth, set it to maxHealth
       if((currentHealth + value) > maxHealth)
        {
            currentHealth = maxHealth;
        }
       // else, add the value to currentHealth
        else
        {
            currentHealth += value;
        }
    }

    // Code to Subtract Health
    public void SubHealth(float value)
    {
        // Calculate damage amount by multiplying value by defValue
        //float damage = value * defValue;
        float damage = value;

        // If currentHealth minus value is less than 0, set it to 0
        if ((currentHealth - damage) < 0)
        {
            currentHealth = 0;
        }
        // else, subtract the damage from the currentHealth
        else
        {
            currentHealth -= damage;
        }
    }

    public void SubHealthTime(float value)
    {
        if (currentHealth <= 0)
        {
            currentHealth = 0;
			print("Tiny Dead!");
        }
        else
        {
            currentHealth -= value * Time.deltaTime;
        }
    }
    public void SubSpiritOrb(float value)
    {
        if (CurrSpirit<=0)
        {
            CurrSpirit = 0;
        }
        else
        {
            CurrSpirit -= value;
        }
    }

    public void SubSpiritTime(float value)
    {
        if (CurrSpirit <= 0)
        {
            CurrSpirit = 0;
        }
        else
        {
            CurrSpirit -= value * Time.deltaTime;
        }
    }

	void Start()
	{
		HPGlowColor = HPGlow.color;
		SpiritGlowColor = SpiritGlow.color;
	}

	void Update()
	{
		
		HPBar.fillAmount = currentHealth / maxHealth;
		HPGlowColor.a = HPBar.fillAmount;
		SpiritBar.fillAmount = CurrSpirit / maxSpirit;
		SpiritGlowColor.a = SpiritBar.fillAmount;
	}

}
