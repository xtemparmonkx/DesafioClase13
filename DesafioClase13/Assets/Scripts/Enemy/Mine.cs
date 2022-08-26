using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mine : MonoBehaviour
{
    [SerializeField] private Transform detectPoint;

    [SerializeField]
    public GameObject Player;
    private float rayDistance = 100f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        MineRaycast();
        Debug.DrawRay(detectPoint.position, detectPoint.TransformDirection(Vector3.up) * 100, Color.red);
    }

    private void MineRaycast()
    {
        RaycastHit hit;
        if (Physics.Raycast(detectPoint.position, detectPoint.TransformDirection(Vector3.up), out hit, rayDistance))
        {
            if (hit.transform.CompareTag("Player"))
            {
                Debug.Log("COLLISION CON PLAYER");
                Destroy(Player);
            }
        }
    }
}
