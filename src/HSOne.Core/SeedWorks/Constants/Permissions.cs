﻿using System.ComponentModel;

namespace HSOne.Core.SeedWorks.Constants
{
    public class Permissions
    {
        public static class Dashboard
        {
            [Description("View Dashboard")]
            public const string View = "Permissions.Dashboard.View";
        }

        public static class Roles
        {
            [Description("View Roles")]
            public const string View = "Permissions.Roles.View";

            [Description("Create Roles")]
            public const string Create = "Permissions.Roles.Create";

            [Description("Edit Roles")]
            public const string Edit = "Permissions.Roles.Edit";

            [Description("Delete Roles")]
            public const string Delete = "Permissions.Roles.Delete";
        }

        public static class Users
        {
            [Description("View Users")]
            public const string View = "Permissions.Users.View";

            [Description("Create Users")]
            public const string Create = "Permissions.Users.Create";

            [Description("Edit Users")]
            public const string Edit = "Permissions.Users.Edit";

            [Description("Delete Users")]
            public const string Delete = "Permissions.Users.Delete";
        }

        public static class Posts
        {
            [Description("View Posts")]
            public const string View = "Permissions.Posts.View";

            [Description("Create Posts")]
            public const string Create = "Permissions.Posts.Create";

            [Description("Edit Posts")]
            public const string Edit = "Permissions.Posts.Edit";

            [Description("Delete Posts")]
            public const string Delete = "Permissions.Posts.Delete";
        }

        public static class Series
        {
            [Description("View Series")]
            public const string View = "Permissions.Series.View";

            [Description("Create Series")]
            public const string Create = "Permissions.Series.Create";

            [Description("Edit Series")]
            public const string Edit = "Permissions.Series.Edit";

            [Description("Delete Series")]
            public const string Delete = "Permissions.Series.Delete";
        }
    }
}