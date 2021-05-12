using Marten.Internal;
using Marten.Linq;
using Marten.Linq.SqlGeneration;
using Marten.Schema;
using Marten.Storage;

namespace Marten.Transforms
{
    internal interface ISelectableOperator
    {
        SelectorStatement ModifyStatement(SelectorStatement statement, IMartenSession session);
    }
}
