﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineKraft.DbLib.Models
{
    internal class Topic : IdentityObject
    {
        public string Name { get; set; }

        public List<Question> Questions { get; set; }

        public Topic(string name)
        {
            Name = name;
            Questions = new List<Question>();
        }
    }
}
