using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSphere : MonoBehaviour
{

    private Vector3 target;
    private float duration;
    public Tweener tweener;
    // Start is called before the first frame update
    void Start()
    {
        target = new Vector3(-3.0f, 1.0f, 0.0f);
        duration = 1.5f;

    }

    // Update is called once per frame
    void Update(){
          if (!tweener.TweenExists(gameObject.transform))
          {
          //flip target in the x-axis, so if it was negative, make it positive (e.g. -3 becomes +3, or +3 becomes -3)
          target = new Vector3( ((-1) * target.x), target.y, target.z);
          //Add a new tween with the spheres transform, current transform position, target, and the duration variable
            //divided by the SpeedModifier property in SpeedManager.
          new Tween(this.transform, this.transform.position, target, Time.time, duration/SpeedManager.SpeedModifier);
        }
    }
}
