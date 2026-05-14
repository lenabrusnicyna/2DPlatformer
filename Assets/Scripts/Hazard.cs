using UnityEngine;

public class Hazard : MonoBehaviour
{
    private PlayerControllers player;
    public Transform start;

    void Start()
    {
        player = Object.FindFirstObjectByType<PlayerControllers>();
    }

    void Update()
    {
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            player.transform.position = start.position;
        }
    }
}
