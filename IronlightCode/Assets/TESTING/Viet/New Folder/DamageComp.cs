﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using brian.Components;

namespace Viet.Components
{


    public class DamageComp
    {
        public HealthEffector healthEffector = null;
        public float damageValue;
        public float CritDmg;

        private GameObject attacker = null; //attacker currently empty

        // Initializes damage component, similar to Awake/Start function
        public void Init(float value)
        {
            damageValue = value;
        }

        public void UpdateValues(float value)
        {
            damageValue = value;
        }

        public void DoIt()
        {
            processDmg();
            resetValue();
        }

        void processDmg() // Access the health value of the defender and deal dmg or recover hp by the attacker dmg or heal by amount of heal source
        {
            healthEffector.affect(false, damageValue, CritDmg);           
        }

        void resetValue() // aftter take damage from dmg component, reset the dmg value receive and attacker value
        {
            damageValue = 0;
            attacker = null;
        }
    }
}
