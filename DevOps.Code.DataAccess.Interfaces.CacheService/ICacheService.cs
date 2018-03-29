// Copyright © Christopher Dorst. All rights reserved.
// Licensed under the GNU General Public License, Version 3.0. See the LICENSE document in the repository root for license information.

namespace DevOps.Code.DataAccess.Interfaces.CacheService
{
    /// <summary>Interface for a generic data-access cache</summary>
    public interface ICacheService<TEntity> where TEntity : class
    {
        /// <summary>Returns the entity given a key value</summary>
        Task<TEntity> FindAsync(string key);

        /// <summary>Removes the entity at the given a key value from the cache</summary>
        Task RemoveAsync(string key);

        /// <summary>Saves the entity to the cache</summary>
        Task SaveAsync(string key, TEntity entity);
    }
}
