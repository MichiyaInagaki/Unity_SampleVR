using UnityEngine;
using System.Collections;

public class CursolController : MonoBehaviour
{

    void Update()
    {
        //Ray(レイの原点，飛ばす方向)
        Ray ray = new Ray(Camera.main.transform.position,
            Camera.main.transform.rotation * Vector3.forward);

        //Rayの可視化（Sceneビューのみ見れる）
        int distance = 10;
        Debug.DrawLine(ray.origin, ray.direction * distance, Color.red);

        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            //Groundにヒットしたらカーソル動かす
            if (hit.transform.gameObject.name == "Ground")
            {
                transform.position = hit.point + new Vector3(0, 0.1f, 0);
            }
        }
    }
}