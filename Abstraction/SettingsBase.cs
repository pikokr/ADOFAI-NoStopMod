﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleJSON;

namespace NoStopMod.Abstraction
{
    interface SettingsBase
    {

        void Load(ref JSONNode json);

        void Save(ref JSONNode json);
        
    }
}
