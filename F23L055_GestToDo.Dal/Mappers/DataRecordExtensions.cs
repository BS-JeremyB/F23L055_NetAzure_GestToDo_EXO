using F23L055_GestToDo.Dal.Entities;
using System.Data;

namespace F23L055_GestToDo.Dal.Mappers
{
    internal static class DataRecordExtensions
    {
        internal static Tache ToTache(this IDataRecord record)
        {
            return new Tache()
            {
                Id = (int)record["Id"],
                Titre = (string)record["Titre"],
                Finalise = (bool)record["Finalise"]
            };
        }
    }
}
