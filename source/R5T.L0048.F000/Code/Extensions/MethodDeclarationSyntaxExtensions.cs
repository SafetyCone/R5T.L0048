using System;

using Microsoft.CodeAnalysis.CSharp.Syntax;

using R5T.T0161.N1;


namespace R5T.L0048.F000.Extensions
{
    public static class MethodDeclarationSyntaxExtensions
    {
        public static bool Is_Named(this MethodDeclarationSyntax method,
            IMethodName methodName)
        {
            return Instances.MethodDeclarationSyntaxOperator.Is_Named(
                method,
                methodName);
        }
    }
}
