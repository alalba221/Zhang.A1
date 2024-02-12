using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{

   // public Transform EnemyAim;
    public GameObject EneBullet;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(shootingBulletEnemy());
    }

    void Eshoot()
    {
        Component[] components = gameObject.GetComponentsInChildren<Component>(true);
        int ID1 = Random.Range(1, 9);
        int ID2 = Random.Range(1, 9);

        string ID1_STR = "ID" + ID1.ToString();
        string ID2_STR = "ID" + ID2.ToString();


        string ID1_AIM = "EAimGo" + ID1.ToString();
        string ID2_AIM = "EAimGo" + ID2.ToString();

        Instantiate(EneBullet, GameObject.Find(ID1_AIM).transform.position, GameObject.Find(ID1_AIM).transform.rotation);
    }

    IEnumerator shootingBulletEnemy()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            Eshoot();
        }

    }


}
