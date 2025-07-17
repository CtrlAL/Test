-- Nutrients
CREATE TABLE "Nutrients" (
    "Id" SERIAL PRIMARY KEY,
    "Name" VARCHAR(255) NOT NULL,
    "Measure" VARCHAR(50) NOT NULL
);

-- Products
CREATE TABLE "Products" (
    "Id" SERIAL PRIMARY KEY,
    "Name" VARCHAR(255) NOT NULL
);

-- Users
CREATE TABLE "Users" (
    "Id" SERIAL PRIMARY KEY,
    "DiagnosticId" INT
);

-- Diagnostics
CREATE TABLE "Diagnostics" (
    "Id" SERIAL PRIMARY KEY,
    "UserId" INT
);

-- Add FK
ALTER TABLE "Users"
ADD CONSTRAINT fk_user_diagnostic
FOREIGN KEY ("DiagnosticId") REFERENCES "Diagnostics"("Id");

ALTER TABLE "Diagnostics"
ADD CONSTRAINT fk_diagnostic_user
FOREIGN KEY ("UserId") REFERENCES "Users"("Id");

-- Recommendations
CREATE TABLE "Recommendations" (
    "Id" SERIAL PRIMARY KEY,
    "UserId" INT NOT NULL REFERENCES "Users"("Id"),
    "NutrientId" INT NOT NULL REFERENCES "Nutrients"("Id"),
    "RecommendedCount" FLOAT NOT NULL
);

-- NutrientContains
CREATE TABLE "NutrientContains" (
    "Id" SERIAL PRIMARY KEY,
    "NutrientId" INT NOT NULL REFERENCES "Nutrients"("Id"),
    "ProductId" INT NOT NULL REFERENCES "Products"("Id"),
    "Count" FLOAT NOT NULL
);

-- PersonalSuggestions
CREATE TABLE "PersonalSuggestions" (
    "Id" SERIAL PRIMARY KEY,
    "DiagnosticId" INT NOT NULL REFERENCES "Diagnostics"("Id")
);

-- Связь PersonalSuggestions - Products (многие ко многим)
CREATE TABLE "PersonalSuggestionProducts" (
    "PersonalSuggestionId" INT NOT NULL REFERENCES "PersonalSuggestions"("Id"),
    "ProductId" INT NOT NULL REFERENCES "Products"("Id"),
    PRIMARY KEY ("PersonalSuggestionId", "ProductId")
);

-- NutrientConsumptions
CREATE TABLE "NutrientConsumptions" (
    "Id" SERIAL PRIMARY KEY,
    "DiagnosticId" INT NOT NULL REFERENCES "Diagnostics"("Id"),
    "NutrientId" INT NOT NULL REFERENCES "Nutrients"("Id"),
    "Count" FLOAT NOT NULL
);