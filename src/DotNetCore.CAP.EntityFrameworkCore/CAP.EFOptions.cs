﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetCore.CAP
{
    public class EFOptions
    {
        public const string DefaultSchema = "cap";
        public const string DefaultMigrationsHistoryTableName = "__EFMigrationsHistory";

        /// <summary>
        /// Gets or sets the schema to use when creating database objects.
        /// Default is <see cref="DefaultSchema"/>.
        /// </summary>
        public string Schema { get; set; } = DefaultSchema;

        /// <summary>
        /// Gets or sets the migrations history table's schema.
        /// If this is null, <see cref="Schema"/> will be used.
        /// </summary>
        public string MigrationsHistoryTableSchema { get; set; }

        /// <summary>
        /// Gets or sets the migrations history table's name.
        /// Default is <see cref="DefaultMigrationsHistoryTableName"/>.
        /// </summary>
        public string MigrationsHistoryTableName { get; set; } = DefaultMigrationsHistoryTableName;

        public Type DbContextType { get; internal set; }
    }
}
