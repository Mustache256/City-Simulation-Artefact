using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Splines;

namespace CitySim
{
  public class SplineData : MonoBehaviour
  {
    public SplineContainer thisSpline;
    public List<SplineContainer> connectedSplines;

    // Start is called before the first frame update
    void Start()
    {
      if (thisSpline == null)
      {
        try
        {
          thisSpline = GetComponent<SplineContainer>();
        }
        catch
        {
          Debug.Log("[SPLINE DATA] SplineContainer is null and could not find SplineContainer component on " + name);
        }
      }
        
    }

    // Update is called once per frame
    void Update()
    {
      
    }
  }
}

