using System;

using Microsoft.CodeAnalysis.CSharp.Syntax;

using R5T.T0132;
using R5T.T0161.N1;


namespace R5T.L0048.F000
{
    [FunctionalityMarker]
    public partial interface IMethodDeclarationSyntaxOperator : IFunctionalityMarker
    {
        public bool Is_Named(
            MethodDeclarationSyntax method,
            IMethodName methodName)
        {
            var output = method.Identifier.ValueText == methodName.Value;
            return output;
        }
    }
}
