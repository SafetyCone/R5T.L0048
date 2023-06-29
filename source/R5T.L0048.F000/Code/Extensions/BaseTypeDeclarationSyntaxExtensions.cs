using System;

using Microsoft.CodeAnalysis.CSharp.Syntax;

using R5T.T0161.N1;


namespace R5T.L0048.F000.Extensions
{
    public static class BaseTypeDeclarationSyntaxExtensions
    {
        public static bool Is_Named(this BaseTypeDeclarationSyntax baseType,
            ITypeName typeName)
        {
            return Instances.BaseTypeDeclarationSyntaxOperator.Is_Named(
                baseType,
                typeName);
        }
    }
}
