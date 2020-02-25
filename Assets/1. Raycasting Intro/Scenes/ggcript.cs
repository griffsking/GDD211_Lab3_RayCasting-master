using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ggcript : MonoBehaviour
{
    public SpriteRenderer Sprite;
    public SpriteRenderer win;
    int c = 0;
    private void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.eulerAngles += new Vector3(0f, 0f, Time.deltaTime * 50f);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.eulerAngles += new Vector3(0f, 0f, Time.deltaTime * -50f);
        }

        RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.up);

        Debug.DrawRay(transform.position, transform.up * 100f, Color.green);
        if (hit)
        {
            butt hitButt = hit.collider.GetComponent<butt>();
            if (hitButt && Input.GetKeyDown(KeyCode.Space))
            {
                Destroy(hitButt.gameObject);
                c++;
                if (c == 7)
                {
                    Instantiate(win);
                }
            }
        }
    }
}
