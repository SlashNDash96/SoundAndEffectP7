using System.Collections;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float leftBound = -15;
    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript =
            GameObject.Find("Player").GetComponent<PlayerController>();
    }

    private float speed = 30;
    private PlayerController playerControllerScript;

    // Update is called once per frame
    void Update()
    { if (playerControllerScript.gameOver == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
    if (transform.position.x < leftBound && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
    }
}
