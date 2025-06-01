using System.Numerics;
using UnityEngine;

public class PlayerRedScript : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            gameObject.transform.position = new UnityEngine.Vector2(transform.position.x, -15f * Time.deltaTime);
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            gameObject.transform.position = new UnityEngine.Vector2(transform.position.x,15f * Time.deltaTime);
        }
    }
}