﻿SELECT DISTINCT
  STUDENT_IS.PRODUCTS.PRODNAME || ' (цена: ' ||
  STUDENT_IS.PRODUCTS.PRODAJNACENA || 'лв.)' AS "Печалба"
FROM
  STUDENT_IS.PRODUCTS