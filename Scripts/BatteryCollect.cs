using UnityEngine;

public class BatteryCollect : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Collected");

            if (BatteryManager.instance != null)
            {
                BatteryManager.instance.AddBattery();
            }
            else
            {
                Debug.LogError("BatteryManager NOT found!");
            }

            Destroy(gameObject);
        }
    }
}