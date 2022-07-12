SELECT p.Name, c.Name
FROM Products p
LEFT JOIN ProductsCategories pc
	ON p.Id = pc.ProductId
LEFT JOIN Categories c
	ON pc.CategoryId = c.Id;
ORDER BY p.Name;