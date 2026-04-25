using UnityEngine;

public class GroundScroller : MonoBehaviour
{
    public float speed = 5f;
    public float groundWidth = 18f;

    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);

        if (transform.position.x <= -groundWidth)
        {
            transform.position += new Vector3(groundWidth * 2f, 0, 0);
        }
    }
}
