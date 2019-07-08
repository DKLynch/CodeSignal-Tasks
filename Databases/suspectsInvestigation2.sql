/*Please add ; after each select statement*/
CREATE PROCEDURE suspectsInvestigation2()
BEGIN
    SELECT id, name, surname
    FROM Suspect
    WHERE height <= 170
    OR
    lower(name) NOT LIKE 'b%'
    OR
    lower(surname) NOT LIKE 'gre_n'
    ORDER BY id ASC;
END
