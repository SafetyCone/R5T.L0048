using System;


namespace R5T.L0048.F000
{
    public class DocumentOperator : IDocumentOperator
    {
        #region Infrastructure

        public static IDocumentOperator Instance { get; } = new DocumentOperator();


        private DocumentOperator()
        {
        }

        #endregion
    }
}
