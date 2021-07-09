using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTopdownMovementContoller : MonoBehaviour
{
    PlayerTopdownController playerController;

    void Awake()
    {
        playerController = GetComponent<PlayerTopdownController>();
    }
}
