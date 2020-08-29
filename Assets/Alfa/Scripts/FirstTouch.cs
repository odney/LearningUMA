using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstTouch : MonoBehaviour
{

    private static Dictionary<int, Touch> toutchStore = new Dictionary<int, Touch>();

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount > 0) {

            for(int tcIdx = 0; tcIdx < Input.touches.Length; tcIdx++) {
                Touch touch = Input.touches[tcIdx];
                switch (touch.phase) {
                    case TouchPhase.Began:
                        toutchStore[tcIdx] = touch;
                        break;
                    case TouchPhase.Ended:
                    case TouchPhase.Canceled:
                        toutchStore.Remove(tcIdx);
                        break;
                    case TouchPhase.Moved:
                        if (toutchStore.ContainsKey(tcIdx)) {
                            // DO MOVE/ TURN
                        }
                        break;
                }
            }

        }
    }
}
