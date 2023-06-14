using System;


namespace R5T.O0014
{
    public class SolutionSetContextOperations : ISolutionSetContextOperations
    {
        #region Infrastructure

        public static ISolutionSetContextOperations Instance { get; } = new SolutionSetContextOperations();


        private SolutionSetContextOperations()
        {
        }

        #endregion
    }
}
