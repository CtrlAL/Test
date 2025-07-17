Для запуска использовать Local.

Эндопинт для свагера.
https://localhost:8081/swagger/index.html

.NET 8

erDiagram
    User ||--o{ Diagnostic : "1..*"
    Diagnostic ||--o{ NutrientConsumption : "1..*"
    Diagnostic ||--o{ PersonalSuggestion : "0..1"
    User ||--o{ Recommendation : "1..*"
    Nutrient ||--o{ NutrientConsumption : "1..*"
    Nutrient ||--o{ NutrientContains : "1..*"
    Nutrient ||--o{ Recommendation : "1..*"
    Product ||--o{ NutrientContains : "1..*"
    Product ||--o{ ProductPersonalSuggestion : "1..*"
    PersonalSuggestion ||--o{ ProductPersonalSuggestion : "1..*"

    class User {
        int Id PK
        int? DiagnosticId FK
    }

    class Diagnostic {
        int Id PK
        int UserId FK
        int? PersonalSuggestionId FK
    }

    class PersonalSuggestion {
        int Id PK
        int DiagnosticId FK
    }

    class NutrientConsumption {
        int Id PK
        int DiagnosticId FK
        int NutrientId FK
        float Count
    }

    class Nutrient {
        int Id PK
        string Name
        string Measure
    }

    class Recommendation {
        int Id PK
        int UserId FK
        int NutrientId FK
        float RecommendedCount
    }

    class Product {
        int Id PK
        string Name
    }

    class NutrientContains {
        int Id PK
        int NutrientId FK
        int ProductId FK
        float Count
    }

    class ProductPersonalSuggestion {
        int Id PK
        int ProductId FK
        int ProductSuggestionId FK
    }
