


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour

{

    public Transform Player;
    public float MoveSpeed = 4;
    public float Rotation =10.0f;
    int MaxDist = 10;
    int MinDist = 5;




    void Update()
    {
        transform.LookAt(Player);

    if (Vector3.Distance(transform.position, Player.position) >= MinDist)
    {

        transform.position += transform.forward * MoveSpeed * Time.deltaTime;


        if (Vector3.Distance(transform.position, Player.position) <= MaxDist)
        {
           // Put what do you want to happen here
          // transform.position Rotation;
        }

    }
   }
}