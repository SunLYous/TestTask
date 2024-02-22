SELECT p.Name, COALESCE(Categories.CategoryName, 'NULL') AS CategoryName
FROM Production.Product as p
LEFT JOIN Production.ProductSubCategoryDetails as d ON p.ProductID = d.ProductID
LEFT JOIN Production.ProductSubCategory as sub ON d.CategoryID = sub.CategoryID;
