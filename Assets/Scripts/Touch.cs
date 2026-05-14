using UnityEngine;
using System.Collections;

public class Touch : MonoBehaviour
{
    private PlayerControllers player;


    void Start()
    {
        player = Object.FindFirstObjectByType<PlayerControllers>();
    }

    public void LeftArrow()
    {
        player.MoveRight = false;
        player.MoveLeft = true;
    }
    public void RightArrow()
    {
        player.MoveRight = true;
        player.MoveLeft = false;
    }
    public void ReleaseLeftArrow()
    {
        player.MoveLeft = false;
    }
    public void ReleaseRightArrow()
    {
        player.MoveRight = false;

    }
    public void Jump()
    {
        player.jump = true;
    }
}
