using UnityEngine;

public class BallScript : MonoBehaviour
{
    GameObject greenWin;
    GameObject redWin;
    Rigidbody2D rigidbody;
    void Awake()
    {
        redWin.SetActive(false);
        greenWin.SetActive(false);
        greenWin = GameObject.Find("GreenWins");
        redWin = GameObject.Find("RedWins");
        rigidbody = gameObject.GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        System.Random random = new System.Random();
        int directionX = random.Next(-1, 1);
        int directionY = random.Next(-1, 1);
        rigidbody.AddForce(new Vector2(directionX, directionY));
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        System.Random random = new System.Random();
        int directionX = random.Next(-1, 1);
        int directionY = random.Next(-1, 1);
        rigidbody.AddForce(new Vector2(directionX, directionY));
        if (collision.gameObject.tag == "Goal")
        {
            if (collision.gameObject.name == "GoalRed")
            {
                redWin.SetActive(true);
            }
            else if (collision.gameObject.name == "GoalGreen")
            {
                greenWin.SetActive(true);
            }
        }
    }

    public void Quit()
    {
        Application.Quit();
    }
}
