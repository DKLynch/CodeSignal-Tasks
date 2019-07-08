/*Please add ; after each select statement*/
CREATE PROCEDURE suspectsInvestigation()
BEGIN
    SELECT id, name, surname
    FROM Suspect
    WHERE height <= 170
    AND
    lower(name) LIKE 'b%'
    AND
    lower(surname) LIKE 'gre_n'
    ORDER BY id ASC;
END
