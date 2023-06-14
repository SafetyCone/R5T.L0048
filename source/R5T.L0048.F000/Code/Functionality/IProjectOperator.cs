using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Microsoft.CodeAnalysis;

using R5T.T0132;

using R5T.L0048.F000.Extensions;
using System.Linq;

namespace R5T.L0048.F000
{
    [FunctionalityMarker]
    public partial interface IProjectOperator : IFunctionalityMarker
    {
        public async IAsyncEnumerable<TSyntax> Get_AllSyntaxNodesOfType<TSyntax>(
            Project project)
            where TSyntax : SyntaxNode
        {
            foreach (var document in project.Documents)
            {
                var compilationUnit = await document.Get_CompilationUnit();

                var output = compilationUnit.DescendantNodes()
                    .OfType<TSyntax>()
                    ;

                foreach (var node in output)
                {
                    yield return node;
                }
            }
        }
    }
}
