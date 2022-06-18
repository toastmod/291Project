select
    c.customer_id,
    concat(first_name, ' ', last_name) as "name",
    mt.rank as "membership",
    c.phone_number,
    c.driver_license_no,
    c.gender,
    c.address_1,
    c.city,
    c.postal_code,
    c.province
from
    customers c,
    membershiptype mt
WHERE
    c.membership_type = mt.membership_id