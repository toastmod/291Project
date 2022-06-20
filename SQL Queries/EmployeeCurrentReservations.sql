WITH ReservationsAfter as (
    SELECT * FROM (
        SELECT * FROM (
            SELECT * FROM Reservations as R 
            WHERE 2022 >= R.From_Year
        ) as R1 
    WHERE 6 >= R1.From_Month
    ) as R2 
    WHERE 18 >= R2.From_Day
) 


SELECT * FROM (
    SELECT * FROM (
        SELECT * FROM (
            SELECT * FROM ReservationsAfter as RA 
            WHERE 2022 < RA.To_Year
        ) as RA1 
    WHERE 6 < RA1.To_Month
    ) as RA2
) as RA3
WHERE 18 < RA3.To_Day




