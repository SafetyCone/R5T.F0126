using System;

using R5T.F0000.Extensions;
using R5T.T0132;
using R5T.T0175;
using R5T.T0192;
using R5T.T0192.Extensions;


namespace R5T.F0126
{
    [FunctionalityMarker]
    public partial interface IDirectoryPathOperator : IFunctionalityMarker
    {
        public ILocalRunSpecificDirectoryPath Get_LocalRunSpecificParentDirectoryPath(IApplicationName applicationName)
        {
            var output = $@"C:\Temp\Files\{applicationName}\Runs\".ToLocalRunSpecificDirectoryPath();
            return output;
        }

        public ILocalRunSpecificDirectoryPath Get_LocalRunSpecificDirectoryPath(
            IApplicationName applicationName,
            ITimestamp start)
        {
            var localRunSpecificParentDirectoryPath = this.Get_LocalRunSpecificParentDirectoryPath(applicationName);

            var dateSpecificDirectoryName = start.Value.ToYYYYMMDD_HHMMSS();

            var output = Instances.PathOperator.GetDirectoryPath(
                localRunSpecificParentDirectoryPath.Value,
                dateSpecificDirectoryName)
                .ToLocalRunSpecificDirectoryPath();

            return output;
        }
    }
}
