using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
  public float moveSpeed;
 
  float shiftMoveSpeed;
  float currentMoveSpeed;

  private void Start()
  {
    currentMoveSpeed = moveSpeed;
    shiftMoveSpeed = moveSpeed * 3;
  }

  void Update()
  {
    if(Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
    {
      currentMoveSpeed = shiftMoveSpeed; 
    }
    else if(currentMoveSpeed != moveSpeed)
    {
      currentMoveSpeed = moveSpeed;
    }

    if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
    {
      transform.position += new Vector3(0f, 0f , currentMoveSpeed * Time.deltaTime);
    }

    if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
    {
      transform.position -= new Vector3(0f, 0f , currentMoveSpeed * Time.deltaTime);
    }

    if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
    {
      transform.position -= new Vector3(currentMoveSpeed * Time.deltaTime, 0f, 0f);
    }

    if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
    {
      transform.position += new Vector3(currentMoveSpeed * Time.deltaTime, 0f, 0f);
    }

    if (Input.GetKey(KeyCode.Q) && transform.position.y > 5)
    {
      transform.position -= new Vector3(0f, currentMoveSpeed * Time.deltaTime, 0f);
    }

    if (Input.GetKey(KeyCode.E) && transform.position.y < 60)
    {
      transform.position += new Vector3(0f, currentMoveSpeed * Time.deltaTime, 0f);
    }
  }
}
