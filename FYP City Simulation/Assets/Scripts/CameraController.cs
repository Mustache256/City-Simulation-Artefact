using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
  public float moveSpeed;

  void Update()
  {
    if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
    {
      transform.position += new Vector3(0f, moveSpeed * Time.deltaTime, 0f);
    }

    if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
    {
      transform.position -= new Vector3(0f, moveSpeed * Time.deltaTime, 0f);
    }

    if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
    {
      transform.position -= new Vector3(moveSpeed * Time.deltaTime, 0f, 0f);
    }

    if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
    {
      transform.position += new Vector3(moveSpeed * Time.deltaTime, 0f, 0f);
    }
  }
}
