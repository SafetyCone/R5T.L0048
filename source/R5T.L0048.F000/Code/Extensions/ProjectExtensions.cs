using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.CodeAnalysis;


namespace R5T.L0048.F000.Extensions
{
    public static class ProjectExtensions
    {
        public static IAsyncEnumerable<TSyntax> Get_AllSyntaxNodesOfType<TSyntax>(this Project project)
            where TSyntax : SyntaxNode
        {
            return Instances.ProjectOperator.Get_AllSyntaxNodesOfType<TSyntax>(project);
        }
    }
}
