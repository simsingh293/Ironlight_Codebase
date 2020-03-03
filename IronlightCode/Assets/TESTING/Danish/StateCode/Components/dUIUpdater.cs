﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using brian.Components;
using Danish.Components;

namespace Danish.Components
{
	public class dUIUpdater
	{
		//Health variables
		public float maxHealth;
		public float currHealth;

		//Spirit variables
		public float maxSpirit;
		public float currSpirit;

		//UI for Health and Spirit
		public Image HPBar;
		public Image SPBar;

		public HealthComponent hpcomp;
		public SpiritComponent spcomp;

		// Start is called before the first frame update
		public void Init(HealthComponent hpcomponent, SpiritComponent spiritcomponent)
		{
			//reference to UI Images


			//reference to components
			hpcomp = hpcomponent;
			spcomp = spiritcomponent;

			//functions called
			UpdateMaxValues();

			ResetCurrentValues();
		}

		void UpdateMaxValues()
		{
			maxHealth = hpcomp.maxHealth;
			maxSpirit = spcomp.maxSpirit;

		}

		void ResetCurrentValues()
		{
			currHealth = maxHealth;
			currSpirit = maxSpirit;
		}

		// Update is called once per frame
		public void Tick(bool scrollup, bool scrolldown)
		{
			HPBar.fillAmount = currHealth / maxHealth;
			SPBar.fillAmount = currSpirit / maxSpirit;



		}

	}
}
