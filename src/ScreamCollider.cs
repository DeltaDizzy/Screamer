using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Screamer
{
    public class ScreamCollider
    {
        private static Collider[] colArray = UnityEngine.Object.FindObjectsOfType<Collider>(); //Fill array with all colliders
        private static Collider col; //Collider reference
        private static ScreamCollider _trigger = new ScreamCollider(); //accessor
        public static Boolean colContact; //contact var

        public static ScreamCollider Trigger //acessor
        {
            get
            {
                return _trigger;
            }
        }
        public void OnTriggerEnter(Collider other //Called when trigger is entered
        {
            if (other.CompareTag("Screamer") && other.isTrigger) //if collider is tagged "Screamer" and is a trigger
            {
                colContact = true; //we are contacting the trigger
            }
        }
        public void OnTriggerExit(Collider other) //collider exit
        {
            colContact = false; //we are not touching the collider
        }
        public static Collider GetCollider(string name) //Get collider of a given name
        {
            List<Collider> cols = new List<Collider>(colArray); //list of colliders, same as array
            col = cols.Find(n => n.name == Scream.triggerName); //find collider with given name
            return col; //return the collider
        }
    }
}
