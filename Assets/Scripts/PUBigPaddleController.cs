using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUBigPaddleController : MonoBehaviour
{
    public Collider2D ball;
    public Collider2D rightPaddle;
    public Collider2D leftPaddle;
    public PowerUpManager manager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == ball)
        {
            rightPaddle.GetComponent<PaddleController>().ActivatePUBigPaddle();
            leftPaddle.GetComponent<PaddleController>().ActivatePUBigPaddle();
            manager.RemovePowerUp(gameObject);
        }
    }
}
