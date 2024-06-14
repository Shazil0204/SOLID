﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Help_Lone.Interface
{
	internal interface ICharacter
	{
		string Name { get; set; }
		int Age { get; set; }
		void Die();
        void Fight();
	}
}
