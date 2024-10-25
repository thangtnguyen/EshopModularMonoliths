﻿global using Shared.DDD;
global using Catalog.Products.Models;
global using Catalog.Products.Events;
global using Microsoft.EntityFrameworkCore;
global using System.Reflection;
global using Microsoft.EntityFrameworkCore.Metadata.Builders;
global using Catalog.Data;
global using Catalog.Data.Seed;
global using Shared.Data;
global using Shared.Data.Seed;
global using Catalog.Contracts.Products.Dtos;
global using Shared.Contracts.CQRS;
global using Mapster;
global using MediatR;
global using Microsoft.Extensions.Logging;
global using Carter;
global using Microsoft.AspNetCore.Builder;
global using Microsoft.AspNetCore.Http;
global using Microsoft.AspNetCore.Routing;
global using FluentValidation;
global using Microsoft.EntityFrameworkCore.Diagnostics;
global using Microsoft.Extensions.Configuration;
global using Microsoft.Extensions.DependencyInjection;
global using Shared.Data.Interceptors;
global using Catalog.Contracts.Products.Features.GetProductById;