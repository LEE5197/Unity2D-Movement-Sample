using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityCore : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Movement playerMovement = other.GetComponent<Movement>();

            if (playerMovement != null)
            {
                playerMovement.numberOfGravityCore++;
                Debug.Log("�׷���Ƽ �ھ� ȹ��! ���� ����: " + playerMovement.numberOfGravityCore);
            }

            gameObject.SetActive(false);
        }
    }

}
