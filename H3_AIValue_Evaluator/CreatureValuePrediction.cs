using Microsoft.ML.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H3_AIValue_Evaluator
{
    class CreatureValuePrediction
    {
        [ColumnName("Score")]
        public float PredictedAiValue;
    }
}
