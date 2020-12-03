using System.Threading;
using UnityEngine;
using UnityEngine.Rendering;

public class MagicCube : MonoBehaviour
{
    private RectTransform rect;

    private float tempSpeed;
    private float timer;

    private void Awake()
    {
        rect = GetComponent<RectTransform>();
    }

    private void Update()
    {
        Move();
        Control();
        Rotate();
    }

    private void Move()
    {
        if (timer < MagicCubeManager.speed)
        {
            timer += Time.deltaTime;
        }
        else
        {
            timer = 0;
            rect.anchoredPosition += new Vector2(0, -10);
        }
    }

    private void Control()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            tempSpeed = MagicCubeManager.speed;
            MagicCubeManager.speed = 0.1f;
        }
        else if (Input.GetKeyUp(KeyCode.S))
        {
            MagicCubeManager.speed = tempSpeed;
        }
    }

    private void Rotate()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.eulerAngles -= new Vector3(0, 0, 90);
        }
    }
}
