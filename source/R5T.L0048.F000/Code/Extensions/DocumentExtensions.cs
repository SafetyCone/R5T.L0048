using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;


namespace R5T.L0048.F000.Extensions
{
    public static class DocumentExtensions
    {
        public static Task<CompilationUnitSyntax> Get_CompilationUnit(this Document document)
        {
            return Instances.DocumentOperator.Get_CompilationUnit(document);
        }
    }
}
