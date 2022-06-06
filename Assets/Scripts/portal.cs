using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portal : MonoBehaviour
{
    [SerializeField] Transform portalExit;
    [SerializeField] Vector3 distanceExit;

    public void portalMove(GameObject Player)
    {
        Player.transform.position = portalExit.position + distanceExit;
    }
}
