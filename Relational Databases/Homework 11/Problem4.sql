﻿SELECT
  STUDENT_IS.CLIENTS.FIRMA,
  STUDENT_IS.CLIENTS.BANKA
FROM
  STUDENT_IS.CLIENTS
WHERE
  LOWER(STUDENT_IS.CLIENTS.BANKA) LIKE 'райфайзен' OR
  UPPER(STUDENT_IS.CLIENTS.BANKA) LIKE 'ЦКБ'