using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BossHealthBar : MonoBehaviour
{   

    public Slider healthSlider;
    public Health bossHealth;

    private void Start()
    {      
        {
            if(bossHealth == null)
            {
                Debug.LogError("BossHealthBar: Boss Health script reference is not set.");
                return;
            }
        }

        healthSlider.maxValue = bossHealth.maximumHealth;

        UpdateHealthUI();
    }

    private void Update()
    {
        UpdateHealthUI();
    }

    public void UpdateHealthUI()
    {
        if(healthSlider != null && bossHealth != null)
        {
            healthSlider.value = bossHealth.currentHealth;
        }
    }

    //public void SetMaxHealth(int health)
    //{
    //    slider.maxValue = health;
    //    slider.value = health;
    //}
    //public void SetHealth(int health)
    //{
    //    slider.value = health;
    //}

}
