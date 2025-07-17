CREATE TABLE "ProductPersonalSuggestions" (
    "ProductId" INT NOT NULL REFERENCES "Products"("Id"),
    "ProductSuggestionId" INT NOT NULL REFERENCES "PersonalSuggestions"("Id"),
    PRIMARY KEY ("ProductId", "ProductSuggestionId")
);