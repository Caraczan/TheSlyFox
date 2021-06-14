using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public Transform pos1, pos2;
    public float speed;
    public Transform startPos;
    private bool moving;

    Vector3 nextPos;
    // Start is called before the first frame update
    void Start()
    {
        nextPos = startPos.position;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            collision.collider.transform.SetParent(null);
        }
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if(transform.position == pos1.position)
        {
            nextPos = pos2.position;
        }
        if(transform.position == pos2.position)
        {
            nextPos = pos1.position;
        }
        
        transform.position = Vector3.MoveTowards(transform.position,nextPos,speed*Time.deltaTime);
    }

    private void OnDraw()
    {
        Gizmos.DrawLine(pos1.position, pos2.position);
    }
}
