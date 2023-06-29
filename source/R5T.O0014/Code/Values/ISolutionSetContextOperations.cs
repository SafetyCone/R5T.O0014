using System;
using System.Threading.Tasks;

using R5T.F0000;
using R5T.L0031.Extensions;
using R5T.L0039.T000;
using R5T.T0131;
using R5T.T0172;
using R5T.T0197;
using R5T.T0198;
using R5T.T0201;


namespace R5T.O0014
{
    [ValuesMarker]
    public partial interface ISolutionSetContextOperations : IValuesMarker,
        O0013.ISolutionSetContextOperations
    {
        public Func<ISolutionSetContext, Task> Create_BlazorClientAndServer(
            ISolutionDirectoryPath solutionDirectoryPath,
            IsSet<IRepositoryUrl> repositoryUrl,
            IUnadjustedLibraryName libraryName,
            bool isPrivate,
            out BlazorClientWithWebServerCreationOutput creationResult)
        {
            var solutionSpecification = Instances.SolutionSpecificationGenerationOperations.Get_WebBlazorClientAndServerSolutionSpecification(
                libraryName,
                isPrivate);

            var creationResult_Internal = new BlazorClientWithWebServerCreationOutput();

            creationResult = creationResult_Internal;

            return solutionSetContext =>
            {
                return solutionSetContext.Run(
                    this.Create_BlazorClientAndServer(
                        solutionDirectoryPath,
                        creationResult_Internal,
                        repositoryUrl,
                        solutionSpecification.SolutionName,
                        solutionSpecification.BlazorClientProjectSpecification,
                        solutionSpecification.ServerProjectSpecification
                    )
                );
            };
        }
    }
}
