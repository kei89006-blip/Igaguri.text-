using UnityEngine;

public class IgaguriController : MonoBehaviour
{
    public void Shoot(Vector3 dir)//どの方向に打ち出すのか？
    {//↓この物体についている「物理エンジン（Rigidbody）」を見つけて       
        GetComponent<Rigidbody>().AddForce(dir);// 指定された方向（dir）に「力（AddForce）」を加える
    }

    void OnConllisionEnter(Collision collision)
    {
        GetComponent<Rigidbody>().isKinematic = true;
    }
    void Start()//ゲーム開始時　オブジェクトの作成　一回だけ
    {
        Application.targetFrameRate =60;//ゲームの滑らかさを秒間60フレームに固定
        Shoot(new Vector3(0,200,2000));//引数（dir）には、(右に0, 上に200, 奥に2000) のベクトル
    }


}
