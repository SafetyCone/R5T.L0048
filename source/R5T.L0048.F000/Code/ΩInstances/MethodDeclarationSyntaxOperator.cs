using System;


namespace R5T.L0048.F000
{
    public class MethodDeclarationSyntaxOperator : IMethodDeclarationSyntaxOperator
    {
        #region Infrastructure

        public static IMethodDeclarationSyntaxOperator Instance { get; } = new MethodDeclarationSyntaxOperator();


        private MethodDeclarationSyntaxOperator()
        {
        }

        #endregion
    }
}
