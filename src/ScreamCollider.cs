using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Screamer
{
    public class ScreamCollider
    {
        private static Collider[] colArray = UnityEngine.Object.FindObjectsOfType<Collider>();
        private static Collider col;
        private static ScreamCollider _trigger = new ScreamCollider();
        public static Boolean colContact;

        public static ScreamCollider Trigger
        {
            get
            {
                return _trigger;
            }
        }
        public void OnTriggerEnter(Collider other)
        {
            if (other.attachedRigidbody == null && other.CompareTag("Screamer") && other.isTrigger)
            {
                colContact = true;
            }
        }
        public void OnTriggerExit(Collider other)
        {
            colContact = false;
        }

        public static Collider GetCollider(string name)
        {

            List<Collider> cols = new List<Collider>(colArray);
            col = cols.Find(n => n.name == Scream.triggerName);
            return col;

        }
    }
}
