using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Screamer
{
    public class ScreamCollider
    {
        public void OnTriggerEnter(Collider other)
        {
            if (other.attachedRigidbody == null || !other.CompareTag("Untagged") || other.isTrigger)
            {
                
            }
        }
    }
}
