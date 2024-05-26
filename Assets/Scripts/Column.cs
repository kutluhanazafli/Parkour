using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Column : MonoBehaviour
{
    public Transform checker;
    public LayerMask player_layer;
    public float radius = 1f;
    private Vector3 velocity;
    private bool broke = false;

    private void FixedUpdate()
    {
        if(Physics.CheckBox(checker.position, new Vector3(radius, 2f, radius), Quaternion.identity, player_layer))
        {
            broke = true;
        }
        if(broke)
        {
            velocity.y -= Time.deltaTime / 25;
            transform.Translate(velocity);
        }
    }
}
