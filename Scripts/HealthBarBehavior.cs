using System.Collections;
using UnityEditor;
using UnityEditor.UI;
using UnityEngine;
using UnityEngine.UI;

class HealthBarBehavior : MonoBehaviour
{
    public Slider healthBarSlider;
    private EntityStats playerStatus;
    public GameObject Entitie;


    void Start()
    {
        playerStatus = Entitie.GetComponent<EntityStats>();
        healthBarSlider.maxValue = playerStatus.maxHealth;
    }

    void Update()
    {
        GetHealthBarUpdated();
    }

    public void GetHealthBarUpdated()
    {
        healthBarSlider.value = playerStatus.health;
        if (healthBarSlider.value <= 0)
        {
            Destroy(GameObject.FindGameObjectWithTag("HealthBar"));
        }
    }

}