using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedManager : MonoBehaviour
{
    private static float speedModifier = 1.0f;
    // Start is called before the first frame update

    //enum GameSpeed {Slow, Fast};
    //  int Slow = 1;
    //  int Fast = 3;

    //private static GameSpeed currentSpeedState = slow;

    public static float SpeedModifier {
      get {
        return speedModifier;
      }

    }

    /*public static CurrentSpeedState {
      get {
        return currentSpeedState;
      }
      set {
        currentSpeedState =
      }
    }*/
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

}
