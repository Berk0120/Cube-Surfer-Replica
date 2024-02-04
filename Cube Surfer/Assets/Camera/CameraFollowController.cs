using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowController : MonoBehaviour
{

    [SerializeField] private Transform heroTransfrom;

    private Vector3 offset;

    private Vector3 newPosition;

    [SerializeField] private float lerpValue;


    
    
    
    
    void Start()
    {
        offset = transform.position - heroTransfrom.position;
    }

  
    void LateUpdate()
    {
        SetCameraSmoothFollow();
    }

    private void SetCameraSmoothFollow()
    {
        newPosition = Vector3.Lerp(transform.position, new Vector3(0f, heroTransfrom.position.y, heroTransfrom.position.z) +offset, lerpValue * Time.deltaTime);
        transform.position = newPosition;
    }
}
