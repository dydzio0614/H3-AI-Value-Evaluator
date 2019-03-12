using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.DataView;
using Microsoft.ML;
using Microsoft.ML.Data;

namespace H3_AIValue_Evaluator
{
    public partial class Form1 : Form
    {
        MLContext context { get; set; }
        ITransformer savedModel { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void TrainButton_Click(object sender, EventArgs e)
        {
            context = new MLContext();
            IDataView trainingDataView = context.Data.LoadFromTextFile<CreatureData>(path: "Crtraits_traindata.csv", hasHeader: false, separatorChar: '\t');

            var pipeline = context.Transforms.CopyColumns(inputColumnName: "AiValue", outputColumnName: "Label")
                .Append(context.Transforms.Concatenate("Features", "AttackPower", "DefensePower", "Speed"))
                .Append(context.Regression.Trainers.PoissonRegression());

            var model = pipeline.Fit(trainingDataView);
            savedModel = model;


            IDataView testDataView = context.Data.LoadFromTextFile<CreatureData>(path: "Crtraits_testdata.csv", hasHeader: false, separatorChar: '\t');
            var predictions = model.Transform(trainingDataView);
            var metrics = context.Regression.Evaluate(predictions);
            MessageBox.Show("RMS (the lower score the better): " + metrics.Rms + Environment.NewLine + "RSquared (closer to 1 = better): " + metrics.RSquared);
        }

        private void AuthorLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/dydzio0614");
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            var predictionEngine = savedModel.CreatePredictionEngine<CreatureData, CreatureValuePrediction>(context);
            var creature = new CreatureData()
            {
                AttackPower = (float)(mindmgTextbox.Value + maxdmgTextbox.Value) / 2f * (1 + 0.05f * (float)attackTextbox.Value),
                DefensePower = (float)hitpointsTextbox.Value * (1 + 0.05f * (float)defenseTextbox.Value),
                Speed = (float)speedTextbox.Value               
            };

            var output = predictionEngine.Predict(creature);
            outputTextbox.Text = output.PredictedAiValue.ToString();
        }
    }
}
