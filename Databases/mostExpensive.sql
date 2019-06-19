 /*Please add ; after each select statement*/
CREATE PROCEDURE mostExpensive()
BEGIN
    SELECT exp.name
    FROM (
        SELECT name, price, quantity, (quantity * price) as cost
        FROM Products
        ORDER BY cost DESC, name ASC LIMIT 1
    ) exp;
END
