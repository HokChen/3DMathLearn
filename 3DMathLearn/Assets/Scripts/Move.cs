using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

    private void Update()
    {
        Vector3 worldPos = transform.position;

        //世界坐标转成视口坐标时，不用想屏幕坐标那样要特意去设定Z的值，视口坐标的转换相当于只
        //把x和y投影到视口上了
        Vector3 viewPos = Camera.main.WorldToViewportPoint(worldPos);
        if (viewPos.x>=1)
        {
            return;
        }
        transform.Translate(Vector3.right * 2 * Time.deltaTime);
    }
}
