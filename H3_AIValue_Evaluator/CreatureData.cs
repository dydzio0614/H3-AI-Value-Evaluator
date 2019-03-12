using Microsoft.ML.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H3_AIValue_Evaluator
{
    class CreatureData
    {
        [LoadColumn(0)]
        public float AttackPower;
        [LoadColumn(1)]
        public float DefensePower;
        [LoadColumn(2)]
        public float Speed;
        [LoadColumn(3)]
        public float AiValue;
    }
}
