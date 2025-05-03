using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;
    private Camera camera;

    [SerializeField] Vector2 center;
    [SerializeField] Vector2 mapSize;

    [SerializeField] 
    float cameraMoveSpeed;
    float height;
    float width;
    float zOffset;
    Vector3 cameraPosition;
    void Start()
    {
        if (target == null) return;

        camera = GetComponent<Camera>();

        zOffset = transform.position.z;
        height = camera.orthographicSize;
        width = height * Screen.width / Screen.height;
    }

    void LateUpdate()
    {
        CameraArea();
    }

    void CameraArea()
    {
        if (target == null) return;

        transform.position = Vector3.Lerp(transform.position,
                             target.position + cameraPosition,
                             Time.deltaTime * cameraMoveSpeed);

        float areaX = mapSize.x - width;
        float clampX = Mathf.Clamp(transform.position.x, -areaX + center.x, areaX + center.x);
        float areaY = mapSize.y - height;
        float clampY = Mathf.Clamp(transform.position.y, -areaY + center.y, areaY + center.y);

        transform.position = new Vector3(clampX, clampY, zOffset);

    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(center, mapSize * 2);
    }
}
