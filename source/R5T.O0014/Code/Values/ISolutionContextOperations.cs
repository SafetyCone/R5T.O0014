using System;
using System.Threading.Tasks;

using R5T.F0000;
using R5T.L0031.Extensions;
using R5T.L0039.T000;
using R5T.T0131;
using R5T.T0197;
using R5T.T0198;
using R5T.T0201;


namespace R5T.O0014
{
    [ValuesMarker]
    public partial interface ISolutionContextOperations : IValuesMarker,
        O0013.ISolutionContextOperations
    {
        public Func<ISolutionContext, Task> Create_WebLibraryForBlazorWithConstructionServerAndClient(
            IUnadjustedLibraryName libraryName,
            ILibraryDescription libraryDescription,
            bool isPrivate,
            IsSet<IRepositoryUrl> repositoryUrl,
            out WebLibraryWithConstructionCreationOutput creationOutput)
        {
            var solutionSpecification = Instances.SolutionSpecificationGenerationOperations.Get_WebLibraryWithConstructionSolutionSpecification(
                libraryName,
                libraryDescription,
                isPrivate);

            var creationOutput_Internal = new WebLibraryWithConstructionCreationOutput();

            creationOutput = creationOutput_Internal;

            return solutionSetContext =>
            {
                return solutionSetContext.Run(
                    this.Create_WebLibraryForBlazorWithConstructionServerAndClient(
                        solutionSpecification,
                        repositoryUrl,
                        creationOutput_Internal
                    )
                );
            };
        }
    }
}
