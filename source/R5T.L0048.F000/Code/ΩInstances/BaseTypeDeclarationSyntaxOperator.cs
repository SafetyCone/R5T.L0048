using System;


namespace R5T.L0048.F000
{
    public class BaseTypeDeclarationSyntaxOperator : IBaseTypeDeclarationSyntaxOperator
    {
        #region Infrastructure

        public static IBaseTypeDeclarationSyntaxOperator Instance { get; } = new BaseTypeDeclarationSyntaxOperator();


        private BaseTypeDeclarationSyntaxOperator()
        {
        }

        #endregion
    }
}
