﻿namespace Shared.Pagination
{
    public class PaginatedResult<TEntity>(int pageIndex, int pageSize, long Count, IEnumerable<TEntity> data)
        where TEntity : class
    {
        public int PageIndex { get; set; } = pageIndex;
        public int PageSize { get; set; } = pageSize;
        public long Count { get; set; } = Count;
        public IEnumerable<TEntity> Data { get; set; } = data;
    }
}
