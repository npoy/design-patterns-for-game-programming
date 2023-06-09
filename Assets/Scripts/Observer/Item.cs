using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
    public Event dropped;
    public Image icon;
    public Event pickup;

    // Start is called before the first frame update
    void Start()
    {
        dropped.Ocurred(this.gameObject);
    }

    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "Player") {
            pickup.Ocurred(this.gameObject);
            this.gameObject.GetComponent<MeshRenderer>().enabled = false;
            this.gameObject.GetComponent<Collider>().enabled = false;
            Destroy(this.gameObject, 5);
        }
    }
}
