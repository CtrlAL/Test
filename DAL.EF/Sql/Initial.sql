CREATE TABLE "Nutrients" (
    "Id" SERIAL PRIMARY KEY,
    "Name" VARCHAR(255) NOT NULL,
    "Measure" VARCHAR(50) NOT NULL
);

CREATE TABLE "Products" (
    "Id" SERIAL PRIMARY KEY,
    "Name" VARCHAR(255) NOT NULL
);

CREATE TABLE "Users" (
    "Id" SERIAL PRIMARY KEY
);

CREATE TABLE "Diagnostics" (
    "Id" SERIAL PRIMARY KEY,
    "UserId" INT NOT NULL REFERENCES "Users"("Id"),
    "PersonalSuggestionId" INT NULL REFERENCES "PersonalSuggestions"("Id")
);

CREATE TABLE "Recommendations" (
    "Id" SERIAL PRIMARY KEY,
    "UserId" INT NOT NULL REFERENCES "Users"("Id"),
    "NutrientId" INT NOT NULL REFERENCES "Nutrients"("Id"),
    "RecommendedCount" FLOAT NOT NULL
);

CREATE TABLE "NutrientContains" (
    "Id" SERIAL PRIMARY KEY,
    "NutrientId" INT NOT NULL REFERENCES "Nutrients"("Id"),
    "ProductId" INT NOT NULL REFERENCES "Products"("Id"),
    "Count" FLOAT NOT NULL
);

CREATE TABLE "PersonalSuggestions" (
    "Id" SERIAL PRIMARY KEY,
    "DiagnosticId" INT NOT NULL REFERENCES "Diagnostics"("Id")
);

CREATE TABLE "ProductPersonalSuggestions" (
    "Id" SERIAL PRIMARY KEY,
    "ProductId" INT NOT NULL REFERENCES "Products"("Id"),
    "ProductSuggestionId" INT NOT NULL REFERENCES "PersonalSuggestions"("Id")
);

CREATE TABLE "NutrientConsumptions" (
    "Id" SERIAL PRIMARY KEY,
    "DiagnosticId" INT NOT NULL REFERENCES "Diagnostics"("Id"),
    "NutrientId" INT NOT NULL REFERENCES "Nutrients"("Id"),
    "Count" FLOAT NOT NULL
);

ALTER TABLE "Users"
ADD COLUMN IF NOT EXISTS "DiagnosticId" INT REFERENCES "Diagnostics"("Id");
