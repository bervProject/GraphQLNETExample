using GraphQL.Types;

namespace GraphQLNetExample.Notes;

public class NotesSchema : Schema
{
    public NotesSchema(IServiceProvider serviceProvider) : base(serviceProvider)
    {
        Query = serviceProvider.GetRequiredService<NotesQuery>();
        Mutation = serviceProvider.GetRequiredService<NotesMutation>();
    }

}