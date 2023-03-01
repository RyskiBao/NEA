using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour
{
    public Transform target;

    public Vector3 offset;
    public float zoomSpeed = 4f;
    public float minZoom = 5f;
    public float maxZoom = 15f;

    public float pitch = 2f;

    public float HorizontalRotateSpeed = 100f;

    private float currentZoom = 10f;
    private float HorizontalRotateInput = 0f;

    void Update()
    {
        currentZoom -= Input.GetAxis("Mouse ScrollWheel") * zoomSpeed;
        currentZoom = Mathf.Clamp(currentZoom, minZoom, maxZoom);

        HorizontalRotateInput -= Input.GetAxis("Horizontal") * HorizontalRotateSpeed * Time.deltaTime;
    }

    void LateUpdate()
    {
        transform.position = target.position - offset * currentZoom;
        transform.LookAt(target.position+ Vector3.up * pitch);

        transform.RotateAround(target.position, Vector3.up, HorizontalRotateInput);
    }
}
