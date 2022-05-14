using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentManager : MonoBehaviour
{
    GameObject[] agents;
    // Use this for initialization
    void Start()
    {
        //Aqui o GameObject vai buscar por objetos com a tag ai 
        agents = GameObject.FindGameObjectsWithTag("ai");
    }
    // Update is called once per frame
    void Update()
    {
        //Aqui diz que ao clicar com o botao principal do mouse o objeto ira fazer uma ação 
        if (Input.GetMouseButtonDown(0))
        {
            //obtendo informações
            RaycastHit hit;
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100))
            {
                foreach (GameObject a in agents)
                    
                    a.GetComponent<AIControl>().agent.SetDestination(hit.point);
            }
        }
    }
}
