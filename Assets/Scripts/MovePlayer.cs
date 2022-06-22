using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    [SerializeField]
    private GameObject leg1;

    [SerializeField]
    private GameObject leg2;

    [SerializeField]
    private GameObject leg3;

    [SerializeField]
    private GameObject leg4;

    [SerializeField]
    private GameObject crawler;
    private Vector3 lastPos;
    private Transform crawlerTransform;
    private bool moved = false;
    private Vector3 followOffset;


    private void Start()
    {
        crawlerTransform = transform;
        lastPos = crawlerTransform.position;

    }

    private void Update()
    {
        if (crawlerTransform.position != lastPos)
        {
            moved = true;
            Debug.Log("moved");
        }
        else
            moved = false;

        lastPos = crawlerTransform.position;

    }
    private void FixedUpdate()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        RaycastHit hit;

        if (moved == true)
        {
            Physics.Raycast(crawler.transform.position, Vector3.up, out hit, Mathf.Infinity);

            followOffset = leg1.transform.position -  crawlerTransform.position;
            leg1.transform.position = Vector3.Lerp(leg1.transform.position, lastPos, Time.deltaTime);
            Quaternion legRotation = Quaternion.LookRotation(crawlerTransform.position);
            leg1.transform.rotation = legRotation;


            followOffset = leg2.transform.position - crawlerTransform.position;
            leg1.transform.position = Vector3.Lerp(leg1.transform.position, lastPos, Time.deltaTime);
            Quaternion leg2Rotation = Quaternion.LookRotation(crawlerTransform.position);
            leg2.transform.rotation = leg2Rotation;

            followOffset = leg3.transform.position - crawlerTransform.position;
            leg1.transform.position = Vector3.Lerp(leg1.transform.position, lastPos, Time.deltaTime);
            Quaternion leg3Rotation = Quaternion.LookRotation(crawlerTransform.position);
            leg2.transform.rotation = leg3Rotation;

            followOffset = leg4.transform.position - crawlerTransform.position;
            leg1.transform.position = Vector3.Lerp(leg1.transform.position, lastPos, Time.deltaTime);
            Quaternion leg4Rotation = Quaternion.LookRotation(crawlerTransform.position);
            leg2.transform.rotation = leg4Rotation;

        }
    }

}
