using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_01 : MonoBehaviour {

    private void Start()
    {
        //基于以下两个转换坐标的方法，这里声明的变量要根据使用情况去确定是世界坐标还是本地坐标
        //Vector3 pos = new Vector3(5, 4, 0);

        ////从世界坐标转换成本地坐标，传入的参数此时默认为世界坐标
        //Vector3 worldToLocal = transform.InverseTransformPoint(pos);

        ////从本地坐标转换成世界坐标，传入的参数此时默认为本地坐标
        //Vector3 localToWorld = transform.TransformPoint(worldToLocal);



        //Debug.Log(string.Format("该物体的世界坐标为{0}，本地坐标为{1}", transform.position, transform.localPosition));
        //Debug.Log(string.Format("P点坐标为{0}，P点坐标转换成本地坐标是：{1}； P点坐标转换成世界坐标是{2}", pos, worldToLocal, localToWorld));

        //Vector3 pos = Camera.main.WorldToScreenPoint(transform.position);
        //Debug.Log(pos);

        Vector3 a = new Vector3(1, 2, 3);
        Vector3 b = new Vector3(-2, -2, 3);
        Vector3 cross = Vector3.Cross(a,b);
        
        Debug.Log(cross);
        Debug.Log(cross.magnitude);
    }

    private void Update()
    {
        /*如果这个方法是Space.Self话，那么用transform.forward就是：如果物体的本地坐标没有旋转的话
         * 前进方向是Z轴的正方向；如果本地坐标有旋转K°的话，前进方向则是旋转了K°后的Z轴的正方向再旋转K°
         * */
        /*如果这个方法是Space.World的话，那么用transform.forward就是：不管物体本地坐标如何旋转，
         * 前进方向永远是本地的Z轴正方向
         * */

        /*如果这个方法是Space.Self的话，那么用Vector3.forward就是：不管物体本地坐标旋转，前进方向
         * 永远是本地的Z轴正方向
         * */
        /*如果这个方法是Space.World的话，那么用Vector3.forward就是：不管物体本地坐标如何旋转，
         * 前进方向永远是世界坐标的Z轴正方向
         * */



        //transform.Translate(Vector3.forward * Time.deltaTime, Space.World);

        //Vector3 worldToScreen = Camera.main.WorldToScreenPoint(transform.position);

        //Vector3 pos = Input.mousePosition;
        //Vector3 screenToWorld = Camera.main.ScreenToWorldPoint(new Vector3(pos.x,pos.y,10));
        //Debug.Log(screenToWorld);


        
    }
}
