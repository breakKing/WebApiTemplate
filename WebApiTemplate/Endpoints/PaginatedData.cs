﻿namespace WebApiTemplate.Endpoints;

public sealed record PaginatedData<TItem>(List<TItem> Items, PaginationResponse Pagination);