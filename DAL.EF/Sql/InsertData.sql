INSERT INTO "Users" ("Id", "DiagnosticId")
VALUES (1, null);

INSERT INTO "Diagnostics" ("Id", "UserId")
VALUES (1, 1);

INSERT INTO "Nutrients" ("Id", "Name", "Measure")
VALUES
(1, 'Vitamin C', 'mg'),
(2, 'Iron', 'mg'),
(3, 'Calcium', 'mg');

INSERT INTO "Products" ("Id", "Name")
VALUES
(1, 'Orange'),
(2, 'Spinach'),
(3, 'Milk');

INSERT INTO "NutrientContains" ("NutrientId", "ProductId", "Count")
VALUES
(1, 1, 50),
(2, 2, 2.7),
(3, 3, 120);

INSERT INTO "Recommendations" ("UserId", "NutrientId", "RecommendedCount")
VALUES
(1, 1, 75), 
(1, 2, 8),  
(1, 3, 1000);

INSERT INTO "NutrientConsumptions" ("DiagnosticId", "NutrientId", "Count")
VALUES
(1, 1, 30),
(1, 2, 4), 
(1, 3, 300);

INSERT INTO "PersonalSuggestions" ("Id", "DiagnosticId")
VALUES (1, 1);

INSERT INTO "ProductPersonalSuggestions" ("ProductId", "ProductSuggestionId")
VALUES
(1, 1),
(2, 1),
(3, 1);

UPDATE "Users" SET "DiagnosticId" = 1
WHERE "Id" = 1;