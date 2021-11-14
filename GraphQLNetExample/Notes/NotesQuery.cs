
using GraphQL.Types;
using GraphQLNetExample.EntityFramework;

namespace GraphQLNetExample.Notes;

public class NotesQuery : ObjectGraphType
{
    public NotesQuery()
    {
        Field<ListGraphType<NoteType>>("notes", resolve: context => new List<Note> {
          new Note { Id = Guid.NewGuid(), Message = "Hello World!" },
          new Note { Id = Guid.NewGuid(), Message = "Hello World! How are you?" }
        });
        Field<ListGraphType<NoteType>>("notesFromEF", resolve: context =>
        {
            var notesContext = context.RequestServices.GetRequiredService<NotesContext>();
            return notesContext.Notes.ToList();
        }
        );
    }

}