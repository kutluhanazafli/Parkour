using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserEnemy : MonoBehaviour
{

    RaycastHit hit;
    public LayerMask obstacle, player_layer;

    public GameObject death_effect;

    public float laser_multiplier = 2f;
    private bool laser_hit;
    public float range = 100f;

    private void Update()
    {

        // Line Renderer
        if(Physics.Raycast(transform.position, transform.forward, out hit, range, obstacle))
        {
            GetComponent<LineRenderer>().enabled = true;
            laser_hit = true;

            GetComponent<LineRenderer>().SetPosition(0, transform.position);
            GetComponent<LineRenderer>().SetPosition(1, hit.point);

            GetComponent<LineRenderer>().startWidth = 0.1f * laser_multiplier + Mathf.Sin(Time.time * 10) * 0.01f;
        }
        else
        {
            GetComponent<LineRenderer>().enabled = false;
            laser_hit = false;
        }

        // Kill Player
        if(Physics.Raycast(transform.position, transform.forward, out hit, range, player_layer))
        {
            if (laser_hit)
            {
                hit.transform.gameObject.GetComponent<PlayerManager>().Death();
            }
        }
    }
}
