using System;


namespace R5T.O0014
{
    public static class Instances
    {
        public static ISolutionContextOperations SolutionContextOperations => O0014.SolutionContextOperations.Instance;
        public static L0039.F000.ISolutionContextOperator SolutionContextOperator => L0039.F000.SolutionContextOperator.Instance;
        public static L0045.F001.ISolutionNameOperator SolutionNameOperator => L0045.F001.SolutionNameOperator.Instance;
        public static O0015.ISolutionSpecificationGenerationOperations SolutionSpecificationGenerationOperations => O0015.SolutionSpecificationGenerationOperations.Instance;
    }
}