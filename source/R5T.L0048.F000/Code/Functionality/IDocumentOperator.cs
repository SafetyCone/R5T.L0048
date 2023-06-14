using System;
using System.Threading.Tasks;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

using R5T.T0132;


namespace R5T.L0048.F000
{
    [FunctionalityMarker]
    public partial interface IDocumentOperator : IFunctionalityMarker
    {
        public async Task<CompilationUnitSyntax> Get_CompilationUnit(Document document)
        {
            var syntaxRoot = await document.GetSyntaxRootAsync();

            var compilationUnit = syntaxRoot as CompilationUnitSyntax;
            return compilationUnit;
        }
    }
}
