using System;
using System.Threading.Tasks;

using R5T.T0131;
using R5T.T0159;
using R5T.T0172;
using R5T.T0187;


namespace R5T.O0014
{
    [ValuesMarker]
    public partial interface ISolutionGenerationOperations : IValuesMarker
    {
        /// <summary>
        /// Create an empty solution.
        /// </summary>
        public async Task<SolutionCreationResult> Create_EmptySolution(
            ISolutionDirectoryPath solutionDirectoryPath,
            ISolutionName solutionName,
            bool isPrivate,
            ITextOutput textOutput)
        {
            var adjustedSolutionName = Instances.SolutionNameOperator.AdjustRepositoryName_ForPrivacy(
               solutionName,
               isPrivate);

            textOutput.WriteInformation("Creating empty solution...");

            textOutput.WriteInformation($"{adjustedSolutionName}: solution name");

            var output = new SolutionCreationResult();

            await Instances.SolutionContextOperator.In_SolutionContext(
                solutionDirectoryPath,
                adjustedSolutionName,
                textOutput,
                Instances.SolutionContextOperations.Create_Solution(
                    solutionFilePath =>
                    {
                        output.SolutionFilePath = solutionFilePath;
                    }));

            textOutput.WriteInformation("Created empty solution.");

            textOutput.WriteInformation($"Solution file path:\n\t{output.SolutionFilePath}");

            return output;
        }
    }
}
