using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUFastPaddleController : MonoBehaviour
{
    public Collider2D ball;
    public Collider2D rightPaddle;
    public Collider2D leftPaddle;
    public int magnitude;
    public PowerUpManager manager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == ball)
        {
            rightPaddle.GetComponent<PaddleController>().ActivatePUFastPaddle(magnitude);
            leftPaddle.GetComponent<PaddleController>().ActivatePUFastPaddle(magnitude);
            manager.RemovePowerUp(gameObject);
        }
    }
}
