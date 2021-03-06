using System.Collections.Immutable;
using HotChocolate.Language;
using HotChocolate.Types;

namespace HotChocolate.Resolvers
{
    public interface IResolverContext
    {
        // schema context
        ISchema Schema { get; }

        ObjectType ObjectType { get; }

        ObjectField Field { get; }

        // query context
        DocumentNode QueryDocument { get; }

        OperationDefinitionNode Operation { get; }

        FieldNode FieldSelection { get; }

        // execution context
        ImmutableStack<object> Source { get; } // parents

        Path Path { get; }

        T Parent<T>();

        T Argument<T>(string name);

        T Service<T>();
    }
}
