using UnityEngine;
using TMPro;

public class BatteryManager : MonoBehaviour
{
    public static BatteryManager instance;

    public int batteryCount = 0;
    public TextMeshProUGUI batteryText;

    void Awake()
    {
        instance = this;

        // Initialize text at start
        if (batteryText != null)
            batteryText.text = "Battery: 0";
    }

    public void AddBattery()
    {
        batteryCount++;

        Debug.Log("Battery Count = " + batteryCount);

        if (batteryText != null)
        {
            batteryText.text = "Battery: " + batteryCount;
        }
    }
}