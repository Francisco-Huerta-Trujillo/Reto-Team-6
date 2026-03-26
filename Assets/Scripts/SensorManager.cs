using UnityEngine;

public class SensorManager : MonoBehaviour
{
    public GameObject lodo;
    public void SetupSensors(SensorInfo sensorInfo)
    {
        if(sensorInfo.Humedad > 0.5)
        {
           lodo.GetComponent<MeshRenderer>().material.color = Color.green;
        }
        else
        {
            lodo.GetComponent<MeshRenderer>().material.color = Color.red;
        }

        Debug.Log("Sensors: " + sensorInfo.sensores.Count);
    }
}
