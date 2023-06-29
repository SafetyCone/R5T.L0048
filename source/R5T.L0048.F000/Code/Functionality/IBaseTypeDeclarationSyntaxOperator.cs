using System;

using Microsoft.CodeAnalysis.CSharp.Syntax;

using R5T.T0132;
using R5T.T0161.N1;


namespace R5T.L0048.F000
{
    [FunctionalityMarker]
    public partial interface IBaseTypeDeclarationSyntaxOperator : IFunctionalityMarker
    {
        public bool Is_Named(
            BaseTypeDeclarationSyntax baseType,
            ITypeName typeName)
        {
            var output = baseType.Identifier.ValueText == typeName.Value;
            return output;
        }
    }
}
