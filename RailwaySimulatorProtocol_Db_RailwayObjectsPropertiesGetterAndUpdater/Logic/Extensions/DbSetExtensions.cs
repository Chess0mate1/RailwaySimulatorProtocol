using System.Linq;
using System.Collections.Generic;
using static System.Math;

using Microsoft.EntityFrameworkCore;

namespace DemoProtocol_Db_RailwayObjectsPropertiesGetterAndUpdater.Logic.Extensions
{
    internal static class DbSetExtensions
    {
        public static void Modify<T>(this DbSet<T> receiver, IEnumerable<T> source)
            where T : class
        {
            var receiverLength = receiver.Count();
            var sourceLength = source.Count();

            if (IsNeedToUpdate())
                Update();

            if (IsNeedToAdd())
                Add();
            else if (IsNeedToRemove())
                Remove();


            bool IsNeedToUpdate()
                => receiverLength != 0 || sourceLength != 0;

            bool IsNeedToAdd()
                => receiverLength < sourceLength;

            bool IsNeedToRemove()
                => receiverLength > sourceLength;

            void Update()
            {
                var minLength = Min(receiverLength, sourceLength);

                receiver.BulkUpdate(
                    source.Take(minLength)
                );
            }
            void Add()
            {
                receiver.BulkInsert(
                    source.Skip(receiverLength)
                );
            };
            void Remove()
            {
                receiver.BulkDelete(
                    receiver.Skip(sourceLength)
                );
            }
        }
    }
}
