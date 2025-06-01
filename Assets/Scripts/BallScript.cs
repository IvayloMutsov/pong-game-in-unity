using UnityEngine;

public class BallScript : MonoBehaviour
{
    public GameObject greenWin;
    public GameObject redWin;
    public Rigidbody2D rigidbody;
    int directionX;
    int directionY;
    System.Random random = new System.Random();
    void Awake()
    {
        greenWin = GameObject.Find("GreenWins");
        redWin = GameObject.Find("RedWins");
        rigidbody = gameObject.GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        redWin.SetActive(false);
        greenWin.SetActive(false);
        directionX = random.Next(-1, 1);
        directionY = random.Next(-1, 1);
        Debug.Log(directionX + " " + directionY);
        rigidbody.AddForce(new Vector2(directionX, directionY));
    }

    void FixedUpdate()
    {
        if (directionX == 0 && directionY == 0)
        {
            Debug.Log(directionX + " " + directionY);
            directionX = random.Next(-1, 1);
            directionY = random.Next(-1, 1);
        }
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
