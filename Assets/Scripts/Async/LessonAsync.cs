using System;
using System.Threading.Tasks;
using Unity.VisualScripting;
using UnityEngine;

public class LessonAsync : MonoBehaviour
{
    [SerializeField] GameObject[] objects;
    bool canAttack =true;



    // Update is called once per frame
    async void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            foreach (GameObject item in objects)
            {
               await AnimateObject(item);
            }
            Debug.Log(" finished.");
        }

    }

    
    private async Task AnimateObject(GameObject item)
    {
        Animator animaator = item.GetComponent<Animator>();
        animaator.Play("CubeAnimation");
        await Task.Delay(1000);

        while(animaator.GetCurrentAnimatorStateInfo(0).normalizedTime< 1)
        {
            Debug.Log("not finished yet");
            await Task.Yield();
        }
    }

    
    /*
    async void Update()
    {
        if(Input.GetMouseButton(0) && canAttack)
        {
            canAttack = false;
           await Cooldown();
        }
        
    }

    private async Task Cooldown()
    {
        Debug.Log("Cool down started");
        await Task.Delay(2000);
        Debug.Log("Cool down ended");

    }*/
}
