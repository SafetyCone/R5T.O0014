using System;


namespace R5T.O0014
{
    public class SolutionGenerationOperations : ISolutionGenerationOperations
    {
        #region Infrastructure

        public static ISolutionGenerationOperations Instance { get; } = new SolutionGenerationOperations();


        private SolutionGenerationOperations()
        {
        }

        #endregion
    }
}
