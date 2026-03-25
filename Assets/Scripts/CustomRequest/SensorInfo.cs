using System;
using System.Collections.Generic;

[Serializable]
public class SensorInfo
{
    public float temperatura;
    public float Humedad;
    public List<Sensor> sensores;

}

[Serializable]
public class Sensor
{
    public string nombre;
}
