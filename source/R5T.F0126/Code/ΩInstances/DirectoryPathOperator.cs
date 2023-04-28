using System;


namespace R5T.F0126
{
    public class DirectoryPathOperator : IDirectoryPathOperator
    {
        #region Infrastructure

        public static IDirectoryPathOperator Instance { get; } = new DirectoryPathOperator();


        private DirectoryPathOperator()
        {
        }

        #endregion
    }
}
