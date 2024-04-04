using Skove;

ForestArea forest1 = new ForestArea("Skovområde 1", 1000, 500, "Bøg");
ForestArea forest2 = new ForestArea("Skovområde 2", 2000, 1000, "Eg");

ForestAdministrator admin = new ForestAdministrator();
admin.AddAccess(forest1);

bool hasAccess = admin.HasAccessToArea(forest1);
Console.WriteLine($"Admin has access to forest1: {hasAccess}");

hasAccess = admin.HasAccessToArea(forest2);
Console.WriteLine($"Admin has access to forest2: {hasAccess}");

forest1.AddTrees(100);
Console.WriteLine($"Forest1 has {forest1.Trees} trees");