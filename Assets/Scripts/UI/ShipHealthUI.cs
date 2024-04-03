using UnityEngine;
using UnityEngine.UI;

public class ShipHealthUI : MonoBehaviour
{
    public GameObject shipImage; // Reference to the GameObject containing the ship image
    public Health healthScript; // Reference to the Health script attached to the ship GameObject

    void Start()
    {
        // Ensure the ship image GameObject is active initially
        shipImage.SetActive(true);
    }

    void Update()
    {
        // Check if the ship's health is less than or equal to 0
        if (healthScript != null && healthScript.currentHealth <= 0)
        {
            // Disable the ship image GameObject
            shipImage.SetActive(false);
        }
    }
}
