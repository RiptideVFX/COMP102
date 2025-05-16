using System.IO.Ports;
using UnityEngine;

public class SerialReader : MonoBehaviour
{
    SerialPort serial;
    public Player player;

    void Start()
    {
        serial = new SerialPort("COM3", 9600); // Double-check the port!
        serial.Open();
        serial.ReadTimeout = 50;
    }

    void Update()
    {
        if (serial.IsOpen)
        {
            try
            {
                string input = serial.ReadExisting(); // Read all available data
                if (input.Contains("JUMP"))
                {
                    Debug.Log("JUMP received from Arduino!");
                    player.Flap();
                }
            }
            catch (System.Exception ex)
            {
                Debug.LogWarning("Serial error: " + ex.Message);
            }
        }
    }

    void OnApplicationQuit()
    {
        if (serial != null && serial.IsOpen)
            serial.Close();
    }
}
