using UnityEngine;

public class PlayerGreenScript : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            gameObject.transform.position = new UnityEngine.Vector2(transform.position.x, -15f * Time.deltaTime);
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            gameObject.transform.position = new UnityEngine.Vector2(transform.position.x,15f * Time.deltaTime);
        }
    }
}